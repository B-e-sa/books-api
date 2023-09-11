using reader.Models;
using reader.Repositories.Interfaces;

namespace reader.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
