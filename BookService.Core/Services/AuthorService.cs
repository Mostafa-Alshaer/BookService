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
    public class AuthorService : IAuthorService
    {
        private IAuthorOperations ops;

        public AuthorService(IAuthorOperations ops)
        {
            this.ops = ops;
        }

        public int Insert(Author author)
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.Insert(author);

            // Business rules after execute operation 


            // return result 
            return opsResult;
        }

        public List<Author> SelectAll()
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.SelectAll();

            // Business rules after execute operation 


            // return result
            return opsResult;
        }

        public Author GetById(int id)
        {
            // Business rules before execute operation 


            // execute operation 
            var opsResult = ops.GetById(id);

            // Business rules after execute operation 


            // return result 
            return opsResult;
        }

        public void Update(Author author)
        {
            // Business rules before execute operation 


            // execute operation 
            ops.Update(author);

            // Business rules after execute operation 


        }

        public void Remove(Author author)
        {
            // Business rules before execute operation 


            // execute operation 
            ops.Remove(author);

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
