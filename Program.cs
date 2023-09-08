using Microsoft.EntityFrameworkCore;
using reader.Data;
using reader.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ReaderDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Database")
    ));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
