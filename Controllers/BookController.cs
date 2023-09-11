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

    [HttpGet]
    public async Task FindBook(int id)
    {
        await _bookService.FindById(id);
    }

    [HttpPost]
    public async Task AddBook(Book book)
    {
        await _bookService.Add(book);
    }

    [HttpPut]
    public async Task EditBook(int id)
    {
        await _bookService.UpdateById(id);
    }

    [HttpDelete]
    public async Task DeleteBook(int id)
    {
        await _bookService.DeleteById(id);
    }


}
