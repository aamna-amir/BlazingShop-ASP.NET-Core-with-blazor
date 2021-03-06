#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2f285fa69ccc6bcd8a47cc2022f9bcca4248f7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Pages.Learn_Blazor
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
#nullable restore
#line 3 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazingShop.Shared.Document>(0);
            __builder.AddAttribute(1, "Title", "FetchData");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.AddMarkupContent(3, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(4, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 12 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 15 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 28 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 36 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 39 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
