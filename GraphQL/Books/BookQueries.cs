using System.Linq;
using HotChocolate;
using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Books
{
    [ExtendObjectType("Query")]
    public class BookQueries
    {
        public IQueryable<Book> GetBooks([Service] ApplicationDbContext context) =>
            context.Books;
    }
}