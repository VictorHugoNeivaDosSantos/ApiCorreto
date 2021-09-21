using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Services.Interface
{
    public interface IProdutoService
    {
        Task<long> AddAsync(ProdutoModel produto);
        Task<ProdutoModel> GetProdutoAsync(long id);
    }
}