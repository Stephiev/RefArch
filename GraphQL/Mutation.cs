using System.Threading.Tasks;
using LibrarySystem.GraphQL.Data;
using HotChocolate;

namespace LibrarySystem.GraphQL
{
    public class Mutation
    {
        public async Task<AddBookPayload> AddBookAsync(
            AddBookInput input,
            [Service] ApplicationDbContext context)
        {
            var book = new Book
            {
                Title = input.Title,
                Summary = input.Summary,
                Author = input.Author
            };

            context.Books.Add(book);
            await context.SaveChangesAsync();

            return new AddBookPayload(book);
        }
    }
}