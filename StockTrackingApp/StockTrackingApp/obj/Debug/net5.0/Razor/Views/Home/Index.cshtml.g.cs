#pragma checksum "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca856773f3380ee26d9281866c1fa8bc369d451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 4 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using StockTrackingApp.Models.AccountModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca856773f3380ee26d9281866c1fa8bc369d451", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297035958af3ec51ec26dc7cfc5059d4e3ad788a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row  mt-3"">
    <div class=""col-xl-4 d-flex grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-wrap justify-content-between"">
                    <h4 class=""card-title mb-3"">Toplam Cari</h4>
                    <p class=""mb-3 float-right""><a href=""/announcement/AllAnnouncement"">Tümü</a></p>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        30
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-4 d-flex grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-wrap justify-content-between"">
                    <h4 class=""card-title mb-3"">Toplam Ürün</h4>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        30
           ");
            WriteLiteral(@"         </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-4 d-flex grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-wrap justify-content-between"">
                    <h4 class=""card-title mb-3"">Toplam Stok</h4>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        30
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row  mt-3"">
    <div class=""col-xl-12 d-flex grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-wrap justify-content-between"">
                    <h4 class=""card-title mb-3"">Ürün Satış İstatistiği</h4>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <div cla");
            WriteLiteral(@"ss=""d-md-flex mb-4"">
                            <div class=""mr-md-5 mb-4"">
                                <h5 class=""mb-1""><i class=""typcn typcn-globe-outline mr-1""></i>Online</h5>
                                <h2 class=""text-primary mb-1 font-weight-bold"">23,342</h2>
                            </div>
                            <div class=""mr-md-5 mb-4"">
                                <h5 class=""mb-1""><i class=""typcn typcn-archive mr-1""></i>Offline</h5>
                                <h2 class=""text-secondary mb-1 font-weight-bold"">13,221</h2>
                            </div>
                            <div class=""mr-md-5 mb-4"">
                                <h5 class=""mb-1""><i class=""typcn typcn-tags mr-1""></i>Marketing</h5>
                                <h2 class=""text-warning mb-1 font-weight-bold"">1,542</h2>
                            </div>
                        </div>
                        <canvas id=""salesanalyticChart""></canvas>
                    </div>
         ");
            WriteLiteral("       </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
