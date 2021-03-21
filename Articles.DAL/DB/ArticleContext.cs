﻿using Articles.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.DAL.DB
{
    public class ArticleContext: DbContext
    {
        DbSet<Article> Articles { get; set; }
        DbSet<Comment> Comments { get; set; }

        public ArticleContext(DbContextOptions<ArticleContext> contextOptions): base(contextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
