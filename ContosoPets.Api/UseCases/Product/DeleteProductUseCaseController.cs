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
    public class DeleteProductUseCaseController : Controller
    {
        private readonly IDeleteProductUseCase _deleteProductUseCase;

        public DeleteProductUseCaseController (IDeleteProductUseCase deleteProductUseCase)
        {
            this._deleteProductUseCase = deleteProductUseCase;
        }

        /// <summary>
        /// Exclui um produto pelo seu ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _deleteProductUseCase.execute(id);
            return NoContent();
        }
    }
}
