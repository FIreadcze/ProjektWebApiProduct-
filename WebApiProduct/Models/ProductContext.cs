using Microsoft.EntityFrameworkCore;
//musim nainstalovat miscrosoft entity framework core!!
using WebApiProduct.Models;
namespace WebApiProduct.Models
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { 
        
        }

        public DbSet <Product> Products{ get; set; }
    }
}
 