#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\SignalRConsume\Views\Home\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d5828622476c6de7712545e4b95069e37369885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index3), @"mvc.1.0.view", @"/Views/Home/Index3.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TraversalCoreProject\SignalRConsume\Views\_ViewImports.cshtml"
using SignalRConsume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\SignalRConsume\Views\_ViewImports.cshtml"
using SignalRConsume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d5828622476c6de7712545e4b95069e37369885", @"/Views/Home/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488a7ba775b7651f7d95ee39c2c21d6d74a551a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\SignalRConsume\Views\Home\Index3.cshtml"
  
    ViewData["Title"] = "Index3";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Index2</h1>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d5828622476c6de7712545e4b95069e373698853891", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

    <script type=""text/javascript"">
        $(document).ready(() => {
            var visitChartList = new Array();
            visitChartList.push([""Tarih"", ""Edirne"", ""İstanbul"", ""Ankara"", ""Antalya"", ""Bursa""])
            var connection = new signalR.HubConnectionBuilder().withUrl(""http://localhost:29471/VisitorHub"").build();
            $(""#connectionStatus"").text(connection.connectionState);
            connection.start().then(() => {
                connection.invoke(""GetVisitorList"");
                $(""#connectionStatus"").text(connection.connectionState);
            }).catch((err) => { console.log(err) });
            connection.on(""ReceiveVisitorList"", (visitList) => {
                visitChartList = visitChartList.splice(0, 1);
                visitList.forEach((item) => {
                    visitChartList.push([item.visitDate, item.counts[0], item.counts[1], item.counts[2], item.counts[3],");
                WriteLiteral(@" item.counts[4]])
                })
                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback(drawChart);
            })
            function drawChart() {
                var data = google.visualization.arrayToDataTable(visitChartList);
                var options = {
                    title: 'Traversal Ziyaretçi Listesi Grafiği',
                    curveType: 'none',
                    legend: { position: 'bottom' }
                };
                var chart = new google.visualization.ColumnChart(document.getElementById('curve_chart'));
                chart.draw(data, options);
            }
        })
    </script>

");
            }
            );
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <div class=\"alert alert-warning\">\r\n        Bağlantınızın Durumu:<b id=\"connectionStatus\"></b>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<div id=\"curve_chart\" style=\"width: 1200px; height: 800px\"></div>\r\n\r\n\r\n");
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
