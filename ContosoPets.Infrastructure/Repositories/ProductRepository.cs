using ContosoPets.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ContosoPets.Domain;
using ContosoPets.Application.Repositories;
using ContosoPets.Application;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContosoPets.Infrastructure.Repositories
{
    public class ProductRepository : IProductWriteOnlyRepository, IProductReadOnlyRepository
    {
        private readonly ContosoPetsContext _context;

        public ProductRepository(ContosoPetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Domain.Product product)
        {
            Entities.Product productEntity = new Entities.Product();
            productEntity.Id = product.Id;
            productEntity.Name = product.Name;
            productEntity.Price = product.Price;

           await  _context.Products.AddAsync(productEntity);
           await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
           var productEntity = await _context.Products.FindAsync(id);
            _context.Products.Remove(productEntity);
        }

        public async Task<List<Domain.Product>> GetAll()
        {
            var products = await  _context.Products.ToListAsync();

            List<Domain.Product> productsResultados = new List<Domain.Product>();
            products.ForEach(p =>
            {
                productsResultados.Add(new Domain.Product { Id = p.Id, Name = p.Name, Price = p.Price });
            });
            return productsResultados;
        }

        public async Task<Domain.Product> GetById(long id)
        {
            var productEntity = await _context.Products.FindAsync(id);
            if (productEntity == null)
                throw new ArgumentOutOfRangeException("Não encontrado");
            Domain.Product productResultado = new Domain.Product();
            productResultado.Id = productEntity.Id;
            productResultado.Name = productEntity.Name;
            productResultado.Price = productEntity.Price;
            return productResultado;
        }

        public async Task Update(Domain.Product product)
        {
            var productEntity = await _context.Products.FindAsync(product.Id);
            productEntity.Name = product.Name;
            productEntity.Price = product.Price;
            _context.Products.Update(productEntity);
        }
    }
}
