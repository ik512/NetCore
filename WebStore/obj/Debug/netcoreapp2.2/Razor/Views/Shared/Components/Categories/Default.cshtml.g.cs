#pragma checksum "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e276a03de914ceefbc38b85195198eecb6ac58b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Categories/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Categories_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e276a03de914ceefbc38b85195198eecb6ac58b", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718cb6fc7cbd377f3b111040e33b15bdb51e365", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.ViewModels.CategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 112, true);
            WriteLiteral("\r\n<h2>Category</h2>\r\n<div class=\"panel-group category-products\" id=\"accordian\">\r\n    <!--category-productsr-->\r\n");
            EndContext();
#line 6 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
     foreach (var parentCategory in Model)
    {
        if (parentCategory.ChildCategories.Count > 0) // есть дочерние категории
        {

#line default
#line hidden
            BeginContext(315, 180, true);
            WriteLiteral("    <div class=\"panel panel-default\">\r\n        <div class=\"panel-heading\">\r\n            <h4 class=\"panel-title\">\r\n                <a data-toggle=\"collapse\" data-parent=\"#accordian\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 495, "\"", 533, 2);
            WriteAttributeValue("", 502, "#", 502, 1, true);
#line 13 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 503, parentCategory.Name.ToLower(), 503, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(534, 109, true);
            WriteLiteral(">\r\n                    <span class=\"badge pull-right\"><i class=\"fa fa-plus\"></i></span>\r\n                    ");
            EndContext();
            BeginContext(644, 19, false);
#line 15 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
               Write(parentCategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(663, 71, true);
            WriteLiteral("\r\n                </a>\r\n            </h4>\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 734, "\"", 769, 1);
#line 19 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 739, parentCategory.Name.ToLower(), 739, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(770, 95, true);
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n            <div class=\"panel-body\">\r\n                <ul>\r\n");
            EndContext();
#line 22 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
                     foreach (var childCategory in parentCategory.ChildCategories)
                            {

#line default
#line hidden
            BeginContext(980, 50, true);
            WriteLiteral("                    <li>\r\n                        ");
            EndContext();
            BeginContext(1030, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e276a03de914ceefbc38b85195198eecb6ac58b6435", async() => {
                BeginContext(1117, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1148, 18, false);
#line 26 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
                       Write(childCategory.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1166, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
                                                                                WriteLiteral(childCategory.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CategoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1196, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 29 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1256, 71, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 34 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"

        }
        else
        {

#line default
#line hidden
            BeginContext(1365, 130, true);
            WriteLiteral("    <div class=\"panel panel-default\">\r\n        <div class=\"panel-heading\">\r\n            <h4 class=\"panel-title\">\r\n                ");
            EndContext();
            BeginContext(1495, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e276a03de914ceefbc38b85195198eecb6ac58b10262", async() => {
                BeginContext(1583, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1606, 19, false);
#line 42 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
               Write(parentCategory.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1625, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
                                                                        WriteLiteral(parentCategory.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CategoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1647, 49, true);
            WriteLiteral("\r\n            </h4>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 47 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Shared\Components\Categories\Default.cshtml"
        }

    }

#line default
#line hidden
            BeginContext(1716, 33, true);
            WriteLiteral("\r\n</div><!--/category-products-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.ViewModels.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
