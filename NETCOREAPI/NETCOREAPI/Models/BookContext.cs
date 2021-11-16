using Microsoft.EntityFrameworkCore;

namespace NETCOREAPI.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
