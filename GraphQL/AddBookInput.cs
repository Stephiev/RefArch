namespace LibrarySystem.GraphQL
{
    public record AddBookInput(
        string Title,
        string Summary,
        string Author);
}