using Microsoft.EntityFrameworkCore;
using ServerSidePaging.Context;
using ServerSidePaging.Models;
using ServerSidePaging.Models.Books;
using System;
using System.Linq;

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

            var sort = filterParams.SortField + " " + filterParams.SortOrder;
            switch (sort)
            {
                case "title 1":
                    bookAll = (from a in bookAll
                               orderby a.Title ascending
                             select a).ToList();
                    break;
                case "title -1":
                    bookAll = (from a in bookAll
                               orderby a.Title descending
                             select a).ToList();
                    break;
                case "author 1":
                    bookAll = (from a in bookAll
                               orderby a.Author ascending
                               select a).ToList();
                    break;
                case "author -1":
                    bookAll = (from a in bookAll
                               orderby a.Author descending
                               select a).ToList();
                    break;
                case "description 1":
                    bookAll = (from a in bookAll
                               orderby a.Description ascending
                               select a).ToList();
                    break;
                case "description -1":
                    bookAll = (from a in bookAll
                               orderby a.Description descending
                               select a).ToList();
                    break;
            }

            var books = bookAll.Skip(filterParams.StartRow).Take(filterParams.EndRow).ToList();

            //var resultBooks = books.Where(b => b.Contains(filterParams.GlobalFilter));
            var searchCriteria = filterParams.GlobalFilter != "null" ? filterParams.GlobalFilter : "";
            var resultBooks = books.Where(x => x.Title.Contains(searchCriteria)).ToList();

            return new GetAllBooksResponseModel
            {
                Books = resultBooks,
                TotalRecords = bookAll.Count,
            };
        }
    }
}
