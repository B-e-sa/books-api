using reader.Controllers;
using reader.Models;
using reader.Repositories;

namespace reader.Services
{
    public class BookService : IBookService
    {
        public Task Add(IBook book)
        {
            if(book != null)
            {
            }

            throw new NotImplementedException();
        }

        public Task Delete(IBook book)
        {
            if(book != null)
            {
            }

            throw new NotImplementedException();
        }

        public Task Update(IBook book)
        {
            if(book != null)
            {

            }

            throw new NotImplementedException();
        }
    }
}