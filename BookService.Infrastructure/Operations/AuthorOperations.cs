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
    public class AuthorOperations : IAuthorOperations
    {
        private AuthorRepository repository = new AuthorRepository();
        public int Insert(Author author)
        {
            return repository.Insert(Mapper.Map<DBAuthor>(author));
        }

        public List<Author> SelectAll()
        {
            return Mapper.Map<List<Author>>(repository.Get());
        }

        public Author GetById(int id)
        {
            return Mapper.Map<Author>(repository.Get(id));
        }

        public void Update(Author author)
        {
            repository.Update(Mapper.Map<DBAuthor>(author));
        }

        public void Remove(Author author)
        {
            repository.Remove(Mapper.Map<DBAuthor>(author));
        }

        public bool Exists(int id)
        {
            return repository.Exists(id);
        }
        
    }
}
