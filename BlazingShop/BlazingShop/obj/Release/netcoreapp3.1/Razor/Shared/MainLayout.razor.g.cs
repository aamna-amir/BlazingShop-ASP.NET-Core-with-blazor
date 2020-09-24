#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970b42b1ddeaaab7df6cf524754d916ae4204f3d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazingShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazingShop.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4 auth");
            __builder.AddAttribute(11, "style", "background-color: #05163D");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenComponent<BlazingShop.Shared.LoginDisplay>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content px-4");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddContent(20, 
#nullable restore
#line 14 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Shared\MainLayout.razor"
      
    private bool isServerSide = false;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            await BootstrapCss.SetBootstrapCss("4.3.1");
        }
        catch (Exception)
        {
            isServerSide = true;
        }
    }

    //protected override async Task OnAfterRenderAsync(bool firstRun)
    //{
    //    if (isServerSide == true && firstRun == true)
    //    {
    //        await BootstrapCss.SetBootstrapCss("4.3.1");
    //    }
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBootstrapCss BootstrapCss { get; set; }
    }
}
#pragma warning restore 1591
