using Microsoft.EntityFrameworkCore;
using ServerSidePaging.Context;
using ServerSidePaging.Models;
using ServerSidePaging.Models.Books;

namespace ServerSidePaging.Services
{
    public class BooksRepository : IBooksRepository
    {
        private BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context;
        }
        public async Task<GetAllBooksResponseModel> GetBooksAsync(BooksFilterParamsDto filterParams)
        {
            var bookAll = await _context.Books.ToListAsync();
            var books = bookAll.Skip(filterParams.StartRow).Take(filterParams.EndRow).ToList();
            return new GetAllBooksResponseModel
            {
                Books = books,
                TotalRecords = bookAll.Count,
            };
        }
    }
}
