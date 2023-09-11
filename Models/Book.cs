using reader.Enums;

namespace reader.Models
{
    public class Book
    {
        public int Id { get; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ReleaseDate { get; set; }
        public int? NumberOfPages { get; set; }
        public ReadingStatus? ReadingStatus { get; set; }
        public DateTime AddedIn { get; } = DateTime.Now;
    }
}
