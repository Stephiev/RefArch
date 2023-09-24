namespace LibrarySystem.GraphQL.Media.Books
{
    public record AddBookInput(
        string Title,
        string Summary,
        string Author);
}