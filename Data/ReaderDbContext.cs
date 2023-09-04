using Microsoft.EntityFrameworkCore;
using reader.Models;

namespace reader.Data
{
    public class ReaderDbContext : DbContext
    {
        public ReaderDbContext(DbContextOptions<ReaderDbContext> options)
            : base(options)
        { }

        public DbSet<IBook> Books { get; set; }

        
    }
}