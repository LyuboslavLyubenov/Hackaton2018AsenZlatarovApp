#pragma checksum "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\Account\Manage\DownloadPersonalData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c13bd0255fd370ccd5c5aaf6bd29ffae443e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HakatonApp.Web.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_DownloadPersonalData), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml", typeof(HakatonApp.Web.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_DownloadPersonalData), null)]
namespace HakatonApp.Web.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using HakatonApp.Web.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using HakatonApp.Data.Models;

#line default
#line hidden
#line 1 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HakatonApp.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using HakatonApp.Web.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c13bd0255fd370ccd5c5aaf6bd29ffae443e28", @"/Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17e129ae3b8d6f6b1f373abd40c3a65f81828b8", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d38be36bc59e46d75f4f591eee2d74f82e57fce", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153f4c2f20cf1f1d415b722d831ca7d48b417541", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_DownloadPersonalData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\Account\Manage\DownloadPersonalData.cshtml"
  
    ViewData["Title"] = "Download Your Data";
    ViewData["ActivePage"] = ManageNavPages.DownloadPersonalData;

#line default
#line hidden
            BeginContext(162, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(169, 17, false);
#line 8 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Identity\Pages\Account\Manage\DownloadPersonalData.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(186, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(213, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(219, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa7ab0d4b78447f49bd2703050b1c016", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(263, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DownloadPersonalDataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DownloadPersonalDataModel>)PageContext?.ViewData;
        public DownloadPersonalDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
