#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae94087410d3aa4d1c2c0765956cdac569e3726a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_City_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/City/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae94087410d3aa4d1c2c0765956cdac569e3726a", @"/Areas/Admin/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b332a3e47d20c3ac9fd0d17c58ff334be48b9260", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>

<h2>Şehir - Ülke İşlemleri</h2>

<button type=""button"" id=""btngetlist"" class=""btn btn-primary"">Şehir Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-warning"">Şehir Getir</button>
<button type=""button"" id=""btnaddcity"" class=""btn btn-success"">Şehir Ekle</button>
<button type=""button"" id=""btndeletecity"" class=""btn btn-danger"">Şehir Sil</button>
<button type=""button"" id=""btnupdatecity"" class=""btn btn-info"">Şehir Güncelle</button>
<br />
<br />

<div id=""citylist"">
    Buraya Şehir Listesi Gelecek
</div>
<br />
<br />

<div>
    <input type=""text"" id=""txtcity"" placeholder=""Şehir adını giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtdaynight"" placeholder=""Gün - gece sayısı"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtprice"" placeholder=""Fiyat"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtcapacity"" placeholder=""Kişi say");
            WriteLiteral(@"ısı"" class=""form-control"" />
</div>

<br />
<br />
<h4>Getirme İşlemi</h4>
<div>
    <input type=""text"" id=""txtid"" placeholder=""Şehir ID değerini giriniz"" class=""form-control"" />
</div>
<br />
<div id=""destinationlistbyid"">

</div>

<br />
<h4>Silme İşlemi</h4>
<div>
    <input type=""text"" id=""txtcityid"" placeholder=""Silmek istediğiniz ID değerini giriniz"" class=""form-control"" />
</div>

<br />
<h4>Güncelleme İşlemi</h4>
<div>
    <input type=""text"" id=""txtcityeditid"" placeholder="" ID değerini giriniz"" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtcityname"" placeholder=""Güncellenecek şehir giriniz "" class=""form-control"" />
    <br />
    <input type=""text"" id=""txtcitdaynightname"" placeholder=""Güncellenecek gün gece bilgisini giriniz"" class=""form-control"" />
</div>

<script>
    $(""#btngetlist"").click(function () {
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/C");
            WriteLiteral(@"ity/CityList/"",
            success: function (func) {
                let w = jQuery.parseJSON(func);
                console.log(w);
                let tablehtml = ""<table class=table table-bordered> <tr><th> Şehir Adı </th> <th> Gün-Gece </th> <th> Fiyat </th> </tr>"";
                $.each(w, (index, value) => {
                    tablehtml += `<tr><td>${value.City}</td> <td>${value.DayNight}</td> <td> ${value.Price} ₺ </td> </tr>`
                });
                tablehtml += ""</table>"";
                $(""#citylist"").html(tablehtml);
            }
        });
    })

    $(""#btnaddcity"").click(function () {
        let cityvalues = {
            City: $(""#txtcity"").val(),
            DayNight: $(""#txtdaynight"").val(),
            Price: $(""#txtprice"").val(),
            Capacity: $(""#txtcapacity"").val()
        };
        $.ajax({
            type: ""post"",
            url: ""/Admin/City/AddCityDestination/"",
            data: cityvalues,
            success: function (func) ");
            WriteLiteral(@"{
                let result = jQuery.parseJSON(func);
                alert(""Şehir - Rota Başarılı Bir Şekilde Eklendi"");
            }
        });
    });
    $(""#btngetbyid"").click(x => {
        let id = $(""#txtid"").val();
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/City/GetById/"",
            data: { DestinationID: id },
            success: function (fun2) {
                if (fun2.error) {
                    alert(fun2.error);
                    return;
                }
                let result = jQuery.parseJSON(fun2);
                console.log(result);
                let htmlstr = `<table class=table table-bordered><tr><th>Şehir Adı</th><th>Gün-Gece</th><th>Fiyatı</th></tr><tr><td>${result.City}</td><td>${result.DayNight}</td><td>${result.Capacity}</td></tr></table>`;
                $(""#destinationlistbyid"").html(htmlstr);
            }
        });
    });
    $(""#btnd");
            WriteLiteral(@"eletecity"").click(x => {
        let id = $(""#txtcityid"").val();
        $.ajax({
            url: ""/Admin/City/DeleteCity/"" + id,
            type: ""post"",
            contentType: ""application/json"",
            dataType: ""json"",
            success: function (fun3) {
                alert(""Şehir silindi"");
            },
            error: function (xhr, ajaxOptions, thrownError) {
                if (xhr.status == 404) {
                    alert(""Bu id'ye sahip bir şehir bulunamadı!"");
                }
                else {
                    alert(""Bir hata oluştu: "" + xhr.responseText);
                }
            }
        });
    });
    $(""#btnupdatecity"").click(function () {
        let values = {
            DestinationID: $(""#txtcityeditid"").val(),
            City: $(""#txtcityname"").val(),
            DayNight: $(""#txtcitdaynightname"").val()
        };
        $.ajax({
            type: ""post"",
            url: ""/Admin/City/UpdateCity/"",
            data: values");
            WriteLiteral(",\r\n            success: function (fun4) {\r\n                alert(\"Güncelleme işlemi yapıldı\");\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
