using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.GraphQL.Data
{

// DbContext represents a session with the database and 
// can be used to query and save instances of your entities.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}