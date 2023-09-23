using System.Linq;
using HotChocolate;
using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL
{
    public class Query
    {
        public IQueryable<Book> GetBooks([Service] ApplicationDbContext context) =>
            context.Books;
    }
}