#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2aa7b33f7654f67bd8c05586f98f0c36d0aafe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_About), @"mvc.1.0.view", @"/Views/App/About.cshtml")]
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
#line 2 "D:\C\Rozetka\ProductsAnalysisWeb\Views\_ViewImports.cshtml"
using Rozetka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C\Rozetka\ProductsAnalysisWeb\Views\_ViewImports.cshtml"
using ProductsAnalysisWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C\Rozetka\ProductsAnalysisWeb\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2aa7b33f7654f67bd8c05586f98f0c36d0aafe9", @"/Views/App/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e616e49623984619df133033efd658378bdbec6", @"/Views/_ViewImports.cshtml")]
    public class Views_App_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mobile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<div class=""container"">

    <h2>About US</h2>
    <p> More to follow</p>
    <button onclick=""search()"">
        Calculate
    </button>

    <div");
            BeginWriteAttribute("ng-app", " ng-app=\"", 564, "\"", 573, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <p id=""first"">1st Priority: <input type=""text"" ng-model=""firstPrior""></p>
        <p id=""second"">2nd Priority: <input type=""text"" ng-model=""secondPrior""></p>
        <p>3d Priority: <input type=""text"" ng-model=""thirdPrior""></p>
        <p>You selected {{ firstPrior }} as 1st Priority.  </p> <p id=""wgf1"">Weighting factor = </p>
        <p>You selected {{ secondPrior }} as 2nd Priority.</p><p id=""wgf2"">Weighting factor =</p>
        <p>You selected {{ thirdPrior }} as 3d Priority</p>
    </div>
    <script>
        function search() {

            if (document.getElementById(""first"").innerHTML == ""Price"") {
");
#nullable restore
#line 27 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                   int totalVag = 2;
                    string first = "Price";
                    int vagom = 2;
                    double vag1 = vagom / totalVag;

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                document.getElementById(\"wgf1\").innerHTML = \"");
#nullable restore
#line 33 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                                                        Write(vag1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            }\r\n            else if (document.getElementById(\"second\").innerHTML == \"Popularity\") {\r\n");
#nullable restore
#line 36 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
     string second = "Popularity";
                     vagom = 1;
      double vag2 = vagom / totalVag;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                document.getElementById(\"wgf2\").innerHTML = \"");
#nullable restore
#line 40 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                                                        Write(vag2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
            }
            else {
                 document.getElementById(""wgf2"").innerHTML = ""eeeeeee"";
            }
    </script>
    <table>
        <thead>
            <tr>
                <th>№:</th>
                <th>Name:</th>
                <th>Price:</th>
                <th>Popularity:</th>
                <th>Reviews:</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 57 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
              int i = 1;
                foreach (var item in Model.ToList())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 61 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 62 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 63 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 64 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                       Write(item.Popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 65 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                       Write(item.NumberOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\About.cshtml"
                    i++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
