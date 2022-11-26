#pragma checksum "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d53ca21cc55495182432850076a498f5956b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d53ca21cc55495182432850076a498f5956b4f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297035958af3ec51ec26dc7cfc5059d4e3ad788a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row  mt-3"">
    <div class=""col-xl-12 d-flex grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex flex-wrap justify-content-between"">
                    <h4 class=""card-title mb-3"">Toplam Cari</h4>
                    <p class=""mb-3 float-right"">
                        <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModaltwo"">+ Yeni Ürün Ekle</button>
                    </p>
                </div>
                <div class=""modal fade"" id=""myModaltwo"" role=""dialog"" style=""display: none;"">
                    <div class=""modal-dialog modal-sm"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                            </div>
                            <h2 class=""modal-title"">Yeni Ürün Ekle</h2>
                            <div ");
            WriteLiteral(@"class=""modal-body"">
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""form-group ic-cmp-int"">
                                        Ürün adı
                                        <div class=""nk-int-st"">
                                            <input type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""form-group ic-cmp-int"">
                                        Açıklama
                                        <div class=""nk-int-st"">
                                            <input type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                 ");
            WriteLiteral(@"               <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""form-group ic-cmp-int"">
                                        Geliş Fiyatı
                                        <div class=""nk-int-st"">
                                            <input type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""form-group ic-cmp-int"">
                                        Satış Fiyatı
                                        <div class=""nk-int-st"">
                                            <input type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col");
            WriteLiteral(@"-lg-12 col-md-12 col-sm-12 col-xs-12"">
                                    <div class=""form-group ic-cmp-int"">
                                        Stok Sayısı
                                        <div class=""nk-int-st"">
                                            <input type=""number"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-light"" data-dismiss=""modal"">Vazgeç</button>
                                <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">Ürünü ekle</button>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""table-respon");
            WriteLiteral(@"sive"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Ürün Adı</th>
                                        <th>Açıklama</th>
                                        <th>Maliyet Fiyatı</th>
                                        <th>Satış Fiyatı</th>
                                        <th>Toplam Adet</th>
                                        <th>Beklenen Kar</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
