namespace ServerSidePaging.Models.Books
{
    public class BooksFilterParamsDto
    {
        public int StartRow { get; set; }

        public int EndRow { get; set; }
        public string SortField { get; set; }
        public int SortOrder { get; set; }
        public string GlobalFilter { get; set; }
    }
}
