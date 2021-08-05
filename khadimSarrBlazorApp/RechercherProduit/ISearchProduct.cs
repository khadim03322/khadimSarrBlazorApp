using khadimSarrBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace khadimSarrBlazorApp.RechercherProduit
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }






}
