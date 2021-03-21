using Articles.BLL.Services;
using Articles.BLL.Interfaces;
using Articles.DAL.DB;
using Articles.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Articles.BLL.Profiles;

namespace Articles.CompositionRoot
{
    public class Container
    {
        public IServiceCollection RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ArticleContext>(options => options.UseSqlServer(configuration.GetSection("ConnectionStrings")["DefaultConnection"]));
            services.AddTransient<BllMapper>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IArticleService, ArticleService>();
            services.AddTransient<ICommentService, CommentService>();
            return services;
        }
    }
}
