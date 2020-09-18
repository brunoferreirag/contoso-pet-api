using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPets.Application.Repositories
{
    public interface IProductWriteOnlyRepository
    {
        Task Add(Domain.Product product);
        Task Delete(long id);
        Task Update(Domain.Product product);
    }
}
