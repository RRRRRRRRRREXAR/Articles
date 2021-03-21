using Articles.BLL.DTO;
using Articles.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Articles.Profiles
{
    public class PlMapper : Profile 
    {
        public PlMapper()
        {
            CreateMap<ArticleDTO, ArticleModel>()
                .ForMember(dest => dest.Comments,
                opts => opts.MapFrom(src => src.Comments)).ReverseMap();
            CreateMap<CommentDTO, CommentModel>().ReverseMap();
        }
        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => new PlMapper());
            return config.CreateMapper();
        }
    }
}
