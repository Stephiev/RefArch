using LibrarySystem.GraphQL.Media;

namespace LibrarySystem.GraphQL.Media.Movies
{
    public record AddMovieInput(
        string Title,
        string Summary,
        string Director);
}