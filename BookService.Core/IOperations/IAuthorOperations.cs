using BookService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Core.IOperations
{
    public interface IAuthorOperations
    {
        int Insert(Author author);
        List<Author> SelectAll();
        Author GetById(int id);
        void Update(Author author);
        void Remove(Author author);
        bool Exists(int id);
    }
}
