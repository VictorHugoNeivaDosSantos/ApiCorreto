using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Services
{
    public class ProdutoContext : DbContext
    {
        public DbSet<ProdutoModel> Produto  {get; set; }

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }


    }
}
