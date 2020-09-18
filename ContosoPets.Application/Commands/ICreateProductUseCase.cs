using ContosoPets.Domain;
using System.Threading.Tasks;

namespace ContosoPets.Application.Commands
{
    public interface ICreateProductUseCase
    {
        Task execute(Product product);
    }
}