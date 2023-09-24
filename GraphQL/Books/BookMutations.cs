using System.Threading.Tasks;
using LibrarySystem.GraphQL.Data;
using HotChocolate.Types;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace LibrarySystem.GraphQL.Books
{

    [ExtendObjectType("Mutation")]
    public class BookMutations
    {

        public async Task<AddBookPayload> AddBookAsync(
            AddBookInput input,
            [Service] ApplicationDbContext context,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken) // Can be aborted if the mutation is aborted
        {
            var book = new Book
            {
                Title = input.Title,
                Summary = input.Summary,
                Author = input.Author
            };

            context.Books.Add(book);
            await context.SaveChangesAsync();

            // In the real world you would want your event paylod
            // to be small as it's going over the wire
            await eventSender.SendAsync(nameof(AddBookAsync), book, cancellationToken);

            return new AddBookPayload(book);
        }
    }
}