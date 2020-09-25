#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\CategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe94bc4c89003a248adc231808361bf00da53ac7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\CategoryPage.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\CategoryPage.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class CategoryPage : OwningComponentBase<CategoryServices>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\Learn Blazor\CategoryPage.razor"
       
    List<Category> categories;
    Category objCategory = new Category();

    bool ShowPopup = false;

    protected override void OnInitialized()
    {
        categories = Service.GetCategories();
    }

    void AddNewCategory()
    {
        objCategory = new Category();
        objCategory.Id = 0;
        ShowPopup = true;
    }

    void EditCategory(Category category)
    {
        objCategory = category;
        ShowPopup = true;
    }

    void DeleteCategory()
    {
        ShowPopup = false;
        var result = Service.DeleteCategory(objCategory);
        categories.Clear();
        categories = Service.GetCategories();
    }

    void ClosePopup()
    {
        ShowPopup = false;
    }

    void ValidSubmit()
    {
        var result = false;
        ShowPopup = false;

        if(objCategory.Id > 0)
        {
            result = Service.UpdateCategory(objCategory);
        }
        else
        {
            result = Service.CreateCategory(objCategory);
        }

        categories = Service.GetCategories();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
