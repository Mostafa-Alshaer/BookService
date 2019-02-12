using BookService.Core.IOperations;
using BookService.Core.IServices;
using BookService.Core.Services;
using BookService.Infrastructure.Operations;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.DependencyBindings
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {

            Bind<IBookService>().To<BookService.Core.Services.BookService>();
            Bind<IBookOperations>().To<BookOperations>();

            Bind<IAuthorService>().To<AuthorService>();
            Bind<IAuthorOperations>().To<AuthorOperations>();

        }
    }
}