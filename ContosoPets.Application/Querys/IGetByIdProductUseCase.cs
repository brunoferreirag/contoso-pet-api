using ContosoPets.Domain;
using System.Threading.Tasks;

namespace ContosoPets.Application.Querys
{
    public interface IGetByIdProductUseCase
    {
        Task<Product> getById(long id);
    }
}