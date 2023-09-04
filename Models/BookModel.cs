namespace reader.Models
{
    public class BookModel : IBookModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ReleaseDate { get; set; }
        public int? NumberOfPages { get; set; }
    }
}