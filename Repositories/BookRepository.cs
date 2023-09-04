using reader.Context;
using reader.Models;
using reader.Repositories.Interfaces;

namespace reader.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task Add(BookModel book)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
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
    }
}