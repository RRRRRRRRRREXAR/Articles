using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.BLL.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}
