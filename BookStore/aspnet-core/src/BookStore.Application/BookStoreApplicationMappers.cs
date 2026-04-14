using Acme.BookStore.Books;
using BookStore.Books;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;


namespace BookStore;

[Mapper]
public partial class BookStoreApplicationMappers
{
    [Mapper]
    public partial class BookToBookDtoMapper : MapperBase<Book, BookDto>
    {
        public override partial BookDto Map(Book source);

        public override partial void Map(Book source, BookDto destination);
    }

    [Mapper]
    public partial class CreateUpdateBookDtoToBookMapper : MapperBase<CreateUpdateBookDto, Book>
    {
        public override partial Book Map(CreateUpdateBookDto source);

        public override partial void Map(CreateUpdateBookDto source, Book destination);
    }

}
