#pragma checksum "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b221450fbd31f3636005bba0a3f0047c90d383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b221450fbd31f3636005bba0a3f0047c90d383", @"/Views/Shared/_navbar.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"navbar bg-primary navbar-dark navbar-expand-sm\">\r\n        <div class=\"container-fluid\">\r\n            <a href=\"/\" class=\"navbar-brand\">MAĞAZA</a>\r\n            <ul class=\"navbar-nav mr-auto\">\r\n");
#nullable restore
#line 6 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                   if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/products"" class=""nav-link"">Ürünler</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/cart"" class=""nav-link"">Sepet</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/orders"" class=""nav-link"">Siparişler</a>
                </li>
");
#nullable restore
#line 17 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                if(User.IsInRole("admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/admin/categories"" class=""nav-link"">Admin Kategori Paneli</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/admin/products"" class=""nav-link"">Admin Ürün Paneli</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/admin/role/list"" class=""nav-link"">Admin Rol Paneli</a>
                </li> 
                <li class=""nav-item"">
                    <a href=""/admin/user/list"" class=""nav-link"">Admin Kullanıcılar Paneli</a>
                </li> 
");
#nullable restore
#line 31 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n           \r\n            <ul class=\"navbar-nav ml-auto\">\r\n\r\n");
#nullable restore
#line 37 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                 if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                    <a href=\"/account/manage\" class=\"nav-link\">");
#nullable restore
#line 40 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                                                          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n                <li class=\"nav-item\">\r\n                    <a href=\"/account/logout\" class=\"nav-link\">Çıkış Yap</a>\r\n                </li>\r\n");
#nullable restore
#line 45 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""/account/login"" class=""nav-link"">Giriş Yap</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/account/register"" class=""nav-link"">Kayıt Ol</a>
                </li>
");
#nullable restore
#line 54 "C:\Program Files\E_commerce\E_commerce.webui\Views\Shared\_navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n            \r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
