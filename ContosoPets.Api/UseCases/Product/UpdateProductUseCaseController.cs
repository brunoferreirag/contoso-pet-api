using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPets.Application.Commands;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoPets.Api.UseCases.Product
{
    [ApiController]
    [Route("api/product")]
    public class UpdateProductUseCaseController : Controller
    {
        private readonly IUpdateProductUseCase _updateProductUseCase;

        public UpdateProductUseCaseController (IUpdateProductUseCase updateProductUseCase)
        {
            this._updateProductUseCase = updateProductUseCase;
        }

        /// <summary>
        /// Atualiza um produto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(Models.Product product)
        {
            await _updateProductUseCase.execute(new Domain.Product { Id = product.Id, Name = product.Name, Price = product.Price });
            return NoContent();
        }
    }
}
