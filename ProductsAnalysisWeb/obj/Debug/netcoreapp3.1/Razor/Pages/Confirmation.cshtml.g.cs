#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a569936f1d662437c9f573ae4bd1f0f2a055113e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductsAnalysisWeb.Pages_Confirmation), @"mvc.1.0.razor-page", @"/Pages/Confirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a569936f1d662437c9f573ae4bd1f0f2a055113e", @"/Pages/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e734df0a4543b0e3dc1f1c88aef49921474b4cc2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Confirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container contact-container\">\n    <h1 class=\"mt-4 mb-3\">\n        Thank you!\n        <small>It is great to hear from you!</small>\n    </h1>\n    <br />\n");
#nullable restore
#line 11 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Confirmation.cshtml"
     if (!string.IsNullOrEmpty(Model.Message))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 id=\"confirmationMessage\">");
#nullable restore
#line 13 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Confirmation.cshtml"
                                Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 14 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Confirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <p>Contact us if you have any other questions: 093-21-70-945</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAnalysisWeb.Pages.ConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsAnalysisWeb.Pages.ConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsAnalysisWeb.Pages.ConfirmationModel>)PageContext?.ViewData;
        public ProductsAnalysisWeb.Pages.ConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
