#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc69c2dcc87385e469357217386dce50244572a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductsAnalysisWeb.Components.PopularMobiles.Pages_Components_PopularMobiles_Default), @"mvc.1.0.view", @"/Pages/Components/PopularMobiles/Default.cshtml")]
namespace ProductsAnalysisWeb.Components.PopularMobiles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\_ViewImports.cshtml"
using ProductsAnalysisWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\_ViewImports.cshtml"
using Rozetka;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc69c2dcc87385e469357217386dce50244572a2", @"/Pages/Components/PopularMobiles/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ca9c0a4699ec86e07719b48cc83ce3653507698", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_PopularMobiles_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rozetka.Mobile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h1>Most Popular Phones</h1>\r\n");
#nullable restore
#line 7 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"description\">\r\n        <h3>");
#nullable restore
#line 10 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h4 style=\"color:purple\">Popularity: ");
#nullable restore
#line 11 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
                                        Write(item.Popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h5>Price: ");
#nullable restore
#line 12 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6>Reviews: ");
#nullable restore
#line 13 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
                Write(item.NumberOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <div class=\"card-footer\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 439, "\"", 463, 1);
#nullable restore
#line 15 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
WriteAttributeValue("", 446, item.ProductLink, 446, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success w-100\" target=\"_blank\">Open in Rozetka</a>\r\n        </div>\r\n    </div>\r\n            <hr />   \r\n");
#nullable restore
#line 19 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Components\PopularMobiles\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rozetka.Mobile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
