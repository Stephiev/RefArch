using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media
{
    [ExtendObjectType("Query")]
    public class MediaQueries
    {
        public IQueryable<IMediaContent> GetMedias([Service] ApplicationDbContext context)  {
            return context.Books;
        }
    }
}