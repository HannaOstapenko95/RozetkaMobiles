#pragma checksum "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe13539f01703f68ce7695068e619136aabf674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
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
#nullable restore
#line 2 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\_ViewImports.cshtml"
using Rozetka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\_ViewImports.cshtml"
using ProductsAnalysisWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe13539f01703f68ce7695068e619136aabf674", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e616e49623984619df133033efd658378bdbec6", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mobile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/wiredbrain.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abe13539f01703f68ce7695068e619136aabf6744700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abe13539f01703f68ce7695068e619136aabf6745814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br /><br />\r\n    <h1 style=\"text-align:center; padding-bottom:5px\">E-Shop \'Rozetka\'</h1>\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 14 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
         foreach (var item in Model.ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <img src=""https://www.powerplanetonline.com/cdnassets/cubot_x19_4gb64gb_01_m.jpg"" alt=""Error"">
                    <div class=""card-body"">
                        <h3 class=""card-title"">
                            <a class=""color-main"">");
#nullable restore
#line 21 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <h4 class=\"card-text\">Price: ");
#nullable restore
#line 23 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" UAH</h4>\r\n                        <h5 class=\"card-text\">Reviews: ");
#nullable restore
#line 24 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                                                  Write(item.NumberOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5 class=\"card-text\">Popularity rate: ");
#nullable restore
#line 25 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                                                          Write(item.Popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1476, "\"", 1500, 1);
#nullable restore
#line 28 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
WriteAttributeValue("", 1483, item.ProductLink, 1483, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success w-100\" target=\"_blank\">Open in Rozetka</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "D:\C\Rozetka\RozetkaMobiles\ProductsAnalysisWeb\Views\App\Shop.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mobile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
