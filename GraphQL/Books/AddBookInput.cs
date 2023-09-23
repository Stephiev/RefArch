namespace LibrarySystem.GraphQL.Books
{
    public record AddBookInput(
        string Title,
        string Summary,
        string Author);
}