using ContosoPets.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPets.Application.Commands
{
    public class CreateProductUseCase : ICreateProductUseCase
    {
        private readonly IProductWriteOnlyRepository repository;

        public CreateProductUseCase(IProductWriteOnlyRepository repository)
        {
            this.repository = repository;
        }

        public async Task execute(Domain.Product product)
        {
            await repository.Add(product);
        }
    }
}
