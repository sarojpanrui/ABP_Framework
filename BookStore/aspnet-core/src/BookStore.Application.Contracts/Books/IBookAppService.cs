using BookStore.Books;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books;

public interface IBookAppService :
    ICrudAppService< //Defines CRUD methods
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto> //Used to create/update a book
{

}

//Create a full CRUD service for Book using these DTOs and this primary key type

//Task<BookDto> GetAsync(Guid id);
//Task<PagedResultDto<BookDto>> GetListAsync(...);
//Task<BookDto> CreateAsync(...);
//Task<BookDto> UpdateAsync(...);
//Task DeleteAsync(...);