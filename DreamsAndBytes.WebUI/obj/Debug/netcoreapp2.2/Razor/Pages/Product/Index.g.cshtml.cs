#pragma checksum "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b95eb35fdd6333228bc5d98b5cb0194b6d22254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Product_Index), @"mvc.1.0.view", @"/Pages/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Product/Index.cshtml", typeof(AspNetCore.Pages_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b95eb35fdd6333228bc5d98b5cb0194b6d22254", @"/Pages/Product/Index.cshtml")]
    public class Pages_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DreamsAndBytes.WebUI.Models.ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 2 "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml"
   
     Layout = "_Layout";
 

#line default
#line hidden
            BeginContext(92, 176, true);
            WriteLiteral("<div>\r\n    Hakan\r\n    <hr/>\r\n    <table>\r\n        <tr>\r\n            <th>Product Name</th>\r\n            <th>Unit Price</th>\r\n            <th>Units In Stock</th>\r\n        </tr>\r\n");
            EndContext();
#line 14 "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(329, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(368, 19, false);
#line 17 "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(387, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(415, 17, false);
#line 18 "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml"
               Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(432, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(460, 19, false);
#line 19 "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml"
               Write(product.UnitInStock);

#line default
#line hidden
            EndContext();
            BeginContext(479, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "C:\Users\hk\Desktop\DreamsAndBytes\DreamsAndBytes.WebUI\Pages\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(516, 21, true);
            WriteLiteral("    </table>\r\n</div> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DreamsAndBytes.WebUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
