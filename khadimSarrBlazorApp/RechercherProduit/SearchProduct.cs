using khadimSarrBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace khadimSarrBlazorApp.RechercherProduit
{
    public class SearchProduct : ISearchProduct
    {

        private readonly IProductRepository productRepository;



        public SearchProduct(IProductRepository productRepository)

        {

            this.productRepository = productRepository;

        }



        public IEnumerable<Product> Execute(string filter = null)

        {

            return productRepository.GetProducts(filter);

        }
    }
}
