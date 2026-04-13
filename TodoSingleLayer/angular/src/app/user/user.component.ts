import { Component, inject, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { UserService } from '../proxy/services/user.service';
import { User } from '../proxy/entities/models';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './user.component.html',
  styleUrl: './user.component.scss',
})
export class UserComponent implements OnInit {
  private userService = inject(UserService);

  users: User[] = [];

  newUser: User = {
    name: '',
    age: 0,
  };

  ngOnInit(): void {
    this.loadUsers();
  }

  loadUsers() {
    this.userService.getList().subscribe(res => {
      this.users = res;
    });
  }

  createUser() {
    this.userService.create(this.newUser).subscribe(res => {
      this.users = [...this.users, res];
      this.newUser = {
        name: '',
        age: 0,
      };
    });
  }

  deleteUser(id: string) {
    this.userService.delete(id).subscribe(() => {
      this.users = this.users.filter(u => u.id !== id);
    });
  }
}
