using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media
{
    [ExtendObjectType("Query")]
    public class MediaQueries
    {
        public IQueryable<IMediaContent> GetMedias([Service] ApplicationDbContext context) 
        => context.Movies;
        // => context.Books;
        // Switch between the above two 
        // to see how you can return two differnt types
        // Unions do not require any common fields
    }
}