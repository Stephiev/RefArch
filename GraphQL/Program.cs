using LibrarySystem.GraphQL;
using LibrarySystem.GraphQL.Books;
using LibrarySystem.GraphQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the ApplicationDbContext service so it can be injected into resolvers.
builder.Services
    .AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=snolibrary.db"))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType(d => d.Name("Mutation"))
        .AddTypeExtension<BookMutations>();

var app = builder.Build();

app.MapGraphQL();

app.Run();