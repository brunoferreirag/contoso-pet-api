using ContosoPets.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoPets.Application.Querys
{
    public interface IGetAllProductUseCase
    {
        Task<List<Product>> getAll();
    }
}