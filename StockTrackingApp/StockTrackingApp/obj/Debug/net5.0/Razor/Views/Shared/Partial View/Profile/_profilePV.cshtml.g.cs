#pragma checksum "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Shared\Partial View\Profile\_profilePV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a8842a841cf3f6946cc47b51ba116a505a8d31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial_View_Profile__profilePV), @"mvc.1.0.view", @"/Views/Shared/Partial View/Profile/_profilePV.cshtml")]
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
#nullable restore
#line 5 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\_ViewImports.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8842a841cf3f6946cc47b51ba116a505a8d31b", @"/Views/Shared/Partial View/Profile/_profilePV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f81bb48b8e6eaf4951dbe9b820aa289c677258c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial_View_Profile__profilePV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:30%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/userTemplate/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<div class=""col-md-3"">
    <div class=""card card-primary card-outline"" style=""border-top: 3px solid #007bff;"">
        <div class=""text-right"">
            <a href=""/Profile/Profile"" class=""btn btn-sm btn-warning btn-icon-text"" title=""Profilimi Güncelle"">
                <i class=""typcn typcn-edit btn-icon-prepend mr-0 text-white""></i>
            </a>
        </div>
        <div class=""card-body box-profile"">
            <div class=""text-center"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8842a841cf3f6946cc47b51ba116a505a8d31b5968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""card card-primary mt-2"">
        <div class=""card-header"" style=""background-color: #007bff;"">
            <h3 class=""card-title mb-0"">Hakkımda</h3>
        </div>
        <div class=""card-body"">

            <strong><i class=""fas fa-user-tie""></i> Kullanıcı Adı</strong>
            <p class=""text-muted"">");
#nullable restore
#line 24 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Shared\Partial View\Profile\_profilePV.cshtml"
                             Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr>\r\n            <strong><i class=\"fas fa-user-alt mr-1\"></i> Yetkili</strong>\r\n            <p class=\"text-muted\">");
#nullable restore
#line 27 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Shared\Partial View\Profile\_profilePV.cshtml"
                             Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Shared\Partial View\Profile\_profilePV.cshtml"
                                                   Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr>\r\n            <strong><i class=\"fas fa-phone\"></i> Telefon</strong>\r\n            <p class=\"text-muted\">");
#nullable restore
#line 30 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Shared\Partial View\Profile\_profilePV.cshtml"
                             Write(Model.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr>\r\n            <strong><i class=\"fas fa-envelope \"></i> E-Posta</strong>\r\n            <p class=\"text-muted\">");
#nullable restore
#line 33 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Shared\Partial View\Profile\_profilePV.cshtml"
                             Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
