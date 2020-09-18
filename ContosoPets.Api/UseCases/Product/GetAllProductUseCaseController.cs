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
    public class GetAllProductUseCaseController : Controller
    {
        private readonly IGetAllProductUseCase _getAllProductUseCase;

        public GetAllProductUseCaseController(IGetAllProductUseCase getAllProductUseCase)
        {
            this._getAllProductUseCase = getAllProductUseCase;
        }
        /// <summary>
        /// Recupera todos os produtos cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<Models.Product>> GetAll()
        {
            var resultsUseCase = await _getAllProductUseCase.getAll();
            var results = new List<Models.Product>();

            resultsUseCase.ForEach(p =>
            {
                results.Add(new Models.Product { Id = p.Id, Name = p.Name, Price = p.Price });
            });
            return Ok(results);
        }
    }
}
