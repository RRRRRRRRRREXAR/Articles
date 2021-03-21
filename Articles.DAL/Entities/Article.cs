using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.DAL.Entities
{
    public class Article : BaseEntity
    {
        public string Text { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
