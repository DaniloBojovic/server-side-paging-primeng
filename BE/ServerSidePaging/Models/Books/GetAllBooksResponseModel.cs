
namespace ServerSidePaging.Models.Books
{
    public class GetAllBooksResponseModel
    {
        public List<Book> Books { get; set; }

        public int TotalRecords { get; set; }
    }
}
