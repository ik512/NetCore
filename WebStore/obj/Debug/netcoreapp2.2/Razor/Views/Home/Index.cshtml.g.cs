#pragma checksum "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf1c4d2adca7b9c6e5a7c36c644652fcec52620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf1c4d2adca7b9c6e5a7c36c644652fcec52620", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718cb6fc7cbd377f3b111040e33b15bdb51e365", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(37, 42, false);
#line 3 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Partial/_Slider"));

#line default
#line hidden
            EndContext();
            BeginContext(79, 82, true);
            WriteLiteral("\r\n\r\n<section>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(162, 47, false);
#line 8 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("Partial/_LeftSideBar"));

#line default
#line hidden
            EndContext();
            BeginContext(209, 115, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-9 padding-right\">\r\n           \r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeView>> Html { get; private set; }
    }
}
#pragma warning restore 1591