using LibrarySystem.GraphQL.Common;
using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media.Movies
{
    public class MoviePayloadBase : Payload
    {
        protected MoviePayloadBase(Movie movie)
        {
            Movie = movie;
        }

        protected MoviePayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Movie? Movie { get; }
    }
}
