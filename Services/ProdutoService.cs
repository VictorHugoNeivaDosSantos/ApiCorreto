using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;
using WebApplication3.Repositories.Interfaces;
using WebApplication3.Services.Interface;

namespace WebApplication3.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<long> AddAsync(ProdutoModel produto)
        {
            return await _repository.AddAsync(produto);
        }

        public async Task<ProdutoModel> GetProdutoAsync(long id)//
        {
            return await _repository.GetAsync(id);

        }
    }
}
