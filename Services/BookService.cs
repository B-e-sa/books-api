using reader.Controllers;
using reader.Models;
using reader.Repositories;

namespace reader.Services
{
    public class BookService : IBookService
    {
        public Task Add(IBookModel book)
        {
            if(book != null)
            {
            }

            throw new NotImplementedException();
        }

        public Task Delete(IBookModel book)
        {
            if(book != null)
            {
            }

            throw new NotImplementedException();
        }

        public Task Update(IBookModel book)
        {
            if(book != null)
            {

            }

            throw new NotImplementedException();
        }
    }
}