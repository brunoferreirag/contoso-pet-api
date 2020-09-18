using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoPets.Application.Repositories
{
    public interface IProductReadOnlyRepository
    {
        Task<Domain.Product> GetById(long id);
        Task<List<Domain.Product>> GetAll();
    }
}
