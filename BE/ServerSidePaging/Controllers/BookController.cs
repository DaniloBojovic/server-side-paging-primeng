using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerSidePaging.Context;
using ServerSidePaging.Models;
using ServerSidePaging.Models.Books;
using ServerSidePaging.Services;

namespace ServerSidePaging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBooksRepository _booksRepository;

        public BookController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        //[HttpGet("GetAllBooks")]
        //public ActionResult<GetAllBooksResponseModel> GetAllBooks([FromQuery]BooksFilterParamsDto filterParams)
        //{
        //    //var result = await _bookService.GetBooks(filterParams);
        //    //return Ok(result);

        //    var booksDto = new List<BookDto>
        //    {
        //        new BookDto {Id = 1, Title = "Name1", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 2, Title = "Name2", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 3, Title = "Name3", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 4, Title = "Name4", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 5, Title = "Name5", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 6, Title = "Name6", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 7, Title = "Name7", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 8, Title = "Name7", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 9, Title = "Name1", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 10, Title = "Name2", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 11, Title = "Name3", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 12, Title = "Name4", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 13, Title = "Name5", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 14, Title = "Name6", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 15, Title = "Name7", Price = 10, Author= "Mario Puzo"},
        //        new BookDto {Id = 16, Title = "Name7", Price = 10, Author= "Mario Puzo"}

        //    };

        //    var books = booksDto.Skip(filterParams.StartRow).Take(filterParams.EndRow).ToList();

        //    return new GetAllBooksResponseModel
        //    {
        //        Books = books,
        //        TotalRecords = booksDto.Count()
        //    };
        //}

        [HttpGet("getbooks")]
        public async Task<ActionResult> GetBooks([FromQuery] BooksFilterParamsDto filterParams)
        {
            var bookEntities = await _booksRepository.GetBooksAsync(filterParams);
            return Ok(bookEntities);
        }
    }
}
