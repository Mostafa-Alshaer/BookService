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
            CreateMap<Book, BookViewModel>().ReverseMap();
            CreateMap<Author, AuthorViewModel>().ReverseMap();

            CreateMap<Core.Models.Book, BookDTO>().ForMember(dest => dest.AuthorName,
               opts => opts.MapFrom(src => src.Author.Name));
            CreateMap<BookDTO, Core.Models.Book>();

            CreateMap<Core.Models.Book, BookDetailDTO>().ForMember(dest => dest.AuthorName,
               opts => opts.MapFrom(src => src.Author.Name));
            CreateMap<BookDetailDTO, Core.Models.Book>();
        }
    }
}