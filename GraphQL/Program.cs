using LibrarySystem.GraphQL.Data;
using LibrarySystem.GraphQL.Media;
using LibrarySystem.GraphQL.Media.Books;
using LibrarySystem.GraphQL.Media.Movies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the ApplicationDbContext service so it can be injected into resolvers.
builder.Services
    .AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=snolibrary.db"))
    .AddGraphQLServer()
    .AddQueryType(d => d.Name("Query"))
        .AddTypeExtension<MediaQueries>()
        .AddType<Book>()
        .AddType<Movie>()
    .AddMutationType(d => d.Name("Mutation"))
        .AddTypeExtension<BookMutations>()
    .AddSubscriptionType(d => d.Name("Subscription"))
        .AddTypeExtension<BookSubscriptions>()
    .AddInMemorySubscriptions();

var app = builder.Build();

app.UseWebSockets();
app.MapGraphQL();

app.Run();