#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b047a3ae62b66489ebeb78d42a065da0653c2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__LastDestinations_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_LastDestinations/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b047a3ae62b66489ebeb78d42a065da0653c2ed", @"/Views/Shared/Components/_LastDestinations/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5e4f4ee20e66c99cd8182431574b73439134f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__LastDestinations_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 mt-4"">
    <div class=""card mb-4"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-1"">Son Rotalar</h6>
            <p class=""text-sm"">Traversal Şirketinin En Son Eklenen Seyahat Rotaları</p>
        </div>
        <div class=""card-body p-3"">
            <div class=""row"">
");
#nullable restore
#line 10 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-xl-3 col-md-6 mb-xl-0 mb-4"">
                        <div class=""card card-blog card-plain"">
                            <div class=""position-relative"">
                                <a class=""d-block shadow-xl border-radius-xl"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 723, "\"", 740, 1);
#nullable restore
#line 16 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
WriteAttributeValue("", 729, item.Image, 729, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:400px; height:200px;"" alt=""img-blur-shadow"" class=""img-fluid shadow border-radius-xl"">
                                </a>
                            </div>
                            <div class=""card-body px-1 pb-0"">
                                <p class=""text-gradient text-dark mb-2 text-sm"">");
#nullable restore
#line 20 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                           Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</p>\r\n                                <a href=\"javascript:;\">\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 23 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                </a>\r\n                                <p class=\"mb-4 text-sm\">\r\n                                    ");
#nullable restore
#line 27 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                               Write(item.Details1.Substring(0,130));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                </p>\r\n                                <div class=\"d-flex align-items-center justify-content-between\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1689, 2);
            WriteAttributeValue("", 1638, "/Destination/DestinationDetails/", 1638, 32, true);
#nullable restore
#line 30 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
WriteAttributeValue("", 1670, item.DestinationID, 1670, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary btn-sm mb-0"">Tur Detayları</a>
                                    <div class=""avatar-group mt-2"">
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Elena Morison"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b047a3ae62b66489ebeb78d42a065da0653c2ed9801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Ryan Milly"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b047a3ae62b66489ebeb78d42a065da0653c2ed11190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Nick Daniel"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b047a3ae62b66489ebeb78d42a065da0653c2ed12581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Peterson"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b047a3ae62b66489ebeb78d42a065da0653c2ed13969", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Views\Shared\Components\_LastDestinations\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591
