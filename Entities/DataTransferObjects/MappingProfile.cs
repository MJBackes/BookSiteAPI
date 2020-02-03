using AutoMapper;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book,BookDTO>();
        }
    }
}
