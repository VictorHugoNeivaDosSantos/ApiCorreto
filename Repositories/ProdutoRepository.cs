using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;
using WebApplication3.Repositories.Interfaces;
using WebApplication3.Services;

namespace WebApplication3.Repositories
{

    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext context)
        {
            _context = context;
        }

        public async Task<long> AddAsync(ProdutoModel produto)
        {
            await _context.AddAsync(produto);
            await _context.SaveChangesAsync();
            return produto.Id;
        }

        public async Task<ProdutoModel> GetAsync(long id)
        {
            return await _context.Produto.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<string> GetDescricaoAsync(long id)
        {
            return await _context.Produto.Where(w => w.Id == id).Select(s => s.Descricao).FirstOrDefaultAsync();//
        }
    }
}
