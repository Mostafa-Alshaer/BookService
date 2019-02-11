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
    public class AuthorOperations : IAuthorOperations
    {
        private AuthorRepository repository = new AuthorRepository();
        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Author author)
        {
            throw new NotImplementedException();
        }

        public void Remove(Author author)
        {
            throw new NotImplementedException();
        }

        public List<Author> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
