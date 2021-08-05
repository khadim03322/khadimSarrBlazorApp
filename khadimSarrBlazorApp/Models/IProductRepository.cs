using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace khadimSarrBlazorApp.Models
{
    public interface IProductRepository
    {
        public Product GetProduct(int id);
        public IEnumerable<Product> GetProducts(string filter = null);
    }
}
