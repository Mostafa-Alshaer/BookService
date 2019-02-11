using BookService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Core.IOperations
{
    public interface IBookOperations
    {
        int Insert(Book book);
        List<Book> SelectAll();
        Book GetById(int id);
        void Update(Book book);
        void Remove(Book book);
        bool Exists(int id);
    }
}
