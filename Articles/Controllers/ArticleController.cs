using Articles.BLL.DTO;
using Articles.BLL.Interfaces;
using Articles.Models;
using Articles.Profiles;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Articles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, PlMapper profile)
        {
            _articleService = articleService;
            _mapper = profile.GetMapper();
        }
        // GET: api/<ArticleController>
        [HttpGet]
        public async Task<IEnumerable<ArticleModel>> Get()
        {
            var result = await _articleService.GetArticles();
            return _mapper.Map<IEnumerable<ArticleModel>>(result);
        }

        // POST api/<ArticleController>
        [HttpPost]
        public async Task Post([FromBody] ArticleModel model)
        {
            await _articleService.CreateArticle(_mapper.Map<ArticleModel, ArticleDTO>(model));
        }
    }
}
