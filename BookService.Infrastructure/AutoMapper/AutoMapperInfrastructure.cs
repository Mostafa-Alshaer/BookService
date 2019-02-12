using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookService.Core.Models;
using BookService.Infrastructure.DBModels;

namespace BookService.Infrastructure.AutoMapper
{
    public class AutoMapperInfrastructure : Profile
    {
        public AutoMapperInfrastructure()
        {
            CreateMap<Book, DBBook>().ReverseMap();
            CreateMap<Author, DBAuthor>().ReverseMap();
        }
    }
}
