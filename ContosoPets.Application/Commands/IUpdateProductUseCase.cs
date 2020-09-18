using ContosoPets.Domain;
using System.Threading.Tasks;

namespace ContosoPets.Application.Commands
{
    public interface IUpdateProductUseCase
    {
        Task execute(Product product);
    }
}