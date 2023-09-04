using reader.Controllers;
using reader.Models;
using reader.Repositories;

namespace reader.Services
{
    public interface IBookService
    {
        public Task Add(IBook book);
        public Task Update(IBook book);
        public Task Delete(IBook book);
    }
}