using BookService.Core.IOperations;
using BookService.Core.IServices;
using BookService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Core.Services
{
    public class BookService : IBookService
    {
        private IBookOperations ops;

        public BookService(IBookOperations ops)
        {
            this.ops = ops;
        }

        public int Insert(Book book)
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.Insert(book);

            // Business rules after execute operation 


            // return result 
            return opsResult;
        }

        public List<Book> SelectAll()
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.SelectAll();

            // Business rules after execute operation 


            // return result
            return opsResult;
        }

        public Book GetById(int id)
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.GetById(id);

            // Business rules after execute operation 


            // return result 
            return opsResult;
        }

        public void Update(Book book)
        {
            // Business rules before execute operation 


            // execute operation 
            ops.Update(book);

            // Business rules after execute operation 


        }

        public void Remove(Book book)
        {
            // Business rules before execute operation 


            // execute operation 
            ops.Remove(book);

            // Business rules after execute operation 

        }

        public bool Exists(int id)
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.Exists(id);

            // Business rules after execute operation 


            // return result 
            return opsResult;
        }
    }
}
