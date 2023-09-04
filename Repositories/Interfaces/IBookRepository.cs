using reader.Models;

namespace reader.Repositories.Interfaces
{
    public interface IBookRepository
    {
        public Task Add(BookModel book);
        public Task FindById(int id);
        public Task FindByName(string name);
        public Task Delete(int id);
    }
}