using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPets.Application.Commands;
using ContosoPets.Application.Querys;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoPets.Api.UseCases.Product
{
    [ApiController]
    [Route("api/product")]
    public class GetProductByIdUseCaseController : Controller
    {
        private readonly IGetByIdProductUseCase _getByIdProductUseCase;

        public GetProductByIdUseCaseController(IGetByIdProductUseCase getByIdProductUseCase)
        {
            this._getByIdProductUseCase = getByIdProductUseCase;
        }

        /// <summary>
        /// Recupera um produto através do id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Product>> GetById(long id)
        {
            var resultUseCase = await _getByIdProductUseCase.getById(id);
            var result = new Models.Product { Id = resultUseCase.Id, Name = resultUseCase.Name, Price = resultUseCase.Price };
            return result;
        }
    }
}
