#pragma checksum "C:\Users\PC\Desktop\StockTrackingApp\StockTrackingApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c32caddef3205300a9d932ad8fca407815f8fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using StockTrackingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using StockTrackingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c32caddef3205300a9d932ad8fca407815f8fa", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"521a21b8b81c23228b0f613a3da1335144f3a901", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist//theme/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c32caddef3205300a9d932ad8fca407815f8fa4197", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 238, "\"", 248, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <title>");
#nullable restore
#line 8 "C:\Users\PC\Desktop\StockTrackingApp\StockTrackingApp\Views\Shared\_Layout.cshtml"
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
    <link rel=""stylesheet"" href=""/theme/css/wave/button.css"">
    <link rel=""stylesheet"" href=""/theme/css/chosen/chosen.css"">
 ");
                WriteLiteral(@"   <!-- main CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/main.css"">
    <!-- Data Table JS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/jquery.dataTables.min.css"">
    <!-- style CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/style.css"">
    <!-- responsive CSS ============================================ -->
    <link rel=""stylesheet"" href=""/theme/css/responsive.css"">
    <!-- modernizr JS ============================================ -->
    <script src=""/theme/js/vendor/modernizr-2.8.3.min.js""></script>

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/regular.min.css"" />
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c32caddef3205300a9d932ad8fca407815f8fa8889", async() => {
                WriteLiteral(@"
    <!-- Start Header Top Area -->
    <header class=""header-top-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                    <div class=""logo-area"">
                        <a href=""/home/index""><img src=""/theme/img/logo/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 3577, "\"", 3583, 0);
                EndWriteAttribute();
                WriteLiteral(@" /></a>
                    </div>
                </div>
                <div class=""col-lg-8 col-md-8 col-sm-12 col-xs-12"">
                    <div class=""header-top-menu"">
                        <ul class=""nav navbar-nav notika-top-nav"">
                            <li class=""nav-item dropdown"">
                                <a href=""#"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false"" class=""nav-link dropdown-toggle"">
                                    <span><i class=""fa-solid fa-user""></i> user123</span>
                                </a>
                                <div role=""menu"" class=""dropdown-menu message-dd animated zoomIn"">
                                    <div class=""hd-message-info"" style=""display: flex; justify-content: center;"">
                                        <a href=""#"">
                                            <span><i class=""fa-solid fa-power-off""></i> Çıkış Yap</span>
                                        </a>
                           ");
                WriteLiteral(@"         </div>
                                </div>
                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- End Header Top Area -->
    <!-- Mobile Menu start -->
    <div class=""mobile-menu-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""mobile-menu"">
                        <nav id=""dropdown"">
                            <ul class=""mobile-menu-nav"">
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#Charts"" href=""#"">Home</a>
                                    <ul class=""collapse dropdown-header-top"">
                                        <li><a href=""index.html"">Dashboard One</a></li>
                                        <li><a href=""index-2.html"">Dashboard Two</a></li>
         ");
                WriteLiteral(@"                               <li><a href=""index-3.html"">Dashboard Three</a></li>
                                        <li><a href=""index-4.html"">Dashboard Four</a></li>
                                        <li><a href=""analytics.html"">Analytics</a></li>
                                        <li><a href=""widgets.html"">Widgets</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#demoevent"" href=""#"">Email</a>
                                    <ul id=""demoevent"" class=""collapse dropdown-header-top"">
                                        <li><a href=""inbox.html"">Inbox</a></li>
                                        <li><a href=""view-email.html"">View Email</a></li>
                                        <li><a href=""compose-email.html"">Compose Email</a></li>
                                    </ul>
                                </li>
  ");
                WriteLiteral(@"                              <li>
                                    <a data-toggle=""collapse"" data-target=""#democrou"" href=""#"">Interface</a>
                                    <ul id=""democrou"" class=""collapse dropdown-header-top"">
                                        <li><a href=""animations.html"">Animations</a></li>
                                        <li><a href=""google-map.html"">Google Map</a></li>
                                        <li><a href=""data-map.html"">Data Maps</a></li>
                                        <li><a href=""code-editor.html"">Code Editor</a></li>
                                        <li><a href=""image-cropper.html"">Images Cropper</a></li>
                                        <li><a href=""wizard.html"">Wizard</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#demolibra"" href=""#"">Charts</a>
             ");
                WriteLiteral(@"                       <ul id=""demolibra"" class=""collapse dropdown-header-top"">
                                        <li><a href=""flot-charts.html"">Flot Charts</a></li>
                                        <li><a href=""bar-charts.html"">Bar Charts</a></li>
                                        <li><a href=""line-charts.html"">Line Charts</a></li>
                                        <li><a href=""area-charts.html"">Area Charts</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#demodepart"" href=""#"">Tables</a>
                                    <ul id=""demodepart"" class=""collapse dropdown-header-top"">
                                        <li><a href=""normal-table.html"">Normal Table</a></li>
                                        <li><a href=""data-table.html"">Data Table</a></li>
                                    </ul>
                    ");
                WriteLiteral(@"            </li>
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#demo"" href=""#"">Forms</a>
                                    <ul id=""demo"" class=""collapse dropdown-header-top"">
                                        <li><a href=""form-elements.html"">Form Elements</a></li>
                                        <li><a href=""form-components.html"">Form Components</a></li>
                                        <li><a href=""form-examples.html"">Form Examples</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#Miscellaneousmob"" href=""#"">App views</a>
                                    <ul id=""Miscellaneousmob"" class=""collapse dropdown-header-top"">
                                        <li>
                                            <a href=""notification.html"">Notifications</a>
     ");
                WriteLiteral(@"                                   </li>
                                        <li>
                                            <a href=""alert.html"">Alerts</a>
                                        </li>
                                        <li>
                                            <a href=""modals.html"">Modals</a>
                                        </li>
                                        <li>
                                            <a href=""buttons.html"">Buttons</a>
                                        </li>
                                        <li>
                                            <a href=""tabs.html"">Tabs</a>
                                        </li>
                                        <li>
                                            <a href=""accordion.html"">Accordion</a>
                                        </li>
                                        <li>
                                            <a href=""dialog.html"">Dialogs</a>");
                WriteLiteral(@"
                                        </li>
                                        <li>
                                            <a href=""popovers.html"">Popovers</a>
                                        </li>
                                        <li>
                                            <a href=""tooltips.html"">Tooltips</a>
                                        </li>
                                        <li>
                                            <a href=""dropdown.html"">Dropdowns</a>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                    <a data-toggle=""collapse"" data-target=""#Pagemob"" href=""#"">Pages</a>
                                    <ul id=""Pagemob"" class=""collapse dropdown-header-top"">
                                        <li>
                                            <a href=""contact.html"">Contact</a>
       ");
                WriteLiteral(@"                                 </li>
                                        <li>
                                            <a href=""invoice.html"">Invoice</a>
                                        </li>
                                        <li>
                                            <a href=""typography.html"">Typography</a>
                                        </li>
                                        <li>
                                            <a href=""color.html"">Color</a>
                                        </li>
                                        <li>
                                            <a href=""login-register.html"">Login Register</a>
                                        </li>
                                        <li>
                                            <a href=""404.html"">404 Page</a>
                                        </li>
                                    </ul>
                                </li>
                        ");
                WriteLiteral(@"    </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Mobile Menu end -->
    <!-- Main Menu area start-->
    <div class=""main-menu-area mg-tb-40"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <ul class=""nav nav-tabs notika-menu-wrap menu-it-icon-pro"">
                        <li class=""nav-item"">
                            <a href=""/home/index"" class=""nav-link active""><i class=""notika-icon notika-house""></i> Anasayfa</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/cari/index"" class=""nav-link""><i class=""notika-icon notika-house""></i> Cariler</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/product/index"" class=""nav-link""><i class=""notika-icon notika-house""");
                WriteLiteral(@"></i> Ürünler</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/stock/index"" class=""nav-link""><i class=""notika-icon notika-house""></i> Stok</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!-- Main Menu area End-->
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 239 "C:\Users\PC\Desktop\StockTrackingApp\StockTrackingApp\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <!-- Start Footer area-->
    <div class=""footer-copyright-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""footer-copy-right"">
                        <p>
                            Copyright © 2022. All rights reserved. Esra ARAÇ
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Footer area-->
    <!-- jquery ============================================ -->
    <script src=""/theme/js/vendor/jquery-1.12.4.min.js""></script>
    <!-- bootstrap JS ============================================ -->
    <script src=""/theme/js/bootstrap.min.js""></script>
    <!-- wow JS ============================================ -->
    <script src=""/theme/js/wow.min.js""></script>
    <!-- price-slider JS ============================================ -->
    <script s");
                WriteLiteral(@"rc=""/theme/js/jquery-price-slider.js""></script>
    <!-- owl.carousel JS ============================================ -->
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
    <script src=""/theme/js/jvectormap/jquery-jvecto");
                WriteLiteral(@"rmap-2.0.2.min.js""></script>
    <script src=""/theme/js/jvectormap/jquery-jvectormap-world-mill-en.js""></script>
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
    <!--  wave JS ============================================ ");
                WriteLiteral(@"-->
    <script src=""/theme/js/wave/waves.min.js""></script>
    <script src=""/theme/js/wave/wave-active.js""></script>
    <script src=""/theme/js/chosen/chosen.jquery.js""></script>
    <!--  todo JS ============================================ -->
    <script src=""/theme/js/todo/jquery.todo.js""></script>
    <!-- plugins JS ============================================ -->
    <script src=""/theme/js/plugins.js""></script>
    <!-- main JS ============================================ -->
    <script src=""/theme/js/main.js""></script>
    <!-- Data Table JS ============================================ -->
    <script src=""/theme/js/data-table/jquery.dataTables.min.js""></script>
    <script src=""/theme/js/data-table/data-table-act.js""></script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c32caddef3205300a9d932ad8fca407815f8fa25204", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c32caddef3205300a9d932ad8fca407815f8fa26304", async() => {
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
                WriteLiteral("\r\n    ");
#nullable restore
#line 310 "C:\Users\PC\Desktop\StockTrackingApp\StockTrackingApp\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
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
