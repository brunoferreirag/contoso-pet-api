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
    public class CreateProductUseCaseController : Controller
    {
        private readonly ICreateProductUseCase _createProductUseCase;

        public CreateProductUseCaseController (ICreateProductUseCase createProductUseCase)
        {
            this._createProductUseCase = createProductUseCase;
        }


        /// <summary>
        /// Cria um novo produto no sistema
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <response code="200">Produto criado com sucesso!</response>
        [HttpPost]
        public async Task<IActionResult> Create(Models.Product product)
        {
            await _createProductUseCase.execute(new Domain.Product { Id = product.Id, Name = product.Name, Price = product.Price });
            return CreatedAtAction(nameof(Create), new { Id = product.Id }, product);
        }
    }
}
