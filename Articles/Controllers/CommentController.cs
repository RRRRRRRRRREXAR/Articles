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
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, PlMapper profile)
        {
            _commentService = commentService;
            _mapper = profile.GetMapper();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<CommentModel>> Get(int articleId)
        {
            var result = await _commentService.GetComments(articleId);
            return _mapper.Map<IEnumerable<CommentModel>>(result);
        }

        // POST api/<CommentController>
        [HttpPost]
        public async Task Post([FromBody] CommentModel comment)
        {
            await _commentService.CreateComment(_mapper.Map<CommentDTO>(comment));
        }
    }
}
