using ContosoPets.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPets.Application.Querys
{
    public class GetAllProductUseCase : IGetAllProductUseCase
    {
        private readonly IProductReadOnlyRepository _repository;
        public GetAllProductUseCase(IProductReadOnlyRepository repository)
        {
            this._repository = repository;
        }
        public async Task<List<Domain.Product>> getAll()
        {
            var result = await _repository.GetAll();
            return result;
        }
    }
}
