#pragma checksum "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c72f7dd3e90663863e1aa3d513da9fb8ef4f89a9"
// <auto-generated/>
#pragma warning disable 1591
namespace khadimSarrBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using khadimSarrBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\_Imports.razor"
using khadimSarrBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produits")]
    public partial class RechercherProduitComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Recherche des Produits</h3>\r\n<br>\r\n");
            __builder.OpenComponent<khadimSarrBlazorApp.Pages.SearchBarComponent>(1);
            __builder.AddAttribute(2, "OnSearch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 8 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"
                              HandleSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n<br>\r\n\r\n\r\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>Nom</th>\r\n            <th>Marque</th>\r\n            <th>Prix</th></tr></thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 24 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"
         if(produits!=null && produits.Count() > 0)
          {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"
             foreach( var produit in produits)
                {



#line default
#line hidden
#nullable disable
            __builder.OpenComponent<khadimSarrBlazorApp.Pages.ProductItemComponent>(8);
            __builder.AddAttribute(9, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<khadimSarrBlazorApp.Models.Product>(
#nullable restore
#line 31 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"
                                                produit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 32 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"

              

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"
                 

            }
              else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<tr><td colspan=\"3\">\r\n                     \r\n                     Il n\'y a aucun produit\r\n\r\n                 </td></tr>");
#nullable restore
#line 47 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"


            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\RechercherProduitComponent.razor"
               



            private IEnumerable<Models.Product> produits;


            protected override void OnInitialized()
            {
                base.OnInitialized();

                produits = searchProduit.Execute();


            }

           private void HandleSearch(string filter)
            {
                produits = searchProduit.Execute(filter);

            }



        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RechercherProduit.ISearchProduct searchProduit { get; set; }
    }
}
#pragma warning restore 1591
