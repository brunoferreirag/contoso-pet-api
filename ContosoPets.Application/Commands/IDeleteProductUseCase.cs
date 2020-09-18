using ContosoPets.Domain;
using System.Threading.Tasks;

namespace ContosoPets.Application.Commands
{
    public interface IDeleteProductUseCase
    {
        Task execute(long id);
    }
}