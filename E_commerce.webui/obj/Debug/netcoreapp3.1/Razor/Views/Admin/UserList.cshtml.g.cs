#pragma checksum "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97466823940855ecb10c7c7a154e171346260b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97466823940855ecb10c7c7a154e171346260b47", @"/Views/Admin/UserList.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E_commerce.webui.Identity.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>Admin Kullanıcı Listesi</h1>
        <hr>
            <a class=""btn btn-primary btn-sm"" href=""/admin/user/create"">Kullanıcı Ekle</a>
        
        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td>Ad</td>
                    <td>Soyad</td>
                    <td>Kullanıcı Adı</td>
                    <td>Email</td>             
                    <td style=""width: 300px;""></td>             
                </tr>
            </thead>
            <tbody> 
");
#nullable restore
#line 20 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                 if(Model.Count()>0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 25 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                       \r\n                                <td>");
#nullable restore
#line 26 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1145, "\"", 1172, 2);
            WriteAttributeValue("", 1152, "/admin/user/", 1152, 12, true);
#nullable restore
#line 30 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1164, item.Id, 1164, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm mr-2"">Kullanıcı Güncelle</a>                                
                                   <form action=""/admin/role/delete"" method=""POST"" style=""display: inline;"">
                                     <input type=""hidden"" name=""UserId""");
            BeginWriteAttribute("value", " value=\"", 1447, "\"", 1463, 1);
#nullable restore
#line 32 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1455, item.Id, 1455, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                     <button type=""submit"" class=""btn btn-danger btn-sm"">Kullanıcı Sil</button>                                
                                   </form>
                                </td>
                        </tr>
");
#nullable restore
#line 37 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>Kullanıcı Yok</h3>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\UserList.cshtml"
                }       

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E_commerce.webui.Identity.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591