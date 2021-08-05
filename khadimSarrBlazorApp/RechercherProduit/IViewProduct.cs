using khadimSarrBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace khadimSarrBlazorApp.RechercherProduit
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}
