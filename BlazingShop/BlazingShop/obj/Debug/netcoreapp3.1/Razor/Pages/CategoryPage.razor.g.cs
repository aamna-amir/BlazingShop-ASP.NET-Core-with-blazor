#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd22e328af4b1903a5d65a92ce62a09a4bccea3a"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 10 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
         if (categories == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, "            ");
                __builder2.AddMarkupContent(4, "<p><em>Loading or No category exists.</em></p>\r\n");
#nullable restore
#line 13 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container border p-3");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.AddMarkupContent(11, "\r\n                    ");
                __builder2.AddMarkupContent(12, "<div class=\"col-5\">\r\n                        <h1 class=\"text-info\">Category List</h1>\r\n                    </div>\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-3");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "class", "btn btn-info form-control");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                            AddNewCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Add New Category");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row pt-4");
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "table");
                __builder2.AddAttribute(27, "class", "table table-striped");
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.AddMarkupContent(29, "<thead>\r\n                            <tr>\r\n                                <th>Category Name</th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        ");
                __builder2.OpenElement(30, "tbody");
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 35 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                             foreach (var obj in categories)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(32, "                                ");
                __builder2.OpenElement(33, "tr");
                __builder2.AddMarkupContent(34, "\r\n                                    ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 38 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                         obj.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "td");
                __builder2.AddMarkupContent(39, "\r\n                                        ");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "class", "btn btn-primary");
                __builder2.AddAttribute(42, "style", "width:150px");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                                      (()=>EditCategory(obj))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(44, "\r\n                                            Edit\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 45 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 50 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 52 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
         if (ShowPopup)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "modal");
                __builder2.AddAttribute(57, "tabindex", "-1");
                __builder2.AddAttribute(58, "style", "display:block");
                __builder2.AddAttribute(59, "role", "dialog");
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(61);
                __builder2.AddAttribute(62, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 55 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                  objCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 55 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                               ValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n                    ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "modal-dialog");
                    __builder3.AddMarkupContent(68, "\r\n                        ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "modal-content");
                    __builder3.AddMarkupContent(71, "\r\n                            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "modal-header");
                    __builder3.AddMarkupContent(74, "\r\n                                ");
                    __builder3.OpenElement(75, "h3");
                    __builder3.AddAttribute(76, "class", "text-info");
                    __builder3.AddContent(77, 
#nullable restore
#line 59 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                        objCategory.Id != 0 ? "Update" : "Create" 

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(78, " Category");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\r\n                                ");
                    __builder3.OpenElement(80, "button");
                    __builder3.AddAttribute(81, "type", "button");
                    __builder3.AddAttribute(82, "class", "close");
                    __builder3.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                              ClosePopup

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(84, "\r\n                                    ");
                    __builder3.AddMarkupContent(85, "<span aria-hidden=\"true\">X</span>\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                            ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "modal-body");
                    __builder3.AddMarkupContent(90, "\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(91);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\r\n                                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(93);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\r\n                                ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "class", "row");
                    __builder3.AddMarkupContent(97, "\r\n                                    ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "col-9");
                    __builder3.AddMarkupContent(100, "\r\n                                        ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "class", "row py-2");
                    __builder3.AddMarkupContent(103, "\r\n                                            ");
                    __builder3.AddMarkupContent(104, "<div class=\"col-4\">\r\n                                                Category Name\r\n                                            </div>\r\n                                            ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-8");
                    __builder3.AddMarkupContent(107, "\r\n                                                ");
                    __builder3.OpenElement(108, "input");
                    __builder3.AddAttribute(109, "class", "form-control");
                    __builder3.AddAttribute(110, "type", "text");
                    __builder3.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                               objCategory.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objCategory.Name = __value, objCategory.Name));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\r\n                                        ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "row py-2");
                    __builder3.AddMarkupContent(118, "\r\n                                            ");
                    __builder3.AddMarkupContent(119, "<div class=\"offset-4 col\">\r\n                                                <button class=\"btn btn-outline-primary\" type=\"submit\">Submit</button>\r\n                                            </div>\r\n");
#nullable restore
#line 81 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                             if (objCategory.Id > 0)
                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(120, "                                                ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "col");
                    __builder3.AddMarkupContent(123, "\r\n                                                    ");
                    __builder3.OpenElement(124, "button");
                    __builder3.AddAttribute(125, "class", "btn btn-outline-danger");
                    __builder3.AddAttribute(126, "type", "submit");
                    __builder3.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                                                                                                   DeleteCategory

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(128, "Delete");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\r\n                                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(130, "\r\n");
#nullable restore
#line 86 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(131, "                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(133, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(135, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(136, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(137, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n");
#nullable restore
#line 95 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(140, "    ");
            }
            ));
            __builder.AddAttribute(141, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(142, "\r\n        ");
                __builder2.AddMarkupContent(143, "<p>You\'re not signed in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\CategoryPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    List<Category> categories;
    Category objCategory = new Category();

    bool ShowPopup = false;

    protected override void OnInitialized()
    {
        //var user = (await authenticationState).User;
        //var emailOdUser = user.Identity.Name;
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
