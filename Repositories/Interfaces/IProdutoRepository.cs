using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Task<long> AddAsync(ProdutoModel produto);
        Task<ProdutoModel> GetAsync(long id);
        Task<string> GetDescricaoAsync(long id);
    }
}