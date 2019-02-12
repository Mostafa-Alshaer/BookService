using BookService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Core.IServices
{
    public interface IAuthorService
    {
        Author Insert(Author author);
        List<Author> SelectAll();
        Author GetById(int id);
        void Update(Author author);
        void Remove(Author author);
        bool Exists(int id);
    }
}
