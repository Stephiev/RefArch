using LibrarySystem.GraphQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the ApplicationDbContext service so it can be injected into resolvers.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=snolibrary.db"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();