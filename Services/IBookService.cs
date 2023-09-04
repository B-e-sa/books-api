using reader.Controllers;
using reader.Models;
using reader.Repositories;

namespace reader.Services
{
    public interface IBookService
    {
        public Task Add(IBookModel book);
        public Task Update(IBookModel book);
        public Task Delete(IBookModel book);
    }
}