#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82bbd83c3ddc4d6035edaa083c34c8b6b887e147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82bbd83c3ddc4d6035edaa083c34c8b6b887e147", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b332a3e47d20c3ac9fd0d17c58ff334be48b9260", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcı Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad Soyad</th>
        <th>Kullanıcı Adı</th>
        <th>Mail</th>
        <th>Sil</th>
        <th>Düzenle</th>
        <th>Yorumlar</th>
        <th>Tur Geçmişi</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
              sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 27 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
           Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 718, "\"", 756, 2);
            WriteAttributeValue("", 725, "/Admin/User/DeleteUser/", 725, 23, true);
#nullable restore
#line 31 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 748, item.Id, 748, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-outline-info\">Yorumlar</a></td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 974, "\"", 1017, 2);
            WriteAttributeValue("", 981, "/Admin/User/ReservationUser/", 981, 28, true);
#nullable restore
#line 34 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1009, item.Id, 1009, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Tur Geçmişi</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Login/SignUp/\" class=\"btn btn-outline-warning\">Yeni Kullanıcı Kaydı</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
