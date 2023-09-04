using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reader.Models;

namespace reader.Context.Map
{
    public class BookMap : IEntityTypeConfiguration<IBookModel>
    {
        public void Configure(EntityTypeBuilder<IBookModel> builder)
        {
            builder.HasKey(book => book.Id);

            builder.Property(book => book.Title)
                .HasMaxLength(100);

            builder.Property(book => book.Description)
                .HasMaxLength(300);

            builder.Property(book => book.Author)
                .HasMaxLength(30);

            builder.Property(book => book.Publisher)
                .HasMaxLength(30);

            builder.Property(book => book.ReleaseDate);

            builder.Property(book => book.NumberOfPages);

            builder.Property(book => book.AddedIn)
                .ValueGeneratedOnAdd();
        }
    }
}