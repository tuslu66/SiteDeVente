using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArticleVente.Models;

namespace ArticleVente.Data
{
    public class ArticleVenteContext : DbContext
    {
        public ArticleVenteContext (DbContextOptions<ArticleVenteContext> options)
            : base(options)
        {
        }

        public DbSet<ArticleVente.Models.Article> Article { get; set; } = default!;
    }
}
