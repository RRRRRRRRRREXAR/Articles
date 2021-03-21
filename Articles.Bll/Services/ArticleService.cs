using Articles.BLL.DTO;
using Articles.BLL.Interfaces;
using Articles.BLL.Profiles;
using Articles.DAL.Entities;
using Articles.DAL.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.BLL.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork uow, BllMapper mapper)
        {
            _uow = uow;
            _mapper = mapper.GetMapper();
        }
        public async Task CreateArticle(ArticleDTO article)
        {
            await _uow.Repository<Article>().Create(_mapper.Map<Article>(article));
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<ArticleDTO>> GetArticles()
        {
            var result = await _uow.Repository<Article>().GetAll();
            return _mapper.Map<IEnumerable<ArticleDTO>>(result);
        }
    }
}
