#pragma checksum "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb5d982276fb3e46a211739813177d4dd34fd9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_list), @"mvc.1.0.view", @"/Views/Product/list.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb5d982276fb3e46a211739813177d4dd34fd9a", @"/Views/Product/list.cshtml")]
    public class Views_Product_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
  
var popularclass =Model.ürün.Count>2?"popular":"";
var products1=Model.ürün;

#line default
#line hidden
#nullable disable
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
#nullable restore
#line 9 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
 if(Model.ürün.Count==0)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
                                      
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
     foreach (var product in products1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 19 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
   Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 23 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Product\list.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591