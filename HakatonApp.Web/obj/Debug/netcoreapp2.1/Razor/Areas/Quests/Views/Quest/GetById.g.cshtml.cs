#pragma checksum "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665a2bc05edf9535643bc9b0f4e109a87bb71bc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Quests_Views_Quest_GetById), @"mvc.1.0.view", @"/Areas/Quests/Views/Quest/GetById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Quests/Views/Quest/GetById.cshtml", typeof(AspNetCore.Areas_Quests_Views_Quest_GetById))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665a2bc05edf9535643bc9b0f4e109a87bb71bc3", @"/Areas/Quests/Views/Quest/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c643a104a9585dc47e6da2b5e7d5f337fb9015", @"/Areas/Quests/Views/_ViewImports.cshtml")]
    public class Areas_Quests_Views_Quest_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestServiceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Vouchers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Voucher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendVoucher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(65, 156, true);
            WriteLiteral("\r\n<div class=\"container jumbotron my-4\">\r\n    <div class=\"row center-block\">\r\n        <div class=\"\">\r\n            <h4 class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(222, 10, false);
#line 10 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(232, 21, true);
            WriteLiteral("\r\n            </h4>\r\n");
            EndContext();
#line 12 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
              
                if (Model.Image != null)
                {
                    var base64 = Convert.ToBase64String(Model.Image);
                    var imgSrc = String.Format("data:image/gif;base64,{0}", base64);

#line default
#line hidden
            BeginContext(487, 82, true);
            WriteLiteral("                    <img class=\"center-block\" style=\"height: 300px; width: 400px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 569, "\"", 582, 1);
#line 17 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
WriteAttributeValue("", 575, imgSrc, 575, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(583, 10, true);
            WriteLiteral(" alt=\"\">\r\n");
            EndContext();
#line 18 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
                }
            

#line default
#line hidden
            BeginContext(627, 55, true);
            WriteLiteral("            <div class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(683, 27, false);
#line 21 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
           Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(710, 110, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"text-center\">\r\n                <h4>Дата на провежадане: </h4><p>");
            EndContext();
            BeginContext(821, 17, false);
#line 24 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
                                            Write(Model.DateOfQuest);

#line default
#line hidden
            EndContext();
            BeginContext(838, 110, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"text-center\">\r\n                <h4>Брой харесвания: </h4><p>");
            EndContext();
            BeginContext(949, 16, false);
#line 27 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
                                        Write(Model.NumOfLikes);

#line default
#line hidden
            EndContext();
            BeginContext(965, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 29 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(1048, 43, true);
            WriteLiteral("                <div class=\"text-center\">\r\n");
            EndContext();
#line 32 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
                       var data = new Dictionary<string, string>() { { "id", Model.Id.ToString() } }; 

#line default
#line hidden
            BeginContext(1196, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1216, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce2b6abd9914475ac840a749c1ef3ec", async() => {
                BeginContext(1351, 14, true);
                WriteLiteral("Изпрати ваучер");
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
#line 33 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
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
            BeginContext(1369, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 35 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1443, 43, true);
            WriteLiteral("                <div class=\"text-center\">\r\n");
            EndContext();
#line 39 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
                       var data = new Dictionary<string, string>() { { "id", Model.Id.ToString() } }; 

#line default
#line hidden
            BeginContext(1591, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1611, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31679d2a71aa47108474105a514ae916", async() => {
                BeginContext(1759, 111, true);
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Харесай\" class=\"btn btn-success\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1625, "/Quest/Like/", 1625, 12, true);
#line 40 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
AddHtmlAttributeValue("", 1637, Model.Id, 1637, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("@*asp-area=\"Quests\" asp-controller=\"Quest\" asp-action=\"LikedQuest\" asp-all-route-data=\"data\"*@", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1877, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 44 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Areas\Quests\Views\Quest\GetById.cshtml"
            }

#line default
#line hidden
            BeginContext(1918, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
