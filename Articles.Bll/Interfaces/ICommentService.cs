using Articles.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.BLL.Interfaces
{
    public interface ICommentService
    {
        Task<CommentDTO> CreateComment(CommentDTO comment);
        Task<IEnumerable<CommentDTO>> GetComments(int articleId);
    }
}
