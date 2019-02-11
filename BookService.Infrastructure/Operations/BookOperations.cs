using BookService.Core.IOperations;
using BookService.Core.Models;
using BookService.Infrastructure.DBRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Infrastructure.Operations
{
    public class BookOperations : IBookOperations
    {
        private BookRepository repository = new BookRepository();
        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Book book)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
