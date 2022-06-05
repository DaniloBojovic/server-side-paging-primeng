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

        [HttpGet("getbooks")]
        public async Task<ActionResult> GetBooks([FromQuery] BooksFilterParamsDto filterParams)
        {
            var bookEntities = await _booksRepository.GetBooksAsync(filterParams);
            return Ok(bookEntities);
        }
    }
}
