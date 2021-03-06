#pragma checksum "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84bccac8ea38d53b3de709a61a1ac02b7ed2bc61"
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
#nullable restore
#line 10 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
         if (products == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(2, "<p><em>Loading....</em></p>");
#nullable restore
#line 13 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container border p-3");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "<div class=\"col-5\"><h1 class=\"text-info\">Product List</h1></div>\r\n                    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-3");
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "class", "btn btn-info form-control");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                            AddNewProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(13, "Add New Product");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row pt-4");
                __builder2.OpenElement(17, "table");
                __builder2.AddAttribute(18, "class", "table table-striped");
                __builder2.AddMarkupContent(19, @"<thead><tr><th>Product Name</th>
                                <th>Price</th>
                                <th>Shade Color</th>
                                <th>Category</th>
                                <th>Product Size</th>
                                <th></th></tr></thead>
                        ");
                __builder2.OpenElement(20, "tbody");
#nullable restore
#line 39 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                             foreach (var obj in products)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "tr");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 42 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                                    ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 43 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                                    ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 44 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.ShadeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                                    ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 45 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.Category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 46 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                         obj.ProductSize.Size

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                                    ");
                __builder2.OpenElement(37, "td");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "class", "btn btn-primary");
                __builder2.AddAttribute(40, "style", "width:150px");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                      (()=>EditProduct(obj))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(42, "\r\n                                            Edit\r\n                                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 53 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 58 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(43, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(44, "<p>You are not signed in.</p>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 64 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal");
            __builder.AddAttribute(47, "tabindex", "-1");
            __builder.AddAttribute(48, "style", "display:block");
            __builder.AddAttribute(49, "role", "dialog");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(50);
            __builder.AddAttribute(51, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 67 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                          objProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 67 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                      ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "modal-dialog");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "modal-content");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "modal-header");
                __builder2.OpenElement(60, "h3");
                __builder2.AddAttribute(61, "class", "text-info");
                __builder2.AddContent(62, 
#nullable restore
#line 71 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                objProduct.Id != 0 ? "Update" : "Create" 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(63, " Product");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "type", "button");
                __builder2.AddAttribute(67, "class", "close");
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                      ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(69, "<span aria-hidden=\"true\">X</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "modal-body");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(73);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "row");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-9");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row py-2");
                __builder2.AddMarkupContent(81, "<div class=\"col-4\">\r\n                                        Category Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-8");
                __builder2.OpenElement(84, "select");
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 85 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                           CategorySelectionChanged

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "class", "form-control");
#nullable restore
#line 86 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                             foreach (var categoryInd in categories)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(87, "option");
                __builder2.AddAttribute(88, "value", 
#nullable restore
#line 88 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                categoryInd.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(89, "selected", 
#nullable restore
#line 88 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                            categoryInd.Id==objProduct.CategoryId? true : false

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(90, 
#nullable restore
#line 88 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                                                                   categoryInd.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 89 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "row py-2");
                __builder2.AddMarkupContent(94, "<div class=\"col-4\">\r\n                                        Product Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "class", "form-control");
                __builder2.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 98 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                     objProduct.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objProduct.Name = __value, objProduct.Name))));
                __builder2.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => objProduct.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\r\n                                        ");
                __Blazor.BlazingShop.Pages.ProductPage.TypeInference.CreateValidationMessage_0(__builder2, 103, 104, 
#nullable restore
#line 99 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                  ()=>objProduct.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                                ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "row py-2");
                __builder2.AddMarkupContent(108, "<div class=\"col-4\">\r\n                                        Price\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "col-8");
                __builder2.OpenElement(111, "input");
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "type", "text");
                __builder2.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 107 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                       objProduct.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objProduct.Price = __value, objProduct.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                                        ");
                __Blazor.BlazingShop.Pages.ProductPage.TypeInference.CreateValidationMessage_1(__builder2, 117, 118, 
#nullable restore
#line 108 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                  ()=>objProduct.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "row py-2");
                __builder2.AddMarkupContent(122, "<div class=\"col-4\">\r\n                                        Shade Color\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "col-8");
                __builder2.OpenElement(125, "input");
                __builder2.AddAttribute(126, "class", "form-control");
                __builder2.AddAttribute(127, "type", "text");
                __builder2.AddAttribute(128, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 116 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                       objProduct.ShadeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objProduct.ShadeColor = __value, objProduct.ShadeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                                        ");
                __Blazor.BlazingShop.Pages.ProductPage.TypeInference.CreateValidationMessage_2(__builder2, 131, 132, 
#nullable restore
#line 117 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                  ()=>objProduct.ShadeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "row py-2");
                __builder2.AddMarkupContent(136, "<div class=\"col-4\">\r\n                                        Product Size\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-8");
                __builder2.OpenElement(139, "select");
                __builder2.AddAttribute(140, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 125 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                           ProductSizeSelectionChanged

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(141, "class", "form-control");
#nullable restore
#line 126 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                             foreach (var productSizeInd in productsizes)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(142, "option");
                __builder2.AddAttribute(143, "value", 
#nullable restore
#line 128 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                productSizeInd.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(144, "selected", 
#nullable restore
#line 128 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                               productSizeInd.Id==objProduct.ProductSizeId? true : false

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(145, 
#nullable restore
#line 128 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                                                                            productSizeInd.Size

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 129 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                                ");
                __builder2.OpenElement(147, "div");
                __builder2.AddAttribute(148, "class", "row py-2");
                __builder2.AddMarkupContent(149, "<div class=\"col-4\">\r\n                                        Image\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-8");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(152);
                __builder2.AddAttribute(153, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 138 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                             HandleSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                                ");
                __builder2.OpenElement(155, "div");
                __builder2.AddAttribute(156, "class", "row py-2");
                __builder2.AddMarkupContent(157, "<div class=\"col-4 offset-4\"><button class=\"btn btn-outline-primary\" type=\"submit\">Submit</button></div>");
#nullable restore
#line 145 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                     if (objProduct.Id > 0)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "col-4");
                __builder2.OpenElement(160, "button");
                __builder2.AddAttribute(161, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(162, "type", "submit");
                __builder2.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 148 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                                                                                           DeleteProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(164, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 150 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n                            ");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "col-3");
                __builder2.OpenElement(168, "img");
                __builder2.AddAttribute(169, "src", 
#nullable restore
#line 154 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
                                           convertImageToDisplay(objProduct.Image)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(170, "width", "100%");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 162 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "G:\ASP.NET\Practice\BlazingShop-ASP.NET-Core-with-blazor\BlazingShop\BlazingShop\Pages\ProductPage.razor"
       
    List<Category> categories;
    List<ProductSize> productsizes;
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
        productsizes = Service.GetProductSizeList();
        objProduct.ProductSizeId = productsizes.ToList()[0].Id;
        objProduct.Id = 0;
        ShowPopup = true;
    }

    void EditProduct(Product product)
    {
        objProduct = product;
        categories = Service.GetCategoryList();
        productsizes = Service.GetProductSizeList();
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
    
    void ProductSizeSelectionChanged(ChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out int id))
        {
            objProduct.ProductSizeId = id;
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
