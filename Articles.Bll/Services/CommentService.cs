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
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public CommentService(IUnitOfWork uow, BllMapper mapper)
        {
            _uow = uow;
            _mapper = mapper.GetMapper();
        }
        public async Task CreateComment(CommentDTO comment)
        {
            var com = _mapper.Map<Comment>(comment);
            com.Article = await _uow.Repository<Article>().Find(a => a.Id == com.ArticleId);
            com.Date = DateTime.Now;
            await _uow.Repository<Comment>().Create(com);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<CommentDTO>> GetComments(int articleId)
        {
            var result = await _uow.Repository<Comment>().FindMany(x => x.Article.Id == articleId);
            return _mapper.Map<IEnumerable<CommentDTO>>(result);
        }
    }
}
