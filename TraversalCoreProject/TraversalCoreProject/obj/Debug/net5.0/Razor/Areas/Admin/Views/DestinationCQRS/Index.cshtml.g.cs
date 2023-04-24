#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9b9803ab3e6493b3ef50a7395515e8f0f70e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationCQRS_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
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
#line 3 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9b9803ab3e6493b3ef50a7395515e8f0f70e3b", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b332a3e47d20c3ac9fd0d17c58ff334be48b9260", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DestinationCQRS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllDestinationQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>CQRS Tur Rotası Verileri</h2>

<br />
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Gün-Gece</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.daynight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
           Write(item.capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 754, 2);
            WriteAttributeValue("", 705, "/Admin/DestinationCQRS/DeleteDestination/", 705, 41, true);
#nullable restore
#line 31 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 746, item.id, 746, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 819, "\"", 872, 2);
            WriteAttributeValue("", 826, "/Admin/DestinationCQRS/GetDestination/", 826, 38, true);
#nullable restore
#line 32 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 864, item.id, 864, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/DestinationCQRS/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası Girişi</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllDestinationQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591