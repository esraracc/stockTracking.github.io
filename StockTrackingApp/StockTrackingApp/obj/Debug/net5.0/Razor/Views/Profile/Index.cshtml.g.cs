#pragma checksum "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cf28511d9e1e5f6749ba6a4c2aa9b4f9ff94ebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf28511d9e1e5f6749ba6a4c2aa9b4f9ff94ebe", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f81bb48b8e6eaf4951dbe9b820aa289c677258c", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""col-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title float-left"">
                Profilim
            </h4>
            <p class=""card-description float-right"">

            </p>
            <div class=""clearfix""></div>
            <div class=""row"">
                ");
#nullable restore
#line 20 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
           Write(await Html.PartialAsync("/Views/Shared/Partial View/Profile/_profilePV.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-9"">

                    <div class=""col-12 grid-margin stretch-card"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <h4 class=""card-title float-left"">
                                    Kullanıcılar
                                </h4>
                                <p class=""card-description float-right"">
                                    <a href=""/profile/register"" class=""btn btn-sm btn-primary"">
                                        + Yeni Admin Ekle
                                    </a>
                                </p>
                                <div class=""clearfix""></div>

");
#nullable restore
#line 36 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                 if (Model.Users.Where(x => x.UserName != Model.User.UserName).Count() > 0)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""table-responsive pt-3"">
                                        <table class=""table table-bordered"" id=""myTable"">
                                            <thead>
                                                <tr>
                                                    <th scope=""col"">Yetkili</th>
                                                    <th scope=""col"">Kullanıcı Adı</th>
                                                    <th scope=""col"">Telefon</th>
                                                    <th scope=""col"">E-Posta</th>
                                                    <th scope=""col"">#</th>
                                                    <th scope=""col"">#</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 52 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                 foreach (var item in Model.Users.Where(x => x.UserName != Model.User.UserName))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 56 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                                       Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>");
#nullable restore
#line 58 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 59 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 60 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3186, "\"", 3223, 2);
            WriteAttributeValue("", 3193, "/Profile/UpdateUser/", 3193, 20, true);
#nullable restore
#line 62 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
WriteAttributeValue("", 3213, item.Id, 3213, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm fas fa-edit text-white\"></a>\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cf28511d9e1e5f6749ba6a4c2aa9b4f9ff94ebe11594", async() => {
                WriteLiteral("\r\n                                                                <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 3656, "\"", 3672, 1);
#nullable restore
#line 66 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
WriteAttributeValue("", 3664, item.Id, 3664, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                <button type=\"submit\" class=\"btn bg-danger btn-sm fas fa-trash text-white\"></button>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 71 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                            </tbody>\r\n                                        </table>\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 79 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h3 class=\"p-4 bg-warning text-white\">Hiç Admin kullanıcısı yok.</h3>\r\n");
#nullable restore
#line 84 "C:\Users\PC\Documents\GitHub\stockTracking.github.io\StockTrackingApp\StockTrackingApp\Views\Profile\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link href=\"//cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js""></script>
    <script>

        $(function () {
            $('#myTable').DataTable({
                ""language"": {
                    ""url"": ""https://cdn.datatables.net/plug-ins/1.12.1/i18n/tr.json""
                }
            });
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591