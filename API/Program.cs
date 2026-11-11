
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
