#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5552ca2419ce496c0b12e3bf35622163b0df04f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductsAnalysisWeb.Pages_MobileWidget), @"mvc.1.0.view", @"/Pages/MobileWidget.cshtml")]
namespace ProductsAnalysisWeb
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5552ca2419ce496c0b12e3bf35622163b0df04f5", @"/Pages/MobileWidget.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e734df0a4543b0e3dc1f1c88aef49921474b4cc2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MobileWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rozetka.Mobile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("<div class=\"card\">\n    <div class=\"card-body\">\n        <h1>Most Expensive Phones</h1>\n        <h2>Total count: ");
#nullable restore
#line 9 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
                    Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 10 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
          
            int maximum = Model.ToList().Select(x => x.Price).Max();
            var query = Model.ToList().Where(x => x.Price == maximum);
            foreach (var item in query)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"description\">\n                    <h3>");
#nullable restore
#line 16 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <h4 style=\"color:darkslateblue\">Price: ");
#nullable restore
#line 17 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <h5>Reviews: ");
#nullable restore
#line 18 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
                            Write(item.NumberOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <div class=\"card-footer\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 659, "\"", 683, 1);
#nullable restore
#line 20 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
WriteAttributeValue("", 666, item.ProductLink, 666, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success w-100\" target=\"_blank\">Open in Rozetka</a>\n                    </div>\n                </div>\n                <hr/>\n");
#nullable restore
#line 24 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\MobileWidget.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rozetka.Mobile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
