#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_MemberLayoutLanguages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f13e69ad20b63d1267d453065d064af6e120b41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__MemberLayoutLanguages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_MemberLayoutLanguages/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13e69ad20b63d1267d453065d064af6e120b41e", @"/Views/Shared/Components/_MemberLayoutLanguages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__MemberLayoutLanguages_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""nav navbar-nav float-right"">
    <li class=""dropdown dropdown-language nav-item"">
        <a class=""dropdown-toggle nav-link"" id=""dropdown-flag"" href=""#"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <i class=""flag-icon flag-icon-tr""></i>
            <span class=""selected-language""></span>
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""dropdown-flag"">
            <div class=""arrow_box"">
                <a class=""dropdown-item"" href=""/Member/Destination/Index/?culture=en""><i class=""flag-icon flag-icon-us""></i> English</a>
                <a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-cn""></i> Chinese</a>
                <a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-ru""></i> Russian</a>
                <a class=""dropdown-item"" href=""/Member/Destination/Index/?culture=fr""><i class=""flag-icon flag-icon-fr""></i> French</a>
                <a class=""dropdown-item"" href=""#""><i class=""flag-icon flag-icon-es""><");
            WriteLiteral("/i> Spanish</a>\r\n                <a class=\"dropdown-item\" href=\"/Member/Destination/Index/?culture=tr\"><i class=\"flag-icon flag-icon-tr\"></i> Turkish</a>\r\n            </div>\r\n        </div>\r\n    </li>\r\n</ul>\r\n");
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