#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b703dede4bec1e5cee3aa3d0c98a6fe27b38057"
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
#line 2 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
using BlazingShop.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
using BlazingShop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product")]
    public partial class ProductPage : OwningComponentBase<ProductServices>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n");
#nullable restore
#line 10 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
         if (products == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, "            ");
                __builder2.AddMarkupContent(4, "<p><em>Loading....</em></p>\r\n");
#nullable restore
#line 13 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
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
                __builder2.AddMarkupContent(12, "<div class=\"col-5\">\r\n                        <h1 class=\"text-info\">Product List</h1>\r\n                    </div>\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-3");
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "class", "btn btn-info form-control");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                            AddNewProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Add New Product");
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
                __builder2.AddMarkupContent(29, @"<thead>
                            <tr>
                                <th>Product Name</th>
                                <th>Price</th>
                                <th>Shade Color</th>
                                <th>Category</th>
                                <th></th>
                            </tr>
                        </thead>
                        ");
                __builder2.OpenElement(30, "tbody");
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 38 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                             foreach (var obj in products)
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
#line 41 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 42 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                    ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 43 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.ShadeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                    ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 44 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.Category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                    ");
                __builder2.OpenElement(47, "td");
                __builder2.AddMarkupContent(48, "\r\n                                        ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "style", "width:150px");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                      (()=>EditProduct(obj))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(53, "\r\n                                            Edit\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n");
#nullable restore
#line 51 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(57, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n");
#nullable restore
#line 56 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(62, "    ");
            }
            ));
            __builder.AddAttribute(63, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.AddMarkupContent(65, "<p>You are not signed in.</p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 62 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "modal");
            __builder.AddAttribute(70, "tabindex", "-1");
            __builder.AddAttribute(71, "style", "display:block");
            __builder.AddAttribute(72, "role", "dialog");
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(74);
            __builder.AddAttribute(75, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 65 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                          objProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 65 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                      ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "modal-dialog");
                __builder2.AddMarkupContent(81, "\r\n                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "modal-content");
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "modal-header");
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenElement(88, "h3");
                __builder2.AddAttribute(89, "class", "text-info");
                __builder2.AddContent(90, 
#nullable restore
#line 69 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                objProduct.Id != 0 ? "Update" : "Create" 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(91, " Product");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.OpenElement(93, "button");
                __builder2.AddAttribute(94, "type", "button");
                __builder2.AddAttribute(95, "class", "close");
                __builder2.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                      ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(97, "\r\n                            ");
                __builder2.AddMarkupContent(98, "<span aria-hidden=\"true\">X</span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                    ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "modal-body");
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(104);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "row");
                __builder2.AddMarkupContent(108, "\r\n                            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "col-9");
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "row py-2");
                __builder2.AddMarkupContent(114, "\r\n                                    ");
                __builder2.AddMarkupContent(115, "<div class=\"col-4\">\r\n                                        Category Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col-8");
                __builder2.AddMarkupContent(118, "\r\n                                        ");
                __builder2.OpenElement(119, "select");
                __builder2.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 83 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                           CategorySelectionChanged

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "class", "form-control");
                __builder2.AddMarkupContent(122, "\r\n");
#nullable restore
#line 84 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                             foreach (var categoryInd in categories)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(123, "                                                ");
                __builder2.OpenElement(124, "option");
                __builder2.AddAttribute(125, "value", 
#nullable restore
#line 86 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                categoryInd.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(126, "selected", 
#nullable restore
#line 86 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                            categoryInd.Id==objProduct.CategoryId? true : false

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(127, 
#nullable restore
#line 86 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                                                                   categoryInd.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n");
#nullable restore
#line 87 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(129, "                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "row py-2");
                __builder2.AddMarkupContent(135, "\r\n                                    ");
                __builder2.AddMarkupContent(136, "<div class=\"col-4\">\r\n                                        Product Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-8");
                __builder2.AddMarkupContent(139, "\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(140);
                __builder2.AddAttribute(141, "class", "form-control");
                __builder2.AddAttribute(142, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                     objProduct.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(143, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objProduct.Name = __value, objProduct.Name))));
                __builder2.AddAttribute(144, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => objProduct.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(145, "\r\n                                        ");
                __Blazor.BlazingShop.Pages.ProductPage.TypeInference.CreateValidationMessage_0(__builder2, 146, 147, 
#nullable restore
#line 97 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                  ()=>objProduct.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(148, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n                                ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "row py-2");
                __builder2.AddMarkupContent(153, "\r\n                                    ");
                __builder2.AddMarkupContent(154, "<div class=\"col-4\">\r\n                                        Price\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(155, "div");
                __builder2.AddAttribute(156, "class", "col-8");
                __builder2.AddMarkupContent(157, "\r\n                                        ");
                __builder2.OpenElement(158, "input");
                __builder2.AddAttribute(159, "class", "form-control");
                __builder2.AddAttribute(160, "type", "text");
                __builder2.AddAttribute(161, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                       objProduct.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(162, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objProduct.Price = __value, objProduct.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n                                        ");
                __Blazor.BlazingShop.Pages.ProductPage.TypeInference.CreateValidationMessage_1(__builder2, 164, 165, 
#nullable restore
#line 106 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                  ()=>objProduct.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(166, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n                                ");
                __builder2.OpenElement(169, "div");
                __builder2.AddAttribute(170, "class", "row py-2");
                __builder2.AddMarkupContent(171, "\r\n                                    ");
                __builder2.AddMarkupContent(172, "<div class=\"col-4\">\r\n                                        Shade Color\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(173, "div");
                __builder2.AddAttribute(174, "class", "col-8");
                __builder2.AddMarkupContent(175, "\r\n                                        ");
                __builder2.OpenElement(176, "input");
                __builder2.AddAttribute(177, "class", "form-control");
                __builder2.AddAttribute(178, "type", "text");
                __builder2.AddAttribute(179, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 114 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                       objProduct.ShadeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(180, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objProduct.ShadeColor = __value, objProduct.ShadeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n                                        ");
                __Blazor.BlazingShop.Pages.ProductPage.TypeInference.CreateValidationMessage_2(__builder2, 182, 183, 
#nullable restore
#line 115 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                  ()=>objProduct.ShadeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(184, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n                                ");
                __builder2.OpenElement(187, "div");
                __builder2.AddAttribute(188, "class", "row py-2");
                __builder2.AddMarkupContent(189, "\r\n                                    ");
                __builder2.AddMarkupContent(190, "<div class=\"col-4\">\r\n                                        Image\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(191, "div");
                __builder2.AddAttribute(192, "class", "col-8");
                __builder2.AddMarkupContent(193, "\r\n                                        ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(194);
                __builder2.AddAttribute(195, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 123 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                             HandleSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(196, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(198, "\r\n                                ");
                __builder2.OpenElement(199, "div");
                __builder2.AddAttribute(200, "class", "row py-2");
                __builder2.AddMarkupContent(201, "\r\n                                    ");
                __builder2.AddMarkupContent(202, "<div class=\"offset-4 col\">\r\n                                        <button class=\"btn btn-outline-primary\" type=\"submit\">Submit</button>\r\n                                    </div>\r\n");
#nullable restore
#line 130 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                     if (objProduct.Id > 0)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(203, "                                        ");
                __builder2.OpenElement(204, "div");
                __builder2.AddAttribute(205, "class", "col");
                __builder2.AddMarkupContent(206, "\r\n                                            ");
                __builder2.OpenElement(207, "button");
                __builder2.AddAttribute(208, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(209, "type", "submit");
                __builder2.AddAttribute(210, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                           DeleteProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(211, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(212, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(213, "\r\n");
#nullable restore
#line 135 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(214, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(215, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(216, "\r\n                            ");
                __builder2.OpenElement(217, "div");
                __builder2.AddAttribute(218, "class", "col-3");
                __builder2.AddMarkupContent(219, "\r\n                                ");
                __builder2.OpenElement(220, "img");
                __builder2.AddAttribute(221, "src", 
#nullable restore
#line 139 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                           convertImageToDisplay(objProduct.Image)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(222, "width", "100%");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(223, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(224, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(225, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(226, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(227, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(228, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(229, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(230, "\r\n");
#nullable restore
#line 147 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
       
    List<Category> categories;
    List<Product> products;
    Product objProduct = new Product();
    bool ShowPopup = false;
    public byte[] ImageUploaded { get; set; }

    protected override void OnInitialized()
    {
        products = Service.GetProducts();
    }

    void AddNewProduct()
    {
        objProduct = new Product();
        categories = Service.GetCategoryList();
        objProduct.CategoryId = categories.ToList()[0].Id;
        objProduct.Id = 0;
        ShowPopup = true;
    }

    void EditProduct(Product product)
    {
        objProduct = product;
        categories = Service.GetCategoryList();
        ShowPopup = true;
    }

    void DeleteProduct()
    {
        ShowPopup = false;
        var result = Service.DeleteProduct(objProduct);
        products.Clear();
        products = Service.GetProducts();
    }

    void ClosePopup()
    {
        ShowPopup = false;
    }

    void ValidSubmit()
    {
        var result = false;
        ShowPopup = false;
        if (ImageUploaded != null)
        {
            objProduct.Image = ImageUploaded;
        }
        if (objProduct.Id > 0)
        {
            result = Service.UpdateProduct(objProduct);
        }
        else
        {
            result = Service.CreateProduct(objProduct);
        }

        products = Service.GetProducts();
    }

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            ImageUploaded = ms.ToArray();
        }
    }

    string convertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }
        return "";
    }

    void CategorySelectionChanged(ChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out int id))
        {
            objProduct.CategoryId = id;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazingShop.Pages.ProductPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
