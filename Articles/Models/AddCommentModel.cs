using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class AddCommentModel
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public int ArticleId { get; set; }
    }
}
