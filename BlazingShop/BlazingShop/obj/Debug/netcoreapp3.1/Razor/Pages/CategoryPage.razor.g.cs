#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe94bc4c89003a248adc231808361bf00da53ac7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Pages
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
#line 2 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
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
#nullable restore
#line 7 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading or No category exists.</em></p>\r\n");
#nullable restore
#line 10 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container border p-3");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"col-5\">\r\n                <h1 class=\"text-info\">Category List</h1>\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-3");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-info form-control");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                    AddNewCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Add New Category");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row pt-4");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-striped");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<thead>\r\n                    <tr>\r\n                        <th>Category Name</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 32 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                     foreach (var obj in categories)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                        ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 35 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                 obj.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "style", "width:150px");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                              (()=>EditCategory(obj))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "\r\n                                    Edit\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 42 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 47 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 49 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal");
            __builder.AddAttribute(54, "tabindex", "-1");
            __builder.AddAttribute(55, "style", "display:block");
            __builder.AddAttribute(56, "role", "dialog");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(58);
            __builder.AddAttribute(59, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 52 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                          objCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 52 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                       ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "modal-dialog");
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "modal-content");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "modal-header");
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.OpenElement(72, "h3");
                __builder2.AddAttribute(73, "class", "text-info");
                __builder2.AddContent(74, 
#nullable restore
#line 56 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                objCategory.Id != 0 ? "Update" : "Create" 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(75, " Category");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "type", "button");
                __builder2.AddAttribute(79, "class", "close");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                      ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(81, "\r\n                            ");
                __builder2.AddMarkupContent(82, "<span aria-hidden=\"true\">X</span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "modal-body");
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(88);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(90);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "row");
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-9");
                __builder2.AddMarkupContent(97, "\r\n                                ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "row py-2");
                __builder2.AddMarkupContent(100, "\r\n                                    ");
                __builder2.AddMarkupContent(101, "<div class=\"col-4\">\r\n                                        Category Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-8");
                __builder2.AddMarkupContent(104, "\r\n                                        ");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "type", "text");
                __builder2.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                       objCategory.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCategory.Name = __value, objCategory.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "row py-2");
                __builder2.AddMarkupContent(115, "\r\n                                    ");
                __builder2.AddMarkupContent(116, "<div class=\"offset-4 col\">\r\n                                        <button class=\"btn btn-outline-primary\" type=\"submit\">Submit</button>\r\n                                    </div>\r\n");
#nullable restore
#line 78 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                     if (objCategory.Id > 0)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(117, "                                        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col");
                __builder2.AddMarkupContent(120, "\r\n                                            ");
                __builder2.OpenElement(121, "button");
                __builder2.AddAttribute(122, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(123, "type", "submit");
                __builder2.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                                           DeleteCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(125, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n");
#nullable restore
#line 83 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(128, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 92 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
       
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