#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_PlatformSettings\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f925638f69bcf4586064c62ff67ec5198b4000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__PlatformSettings_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_PlatformSettings/Default.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f925638f69bcf4586064c62ff67ec5198b4000", @"/Views/Shared/Components/_PlatformSettings/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__PlatformSettings_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-0"">Platform Ayarları</h6>
        </div>
        <div class=""card-body p-3"">
            <h6 class=""text-uppercase text-body text-xs font-weight-bolder"">Hesap</h6>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault"" checked>
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault"">İki Adımlı Doğrulamayı Aktifleştir</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefaul");
            WriteLiteral(@"t1"">
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault1"">Her Üç Ayda Bir Şifremi Güncelle</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault2"" checked>
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault2"">Mention İşlemlerinde Mail Bilgisi Gönder</label>
                    </div>
                </li>
            </ul>
            <h6 class=""text-uppercase text-body text-xs font-weight-bolder mt-4"">Mail Bülteni</h6>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-inpu");
            WriteLiteral(@"t ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault3"">
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault3"">Yeni Tur Rotaları Eklenince Haber Ver</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault4"" checked>
                        <label class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault4"">Aylık Tur Bülteni Hakkında Maille Bilgilendir</label>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0 pb-0"">
                    <div class=""form-check form-switch ps-0"">
                        <input class=""form-check-input ms-auto"" type=""checkbox"" id=""flexSwitchCheckDefault5"">
                        <label ");
            WriteLiteral(@"class=""form-check-label text-body ms-3 text-truncate w-80 mb-0"" for=""flexSwitchCheckDefault5"">Youtube'da Yeni Video Paylaşınca Bildirim Gönder</label>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</div>
");
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
