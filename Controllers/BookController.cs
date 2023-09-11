using Microsoft.AspNetCore.Mvc;
using reader.Models;
using reader.Services;
namespace reader.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpPost]
    public async Task AddBook(Book book)
    {
        await _bookService.Add(book);
    }
}
