using Articles.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.BLL.Interfaces
{
    public interface IArticleService
    {
        Task<ArticleDTO> CreateArticle(ArticleDTO article);
        Task<IEnumerable<ArticleDTO>> GetArticles(); 
    }
}
