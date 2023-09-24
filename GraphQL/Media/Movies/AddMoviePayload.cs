using LibrarySystem.GraphQL.Common;
using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media.Movies
{
    public class AddMoviePayload : MoviePayloadBase
    {
        public AddMoviePayload(UserError error)
            : base(new[] { error })
        {
        }

        public AddMoviePayload(Movie movie) : base(movie)
        {
        }

        public AddMoviePayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
