using ServerSidePaging.Models;
using ServerSidePaging.Models.Books;

namespace ServerSidePaging.Services
{
    public interface IBooksRepository
    {
        Task<GetAllBooksResponseModel> GetBooksAsync(BooksFilterParamsDto filterParams);
    }
}
