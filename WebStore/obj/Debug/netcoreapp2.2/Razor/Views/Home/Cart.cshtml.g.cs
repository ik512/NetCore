#pragma checksum "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d097fce300da94b06100ed37f8a85cadeb9b6be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cart.cshtml", typeof(AspNetCore.Views_Home_Cart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d097fce300da94b06100ed37f8a85cadeb9b6be", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a718cb6fc7cbd377f3b111040e33b15bdb51e365", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\ПРОЕКТЫ_VISUAL_ASP_NET\WebStore\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "cart";
   // Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 6200, true);
            WriteLiteral(@"
<section id=""cart_items"">
    <div class=""container"">
        <div class=""breadcrumbs"">
            <ol class=""breadcrumb"">
                <li><a href=""#"">Home</a></li>
                <li class=""active"">Shopping Cart</li>
            </ol>
        </div>
        <div class=""table-responsive cart_info"">
            <table class=""table table-condensed"">
                <thead>
                    <tr class=""cart_menu"">
                        <td class=""image"">Item</td>
                        <td class=""description""></td>
                        <td class=""price"">Price</td>
                        <td class=""quantity"">Quantity</td>
                        <td class=""total"">Total</td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class=""cart_product"">
                            <a href=""""><img src=""images/cart/one.png"" alt=""""></a>
                        </td>
       ");
            WriteLiteral(@"                 <td class=""cart_description"">
                            <h4><a href="""">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up"" href=""""> + </a>
                                <input class=""cart_quantity_input"" type=""text"" name=""quantity"" value=""1"" autocomplete=""off"" size=""2"">
                                <a class=""cart_quantity_down"" href=""""> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a cla");
            WriteLiteral(@"ss=""cart_quantity_delete"" href=""""><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>

                    <tr>
                        <td class=""cart_product"">
                            <a href=""""><img src=""images/cart/two.png"" alt=""""></a>
                        </td>
                        <td class=""cart_description"">
                            <h4><a href="""">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up"" href=""""> + </a>
                                <input class=""cart_quantity_input"" type=""text"" name=""quantity"" value=""1"" autocomplete=""off"" size=""2"">
                                <a class=""cart_qua");
            WriteLiteral(@"ntity_down"" href=""""> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete"" href=""""><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>
                    <tr>
                        <td class=""cart_product"">
                            <a href=""""><img src=""images/cart/three.png"" alt=""""></a>
                        </td>
                        <td class=""cart_description"">
                            <h4><a href="""">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
 ");
            WriteLiteral(@"                           <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up"" href=""""> + </a>
                                <input class=""cart_quantity_input"" type=""text"" name=""quantity"" value=""1"" autocomplete=""off"" size=""2"">
                                <a class=""cart_quantity_down"" href=""""> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete"" href=""""><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</section> <!--/#cart_items-->

<section id=""do_action"">
    <div class=""container"">
        <div class=""heading"">
            <h3>What would you like to do next?</h3>
            WriteLiteral(@"
            <p>Choose if you have a discount code or reward points you want to use or would like to estimate your delivery cost.</p>
        </div>
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""chose_area"">
                    <ul class=""user_option"">
                        <li>
                            <input type=""checkbox"">
                            <label>Use Coupon Code</label>
                        </li>
                        <li>
                            <input type=""checkbox"">
                            <label>Use Gift Voucher</label>
                        </li>
                        <li>
                            <input type=""checkbox"">
                            <label>Estimate Shipping & Taxes</label>
                        </li>
                    </ul>
                    <ul class=""user_info"">
                        <li class=""single_field"">
                            <label>Country:</label>
              ");
            WriteLiteral("              <select>\r\n                                ");
            EndContext();
            BeginContext(6291, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be9866", async() => {
                BeginContext(6299, 13, true);
                WriteLiteral("United States");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6321, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6355, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be11082", async() => {
                BeginContext(6363, 10, true);
                WriteLiteral("Bangladesh");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6382, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6416, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be12296", async() => {
                BeginContext(6424, 2, true);
                WriteLiteral("UK");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6435, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6469, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be13501", async() => {
                BeginContext(6477, 5, true);
                WriteLiteral("India");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6491, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6525, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be14709", async() => {
                BeginContext(6533, 8, true);
                WriteLiteral("Pakistan");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6550, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6584, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be15920", async() => {
                BeginContext(6592, 6, true);
                WriteLiteral("Ucrane");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6607, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6641, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be17129", async() => {
                BeginContext(6649, 6, true);
                WriteLiteral("Canada");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6664, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(6698, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be18338", async() => {
                BeginContext(6706, 5, true);
                WriteLiteral("Dubai");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6720, 255, true);
            WriteLiteral("\r\n                            </select>\r\n\r\n                        </li>\r\n                        <li class=\"single_field\">\r\n                            <label>Region / State:</label>\r\n                            <select>\r\n                                ");
            EndContext();
            BeginContext(6975, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be19782", async() => {
                BeginContext(6983, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6998, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7032, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be20991", async() => {
                BeginContext(7040, 5, true);
                WriteLiteral("Dhaka");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7054, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7088, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be22199", async() => {
                BeginContext(7096, 6, true);
                WriteLiteral("London");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7111, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7145, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be23408", async() => {
                BeginContext(7153, 6, true);
                WriteLiteral("Dillih");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7168, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7202, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be24617", async() => {
                BeginContext(7210, 6, true);
                WriteLiteral("Lahore");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7225, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7259, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be25826", async() => {
                BeginContext(7267, 6, true);
                WriteLiteral("Alaska");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7282, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7316, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be27035", async() => {
                BeginContext(7324, 6, true);
                WriteLiteral("Canada");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7339, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(7373, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d097fce300da94b06100ed37f8a85cadeb9b6be28244", async() => {
                BeginContext(7381, 5, true);
                WriteLiteral("Dubai");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7395, 1131, true);
            WriteLiteral(@"
                            </select>

                        </li>
                        <li class=""single_field zip-field"">
                            <label>Zip Code:</label>
                            <input type=""text"">
                        </li>
                    </ul>
                    <a class=""btn btn-default update"" href="""">Get Quotes</a>
                    <a class=""btn btn-default check_out"" href="""">Continue</a>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""total_area"">
                    <ul>
                        <li>Cart Sub Total <span>$59</span></li>
                        <li>Eco Tax <span>$2</span></li>
                        <li>Shipping Cost <span>Free</span></li>
                        <li>Total <span>$61</span></li>
                    </ul>
                    <a class=""btn btn-default update"" href="""">Update</a>
                    <a class=""btn btn-default check_out"" href="""">Check Out<");
            WriteLiteral("/a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section><!--/#do_action-->\r\n");
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