using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}
