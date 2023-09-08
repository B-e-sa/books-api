using reader.Models;

namespace reader.Services
{
    public interface IBookService
    {
        public Task Add(IBook book);
        public Task Update(IBook book);
        public Task Delete(IBook book);
        public Task Get(IBook book);
    }
}