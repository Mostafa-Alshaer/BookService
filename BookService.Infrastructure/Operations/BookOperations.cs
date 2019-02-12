using BookService.Core.IOperations;
using BookService.Core.Models;
using BookService.Infrastructure.DBRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookService.Infrastructure.DBModels;

namespace BookService.Infrastructure.Operations
{
    public class BookOperations : IBookOperations
    {
        private BookRepository repository = new BookRepository();
        public int Insert(Book book)
        {
            return repository.Insert(Mapper.Map<DBBook>(book));
        }

        public List<Book> SelectAll()
        {
            return Mapper.Map<List<Book>>(repository.Get());
        }

        public Book GetById(int id)
        {
            return Mapper.Map<Book>(repository.Get(id));
        }

        public void Update(Book book)
        {
            repository.Update(Mapper.Map<DBBook>(book));
        }

        public void Remove(Book book)
        {
            repository.Remove(Mapper.Map<DBBook>(book));
        }

        public bool Exists(int id)
        {
            return repository.Exists(id);
        }
        
    }
}
