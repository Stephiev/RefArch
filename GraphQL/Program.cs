using LibrarySystem.GraphQL;
using LibrarySystem.GraphQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the ApplicationDbContext service so it can be injected into resolvers.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=snolibrary.db"));
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();