#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6d2f8745eb9cb49fd5b17d2295d5cd39f10bb4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6d2f8745eb9cb49fd5b17d2295d5cd39f10bb4", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e616e49623984619df133033efd658378bdbec6", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mobile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        $(""#Details"").click(function () {
            $("".row"").slideToogle();
        });
    });
</script>
<div class=""container"">
    <button type=""button"" class=""btn btn-success btn-block"" id=""Details"" data-toggle=""collapse"" data-target=""#demo"">Calculation Details</button>
    <div class=""collapse"" id=""demo"">
        <table class=""table table-bordered"">
            <tr>

                <td>
                    Number of mobile phones for analysis:
                    ");
#nullable restore
#line 19 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
               Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    Maximun price:\r\n");
#nullable restore
#line 24 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       int max = 0;
                        for (int j = 1; j < Model.ToList().Count; j++)
                        {
                            if (Model.ToList()[j].Price > Model.ToList()[j - 1].Price)
                                max = Model.ToList()[j].Price;
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                Write(max);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    Minimun price:\r\n");
#nullable restore
#line 35 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       int min = 0;
                        for (int j = 1; j < Model.ToList().Count; j++)
                        {
                            if (Model.ToList()[j].Price < Model.ToList()[j - 1].Price)
                                min = Model.ToList()[j].Price;
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                Write(min);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    Average price:\r\n");
#nullable restore
#line 46 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       int avg = 0;
                        int sum = 0;
                        for (int j = 1; j < Model.ToList().Count; j++)
                        {
                            sum += Model.ToList()[j].Price;
                        }
                        avg = sum / Model.ToList().Count;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                Write(avg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>

                <script>
                    $(document).ready(function () {
                        $('[data-toggle=""tooltip""]').tooltip();
                    });
                </script>
                <div class=""col"">
                    <td data-toggle=""tooltip"" title=""The value separating the higher half from the lower half of prices on mobiles"">
                        Median price:
");
#nullable restore
#line 64 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                           if (Model.ToList().Count == 0)
                                throw new ArgumentException("Маccив не может быть пустым");
                            int[] arr = new int[Model.ToList().Count];
                            for (int j = 0; j < Model.ToList().Count; j++)
                            {
                                arr[j] = Model.ToList()[j].Price;
                            }
                            int[] copyArr = (int[])arr.Clone();
                            Array.Sort(copyArr);
                            int median = copyArr[copyArr.Length / 2];
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                    Write(median);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                </div>
            </tr>
        </table>
    </div>
 
        <script>
            $(document).ready(function () {
                $(""#myInput"").on(""keyup"", function () {
                    var value = $(this).val().toLowerCase();
                    $(""tbody tr"").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>
        <input style=""width: 400px"" class=""form-control"" id=""myInput"" type=""text"" placeholder=""Search.."">


    <button type=""button"" class=""btn btn-primary btn-block"" data-toggle=""collapse"" data-target=""#tbl"">Show Table</button>
    <table id=""tbl"" class=""table table-hover collapse table-bordered"">
        <thead>
            <tr>
                <th>№:</th>
                <th>Name:</th>
                <th>Price:</th>
                <th>Popularity:</th>
                <th>Reviews:</th>
 ");
            WriteLiteral("           </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 106 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
              int i = 1;
                foreach (var item in Model.ToList())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 110 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 4211, "\"", 4235, 1);
#nullable restore
#line 111 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
WriteAttributeValue("", 4218, item.ProductLink, 4218, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"> ");
#nullable restore
#line 111 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                        <td>");
#nullable restore
#line 112 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 113 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       Write(item.Popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 114 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                       Write(item.NumberOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 116 "D:\C\Rozetka\ProductsAnalysisWeb\Views\App\Shop.cshtml"
                    i++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n</div>\r\n\r\n");
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
