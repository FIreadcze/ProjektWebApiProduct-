using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProduct.Models;

namespace WebApiProduct.Repository
{
    public class ProductsRepository
    {
        private readonly ProductContext _context;
        public ProductsRepository(ProductContext context)
        {
            this._context = context;
            if (_context.Products.Count() == 0) {
                _context.Products.AddRange(
                    new Product
                    { 
                    Name="Learning ASP.Net Core",
                    Price=(decimal)20.5 ,
                    ImgUri1="www.seznam.cz"

                    },
                    new Product
                    {
                        Name = "Learning Java",
                        Price = (decimal)20.5,
                        ImgUri1 = "www.seznam.cz",
                        Description="popis produktu"
                    }
                    );
                _context.SaveChanges();
            }
        }
        public IEnumerable<Product> GetProducts() {
            return _context.Products.ToList();
        }

        public bool TryGetProduct(int id, out Product product) {
            product = _context.Products.Find(id);
            return (product != null);//should return true otherwise false
        }
        public async Task<int> AddProductAsync(Product product) {
            int rowsAffected = 0;
            _context.Products.Add(product);
            rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected;
        }
    }
}
