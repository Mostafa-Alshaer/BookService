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
using AutoMapper;
using BookService.Core.IServices;
using BookService.Models;
using Ninject;

namespace BookService.Controllers
{
    public class AuthorsController : BaseApiController
    {
        private IAuthorService _authorService;

        public AuthorsController()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            _authorService = kernel.Get<IAuthorService>();
        }

        // GET: api/Authors
        public List<AuthorViewModel> GetAuthors()
        {
            return Mapper.Map<List<AuthorViewModel>>(_authorService.SelectAll());
        }
        
    }
}