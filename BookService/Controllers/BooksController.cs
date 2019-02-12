using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BookService.Core.IServices;
using BookService.Core.IServices;
using BookService.Core.Services;
using BookService.Models;
using Ninject;
using AutoMapper;
using BookService.Core.Models;

namespace BookService.Controllers
{
    public class BooksController : BaseApiController
    {
        private IBookService _bookService;

        public BooksController()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            _bookService = kernel.Get<IBookService>();
        }

        // GET api/Books
        public List<BookDTO> GetBooks()
        {
            return Mapper.Map<List<BookDTO>>(_bookService.SelectAll());
        }

        // GET api/Books/5
        [ResponseType(typeof(BookDetailDTO))]
        public IHttpActionResult GetBook(int id)
        {
            var book = Mapper.Map<BookDetailDTO>(_bookService.GetById(id));

            if (book == null)
            {
                return NotFound();
            }    
            
            return Ok(book);
        }

        // PUT: api/Books/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBook(int id, BookViewModel book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != book.Id)
            {
                return BadRequest();
            }

            try
            {
                _bookService.Update(Mapper.Map<Book>(book));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(BookDTO))]
        public IHttpActionResult PostBook(BookViewModel book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BookDTO dto = Mapper.Map<BookDTO>(_bookService.Insert(Mapper.Map<Book>(book)));

            return CreatedAtRoute("DefaultApi", new { id = dto.Id }, dto);
        }

        // DELETE: api/Books/5
        [ResponseType(typeof(BookViewModel))]
        public IHttpActionResult DeleteBook(int id)
        {
            BookViewModel book = Mapper.Map<BookViewModel>(_bookService.GetById(id));
            if (book == null)
            {
                return NotFound();
            }

            _bookService.Remove(Mapper.Map<Book>(book));

            return Ok(book);
        }

        private bool BookExists(int id)
        {
            return _bookService.Exists(id);
        }
    }
}