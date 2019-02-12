using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BookService.Core.Models;
using BookService.Models;

namespace BookService.AutoMapper
{
    public class AutoMapperApplication : Profile
    {
        public AutoMapperApplication()
        {
            CreateMap<Core.Models.Book, BookDTO>().ReverseMap();
            CreateMap<Core.Models.Book, BookDetailDTO>().ReverseMap();
        }
    }
}