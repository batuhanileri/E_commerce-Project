#pragma checksum "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf821eb6e5a7851948027142e54448eb6119d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleList), @"mvc.1.0.view", @"/Views/Admin/RoleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf821eb6e5a7851948027142e54448eb6119d8f", @"/Views/Admin/RoleList.cshtml")]
    public class Views_Admin_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>Admin Rol Listesi</h1>
        <hr>
            <a class=""btn btn-primary btn-sm"" href=""/admin/role/create"">Rol Ekle</a>
        
        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td style=""width: 300px;"">Id</td>
                    <td >Rol Adı</td>
                    <td style=""width:200px;""></td>                 
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
                 if(Model.Count()>0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 23 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                       \r\n                                <td>");
#nullable restore
#line 24 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 984, 2);
            WriteAttributeValue("", 964, "/admin/role/", 964, 12, true);
#nullable restore
#line 26 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
WriteAttributeValue("", 976, item.Id, 976, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-sm mr-2"">Rol Güncelle</a>                                
                                   <form action=""/admin/role/delete"" method=""POST"" style=""display: inline;"">
                                     <input type=""hidden"" name=""RoleId""");
            BeginWriteAttribute("value", " value=\"", 1253, "\"", 1269, 1);
#nullable restore
#line 28 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
WriteAttributeValue("", 1261, item.Id, 1261, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                     <button type=""submit"" class=""btn btn-danger btn-sm"">Rol Sil</button>                                
                                   </form>
                                </td>
                        </tr>
");
#nullable restore
#line 33 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Roles</h3>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Program Files\E_commerce\E_commerce.webui\Views\Admin\RoleList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
