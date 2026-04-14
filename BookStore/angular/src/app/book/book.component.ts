import { CommonModule } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import {
  NgxDatatableListDirective,
  NgxDatatableDefaultDirective,
  ModalComponent,
} from '@abp/ng.theme.shared';

import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { BookDto } from '@proxy/books';
import { BookService } from '@proxy/acme/book-store/books';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import {
  NgbDateNativeAdapter,
  NgbDateAdapter,
  NgbDatepickerModule,
} from '@ng-bootstrap/ng-bootstrap';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ReactiveFormsModule } from '@angular/forms';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { LocalizationModule } from '@abp/ng.core';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { bookTypeOptions } from '../proxy/books';



@Component({
  selector: 'app-book',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    NgxDatatableModule,
    NgxDatatableListDirective,
    NgxDatatableDefaultDirective,
    ModalComponent,
    ThemeSharedModule,
    NgbDatepickerModule,
    NgbDropdownModule,
    LocalizationModule,
    
  ],
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.scss'],
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class BookComponent implements OnInit {
  book = { items: [], totalCount: 0 } as PagedResultDto<BookDto>;

  isModalOpen = false;
  selectedBook = {} as BookDto;
  bookTypes = bookTypeOptions;

  public readonly list = inject(ListService);
  private readonly bookService = inject(BookService);
  private readonly fb = inject(FormBuilder); // inject FormBuilder
  private readonly confirmation = inject(ConfirmationService);

  ngOnInit() {
    const bookStreamCreator = (query: any) => this.bookService.getList(query);

    this.list.hookToQuery(bookStreamCreator).subscribe(response => {
      this.book = response;
    });
  }

  form!: FormGroup;

  //add new method
  createBook() {
    this.selectedBook = {} as BookDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  // add buildForm method
  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedBook.name || '', Validators.required],
      type: [this.selectedBook.type || null, Validators.required],
      publishDate: [
        this.selectedBook.publishDate ? new Date(this.selectedBook.publishDate) : null,
        Validators.required,
      ],
      price: [this.selectedBook.price || null, Validators.required],
    });
  }
  editBook(id: string) {
    this.bookService.get(id).subscribe(book => {
      this.selectedBook = book;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  // add save method
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedBook.id
      ? this.bookService.update(this.selectedBook.id, this.form.value)
      : this.bookService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

   delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.bookService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
}
