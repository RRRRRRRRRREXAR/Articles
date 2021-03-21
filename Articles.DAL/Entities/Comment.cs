using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.DAL.Entities
{
    public class Comment : BaseEntity
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set;}
        public Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}
