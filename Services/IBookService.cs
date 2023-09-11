using reader.Models;

namespace reader.Services
{
    public interface IBookService
    {
        public Task Add(Book book);
        public Task Update(Book book);
        public Task Delete(Book book);
        public Task Get(Book book);
    }
}
