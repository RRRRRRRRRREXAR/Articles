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
                opts => opts.MapFrom(src => src.Comments))
                .ForMember(dest => dest.Id,
                opts => opts.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<CommentDTO, CommentModel>()
                .ForMember(dest => dest.Article,
                opts => opts.MapFrom(src => src.Article))
                .ReverseMap();
        }
        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PlMapper>());
            return config.CreateMapper();
        }
    }
}
