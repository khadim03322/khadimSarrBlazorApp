// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ViewProduitComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\ksarr\source\repos\khadimSarrBlazorApp\khadimSarrBlazorApp\Pages\ViewProduitComponent.razor"
       

    private Models.Product produit;



    [Parameter]

    public int Id { get; set; }



    protected override void OnParametersSet()

    {

        base.OnParametersSet();



        if (Id > 0)

            produit = viewProduct.Execute(Id);



    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RechercherProduit.IViewProduct viewProduct { get; set; }
    }
}
#pragma warning restore 1591
