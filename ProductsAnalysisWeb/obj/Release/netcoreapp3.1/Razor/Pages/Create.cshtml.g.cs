#pragma checksum "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83dcb2e89ce101972cd2404e5303c0a1f7ea434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Create), @"mvc.1.0.razor-page", @"/Pages/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83dcb2e89ce101972cd2404e5303c0a1f7ea434", @"/Pages/Create.cshtml")]
    public class Pages_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Mobile</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Mobile.Name"" class=""control-label""></label>
                <input asp-for=""Mobile.Name"" class=""form-control"" />
                <span asp-validation-for=""Mobile.Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Mobile.Price"" class=""control-label""></label>
                <input asp-for=""Mobile.Price"" class=""form-control"" />
                <span asp-validation-for=""Mobile.Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Mobile.Popularity"" class=""control-label""></label>
                <input asp-for=""Mobile.Popularity"" class=""form-control"" />
                <span asp-validation-for=""M");
            WriteLiteral(@"obile.Popularity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Mobile.NumberOfReviews"" class=""control-label""></label>
                <input asp-for=""Mobile.NumberOfReviews"" class=""form-control"" />
                <span asp-validation-for=""Mobile.NumberOfReviews"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Mobile.ProductLink"" class=""control-label""></label>
                <input asp-for=""Mobile.ProductLink"" class=""form-control"" />
                <span asp-validation-for=""Mobile.ProductLink"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\C\Rozetka\ProductsAnalysisWeb\Pages\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAnalysisWeb.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsAnalysisWeb.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsAnalysisWeb.CreateModel>)PageContext?.ViewData;
        public ProductsAnalysisWeb.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
