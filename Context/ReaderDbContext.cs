using Microsoft.EntityFrameworkCore;
using reader.Models;

namespace reader.Context
{
    public class ReaderDbContext : DbContext
    {
        public ReaderDbContext(DbContextOptions<ReaderDbContext> options)
            : base(options)
        { }

        public DbSet<BookModel> Books { get; set; }
    }
}