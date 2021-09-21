using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;
using WebApplication3.Services.Interface;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ProdutoModel> Get(long id)
        {
            return await _service.GetProdutoAsync(id);
        }        

        [HttpPost]
        public async Task<long> AddAsync([FromBody] ProdutoModel produto)
        {
            return await _service.AddAsync(produto);
        }
    }
}
