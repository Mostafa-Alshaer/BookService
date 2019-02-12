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

        //[ResponseType(typeof(BookDTO))]
        //public async Task<IHttpActionResult> PostBook(BookViewModel book)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    //db.Books.Add(book);
        //    await db.SaveChangesAsync();

        //    // New code:
        //    // Load author name
        //    db.Entry(book).Reference(x => x.Author).Load();

        //    var dto = new BookDTO()
        //    {
        //        Id = book.Id,
        //        Title = book.Title,
        //        AuthorName = book.Author.Name
        //    };

        //    return CreatedAtRoute("DefaultApi", new { id = book.Id }, dto);
        //}

        //// DELETE: api/Books/5
        //[ResponseType(typeof(BookViewModel))]
        //public async Task<IHttpActionResult> DeleteBook(int id)
        //{
        //    BookViewModel book = await db.Books.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    //db.Books.Remove(book);
        //    await db.SaveChangesAsync();

        //    return Ok(book);
        //}
       
        private bool BookExists(int id)
        {
            return _bookService.Exists(id);
        }
    }
}