using LibrarySystem.GraphQL.Data;

namespace LibrarySystem.GraphQL
{
    public class AddBookPayload
    {
        public AddBookPayload(Book book)
        {
            Book = book;
        }

        public Book Book { get; }
    }
}