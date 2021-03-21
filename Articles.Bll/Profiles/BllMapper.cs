using Articles.BLL.DTO;
using Articles.DAL.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.BLL.Profiles
{
    public class BllMapper : Profile 
    {
        public BllMapper()
        {
            CreateMap<Comment, CommentDTO>()
                .ForMember(dest => dest.Article,
                opts => opts.MapFrom(src => src.Article)).ReverseMap();
            CreateMap<Article, ArticleDTO>()
                .ForMember(dest => dest.Comments,
                opts => opts.MapFrom(src => src.Comments)).ReverseMap();
        }
        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => new BllMapper());
            return config.CreateMapper();
        }
    }
}
