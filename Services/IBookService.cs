using reader.Models;

namespace reader.Services
{
    public interface IBookService
    {
        public Task Add(Book book);
        public Task UpdateById(int id);
        public Task DeleteById(int id);
        public Task FindById(int id);
        public Task FindByName(string name);
    }
}
