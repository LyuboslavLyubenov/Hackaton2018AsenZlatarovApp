#pragma checksum "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b7943008778f49ca915dbcec0bf69342bb5142"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Quests_Views_Quest_GetAllQuests), @"mvc.1.0.view", @"/Areas/Quests/Views/Quest/GetAllQuests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Quests/Views/Quest/GetAllQuests.cshtml", typeof(AspNetCore.Areas_Quests_Views_Quest_GetAllQuests))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 6 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\_ViewImports.cshtml"
using HakatonApp.Web;

#line default
#line hidden
#line 2 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\_ViewImports.cshtml"
using HakatonApp.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\_ViewImports.cshtml"
using HakatonApp.Data.Models;

#line default
#line hidden
#line 4 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\_ViewImports.cshtml"
using HakatonApp.Web.Areas.Quests.Models;

#line default
#line hidden
#line 5 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\_ViewImports.cshtml"
using HakatonApp.Services.Quests.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b7943008778f49ca915dbcec0bf69342bb5142", @"/Areas/Quests/Views/Quest/GetAllQuests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c643a104a9585dc47e6da2b5e7d5f337fb9015", @"/Areas/Quests/Views/_ViewImports.cshtml")]
    public class Areas_Quests_Views_Quest_GetAllQuests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuestServiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Quests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(78, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
 foreach (var quest in Model)
{



#line default
#line hidden
            BeginContext(120, 76, true);
            WriteLiteral("    <div class=\"col-lg-3 col-md-5 mb-4\">\r\n        <div class=\"card h-100\">\r\n");
            EndContext();
#line 13 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
              
                if (quest.Image != null)
                {
                    var base64 = Convert.ToBase64String(quest.Image);
                    var imgSrc = String.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
            BeginContext(430, 80, true);
            WriteLiteral("                    <a href=\"#\"><img class=\"card-img-top\" style=\"height: 250px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 510, "\"", 523, 1);
#line 18 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
WriteAttributeValue("", 516, imgSrc, 516, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(524, 14, true);
            WriteLiteral(" alt=\"\"></a>\r\n");
            EndContext();
#line 19 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
                }
            

#line default
#line hidden
            BeginContext(572, 110, true);
            WriteLiteral("            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">\r\n                    <a href=\"#\">");
            EndContext();
            BeginContext(683, 10, false);
#line 23 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
                           Write(quest.Name);

#line default
#line hidden
            EndContext();
            BeginContext(693, 66, true);
            WriteLiteral("</a>\r\n                </h4>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(760, 27, false);
#line 25 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
                                Write(Html.Raw(quest.Description));

#line default
#line hidden
            EndContext();
            BeginContext(787, 42, true);
            WriteLiteral("</p>\r\n                <div class=\"py-3\">\r\n");
            EndContext();
#line 27 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
                       var data = new Dictionary<string, string>() { { "id", quest.Id.ToString() } }; 

#line default
#line hidden
            BeginContext(934, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(954, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310b49dee38245dc886d6207459b39f5", async() => {
                BeginContext(1081, 3, true);
                WriteLiteral("Още");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 28 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = data;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1088, 74, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 33 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetAllQuests.cshtml"
}

#line default
#line hidden
            BeginContext(1165, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuestServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
