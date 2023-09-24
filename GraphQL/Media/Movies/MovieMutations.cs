using System.Threading.Tasks;
using LibrarySystem.GraphQL.Data;
using HotChocolate.Types;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace LibrarySystem.GraphQL.Media.Movies
{

    [ExtendObjectType("Mutation")]
    public class MovieMutations
    {

        public async Task<AddMoviePayload> AddMovieAsync(
            AddMovieInput input,
            [Service] ApplicationDbContext context,
            [Service] ITopicEventSender eventSender,
            CancellationToken cancellationToken) // Can be aborted if the mutation is aborted
        {
            var book = new Movie
            {
                Title = input.Title,
                Summary = input.Summary,
                Director = input.Director
            };

            context.Movies.Add(book);
            await context.SaveChangesAsync();

            // In the real world you would want your event paylod
            // to be small as it's going over the wire
            await eventSender.SendAsync(nameof(AddMovieAsync), book, cancellationToken);

            return new AddMoviePayload(book);
        }
    }
}