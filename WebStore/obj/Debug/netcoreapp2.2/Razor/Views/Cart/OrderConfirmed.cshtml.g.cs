#pragma checksum "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Cart\OrderConfirmed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0ba65d2aeec47124d6e2ae5700a0fa959073ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_OrderConfirmed), @"mvc.1.0.view", @"/Views/Cart/OrderConfirmed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/OrderConfirmed.cshtml", typeof(AspNetCore.Views_Cart_OrderConfirmed))]
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
#line 2 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\_ViewImports.cshtml"
using WebStore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0ba65d2aeec47124d6e2ae5700a0fa959073ed", @"/Views/Cart/OrderConfirmed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718cb6fc7cbd377f3b111040e33b15bdb51e365", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_OrderConfirmed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Cart\OrderConfirmed.cshtml"
  
    ViewBag.Title = "Ваш заказ принят";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 28, true);
            WriteLiteral("\r\n<h2>Ваш заказ под номером ");
            EndContext();
            BeginContext(126, 15, false);
#line 7 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Cart\OrderConfirmed.cshtml"
                     Write(ViewBag.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(141, 47, true);
            WriteLiteral(" принят и в скором времени будет обработан</h2>");
            EndContext();
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
