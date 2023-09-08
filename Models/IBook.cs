using reader.Enums;

namespace reader.Models
{
    public interface IBook
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ReleaseDate { get; set; }
        public int? NumberOfPages { get; set; }
        public ReadingStatus? ReadingStatus { get; set; }
        public DateTime AddedIn { get; set; }
    }
}
