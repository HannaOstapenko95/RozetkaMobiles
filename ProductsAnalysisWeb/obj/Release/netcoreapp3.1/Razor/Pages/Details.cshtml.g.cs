#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96138e2bed9bdf5089da7dddfc7a3927c8d9354a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96138e2bed9bdf5089da7dddfc7a3927c8d9354a", @"/Pages/Details.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Mobile</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile.Popularity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile.Popularity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile.NumberOfReviews));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile.NumberOfReviews));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile.ProductLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile.ProductLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1342, "\"", 1373, 1);
#nullable restore
#line 47 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Details.cshtml"
WriteAttributeValue("", 1357, Model.Mobile.ID, 1357, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAnalysisWeb.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsAnalysisWeb.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsAnalysisWeb.DetailsModel>)PageContext?.ViewData;
        public ProductsAnalysisWeb.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591