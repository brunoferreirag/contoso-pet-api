using ContosoPets.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPets.Application.Querys
{
    public class GetByIdProductUseCase : IGetByIdProductUseCase
    {
        private readonly IProductReadOnlyRepository _repository;
        public GetByIdProductUseCase(IProductReadOnlyRepository repository)
        {
            this._repository = repository;
        }
        public async Task<Domain.Product> getById(long id)
        {
            var result = await _repository.GetById(id);
            return result;
        }
    }
}
