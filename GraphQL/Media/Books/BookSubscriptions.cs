using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL.Media.Books
{
    [ExtendObjectType("Subscription")]
    public class BookSubscriptions
    {
        [Subscribe]
        [Topic(nameof(BookMutations.AddBookAsync))]
        public Book OnAdded([EventMessage] Book addedBook)
        => addedBook;
    }
}