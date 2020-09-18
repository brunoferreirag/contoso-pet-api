using ContosoPets.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPets.Application.Commands
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductWriteOnlyRepository repository;

        public DeleteProductUseCase(IProductWriteOnlyRepository repository)
        {
            this.repository = repository;
        }

        public async Task execute(long id)
        {
            await repository.Delete(id);
        }
    }
}
