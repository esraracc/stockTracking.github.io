#pragma checksum "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678d2200aa7e804cbea3b1604762b58eede38e4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using StockTrackingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using StockTrackingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678d2200aa7e804cbea3b1604762b58eede38e4e", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"521a21b8b81c23228b0f613a3da1335144f3a901", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Account\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678d2200aa7e804cbea3b1604762b58eede38e4e4502", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 265, "\"", 275, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <title>");
#nullable restore
#line 11 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Account\Login.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - StockTrackingApp</title>

    <!-- favicon ============================================ -->
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""/theme/img/favicon.ico"">
    <!-- Google Fonts ============================================ -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto:100,300,400,700,900"" rel=""stylesheet"">
    <!-- Bootstrap CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/bootstrap.min.css"">
    <!-- Bootstrap CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/font-awesome.min.css"">
    <!-- owl.carousel CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/owl.carousel.css"">
    <link rel=""stylesheet"" href=""/theme/css/owl.theme.css"">
    <link rel=""stylesheet"" href=""/theme/css/owl.transitions.css"">
    <!-- meanmenu CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/meanme");
                WriteLiteral(@"nu/meanmenu.min.css"">
    <!-- animate CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/animate.css"">
    <!-- normalize CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/normalize.css"">
    <!-- mCustomScrollbar CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/scrollbar/jquery.mCustomScrollbar.min.css"">
    <!-- jvectormap CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/jvectormap/jquery-jvectormap-2.0.3.css"">
    <!-- notika icon CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/notika-custom-icon.css"">
    <!-- wave CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/wave/waves.min.css"">
    <!-- main CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/main.css"">
    <");
                WriteLiteral(@"!-- style CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/style.css"">
    <!-- responsive CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/responsive.css"">
    <!-- modernizr JS ============================================ -->
    <script src=""/theme/js/vendor/modernizr-2.8.3.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678d2200aa7e804cbea3b1604762b58eede38e4e8703", async() => {
                WriteLiteral(@"

    <!-- Login Register area Start-->
    <div class=""login-content"">
        <!-- Login -->
        <div class=""nk-block toggled"" id=""l-login"">
            <div class=""nk-form"">
                <div class=""input-group"">
                    <span class=""input-group-addon nk-ic-st-pro""><i class=""notika-icon notika-support""></i></span>
                    <div class=""nk-int-st"">
                        <input type=""text"" class=""form-control"" placeholder=""Username"">
                    </div>
                </div>
                <div class=""input-group mg-t-15"">
                    <span class=""input-group-addon nk-ic-st-pro""><i class=""notika-icon notika-edit""></i></span>
                    <div class=""nk-int-st"">
                        <input type=""password"" class=""form-control"" placeholder=""Password"">
                    </div>
                </div>
                <button type=""button"" class=""btn btn-login btn-success"">Giriş Yap</button>
                <div class=""mt-4"" style="" dis");
                WriteLiteral(@"play: flex; justify-content: space-between;"">
                    <a href=""/account/register"" data-ma-action=""nk-login-switch"" data-ma-block=""#l-register""><i class=""notika-icon notika-plus-symbol""></i> <span>Kayıt Ol</span></a>
                    <a href=""/account/forgotPassword"" data-ma-action=""nk-login-switch"" data-ma-block=""#l-forget-password""><i>?</i> <span>Şifremi Unuttum</span></a>
                </div>
            </div>
        </div>

    </div>
    <!-- Login Register area End-->
    <!-- jquery ============================================ -->
    <script src=""/theme/js/vendor/jquery-1.12.4.min.js""></script>
    <!-- bootstrap JS ============================================ -->
    <script src=""/theme/js/bootstrap.min.js""></script>
    <!-- wow JS ============================================ -->
    <script src=""/theme/js/wow.min.js""></script>
    <!-- price-slider JS ============================================ -->
    <script src=""/theme/js/jquery-price-slider.js""></script>
    ");
                WriteLiteral(@"<!-- owl.carousel JS ============================================ -->
    <script src=""/theme/js/owl.carousel.min.js""></script>
    <!-- scrollUp JS ============================================ -->
    <script src=""/theme/js/jquery.scrollUp.min.js""></script>
    <!-- meanmenu JS ============================================ -->
    <script src=""/theme/js/meanmenu/jquery.meanmenu.js""></script>
    <!-- counterup JS ============================================ -->
    <script src=""/theme/js/counterup/jquery.counterup.min.js""></script>
    <script src=""/theme/js/counterup/waypoints.min.js""></script>
    <script src=""/theme/js/counterup/counterup-active.js""></script>
    <!-- mCustomScrollbar JS ============================================ -->
    <script src=""/theme/js/scrollbar/jquery.mCustomScrollbar.concat.min.js""></script>
    <!-- jvectormap JS ============================================ -->
    <script src=""/theme/js/jvectormap/jquery-jvectormap-2.0.2.min.js""></script>
    <script src=""/theme");
                WriteLiteral(@"/js/jvectormap/jquery-jvectormap-world-mill-en.js""></script>
    <script src=""/theme/js/jvectormap/jvectormap-active.js""></script>
    <!-- sparkline JS ============================================ -->
    <script src=""/theme/js/sparkline/jquery.sparkline.min.js""></script>
    <script src=""/theme/js/sparkline/sparkline-active.js""></script>
    <!-- sparkline JS ============================================ -->
    <script src=""/theme/js/flot/jquery.flot.js""></script>
    <script src=""/theme/js/flot/jquery.flot.resize.js""></script>
    <script src=""/theme/js/flot/curvedLines.js""></script>
    <script src=""/theme/js/flot/flot-active.js""></script>
    <!-- knob JS ============================================ -->
    <script src=""/theme/js/knob/jquery.knob.js""></script>
    <script src=""/theme/js/knob/jquery.appear.js""></script>
    <script src=""/theme/js/knob/knob-active.js""></script>
    <!--  wave JS ============================================ -->
    <script src=""/theme/js/wave/waves.min.js""></");
                WriteLiteral(@"script>
    <script src=""/theme/js/wave/wave-active.js""></script>
    <!--  todo JS ============================================ -->
    <script src=""/theme/js/todo/jquery.todo.js""></script>
    <!-- plugins JS ============================================ -->
    <script src=""/theme/js/plugins.js""></script>
    <!-- main JS ============================================ -->
    <script src=""/theme/js/main.js""></script>


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678d2200aa7e804cbea3b1604762b58eede38e4e13749", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678d2200aa7e804cbea3b1604762b58eede38e4e14849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
