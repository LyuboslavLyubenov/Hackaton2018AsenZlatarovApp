#pragma checksum "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74135639f7d1dadd5cc1697d7b6114be709beb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\_ViewImports.cshtml"
using HakatonApp.Web;

#line default
#line hidden
#line 2 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\_ViewImports.cshtml"
using HakatonApp.Web.Models;

#line default
#line hidden
#line 3 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\_ViewImports.cshtml"
using HakatonApp.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74135639f7d1dadd5cc1697d7b6114be709beb6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d899d16deb36586f2e5abf2a8d2371c619531adc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
 if (TempData.ContainsKey("dangerInfo"))
{

#line default
#line hidden
            BeginContext(70, 36, true);
            WriteLiteral("    <div class=\"alert alert-danger\">");
            EndContext();
            BeginContext(107, 22, false);
#line 5 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
                               Write(TempData["dangerInfo"]);

#line default
#line hidden
            EndContext();
            BeginContext(129, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 6 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
}
else if(TempData.ContainsKey("succesInfo"))
{

#line default
#line hidden
            BeginContext(188, 37, true);
            WriteLiteral("    <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(226, 22, false);
#line 9 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
                                Write(TempData["succesInfo"]);

#line default
#line hidden
            EndContext();
            BeginContext(248, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 10 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(259, 72, true);
            WriteLiteral("\r\n<div id=\"carousel\" style=\"box-shadow: inset 0 0 rgba(0, 0, 0, 0.2)\">\r\n");
            EndContext();
#line 13 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
     foreach (var sliderItem in Model.SliderItems)
    {

#line default
#line hidden
            BeginContext(390, 31, true);
            WriteLiteral("        <div>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 421, "\"", 448, 1);
#line 16 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 427, sliderItem.ImagePath, 427, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(449, 104, true);
            WriteLiteral(" style=\"width: 100%; height: 400px; box-shadow: inset 0 0 10px rgba(0, 0, 0, 0.2);\" />\r\n        </div>\r\n");
            EndContext();
#line 18 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(560, 732, true);
            WriteLiteral(@"</div>
<div id=""second_menu"" style=""width: 100%; display: flex; justify-content: space-around; background-color: #CCCCCC; font-size: 16pt; box-shadow: 0 1px 10px 0px rgba(0, 0, 0, 0.6)"">
    <div style=""margin: 10px;""><button href=""Current"" style=""border: 0; background-color: transparent;"">Някакви хубави инициативи</button></div>
    <div style=""margin: 10px;""><button href="""" style=""border: 0; background-color: transparent;"">Още по хубави</button></div>
    <div style=""margin: 10px;""><button href=""Archive"" style=""border: 0; background-color: transparent;"">Най хубавите инициативи</button></div>
</div>
<div id=""Current"" class=""second-content"" style=""display: flex; flex-direction: row; flex-wrap: wrap; display: flex"">
");
            EndContext();
#line 26 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
     for (var i = 0; i < Model.RecentInitiatives.Length; i++)
    {

#line default
#line hidden
            BeginContext(1362, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1374, "\"", 1460, 7);
            WriteAttributeValue("", 1382, "margin-top:", 1382, 11, true);
#line 28 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1393, i < 3 ? "50px" : "35px", 1394, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 1420, ";", 1420, 1, true);
            WriteAttributeValue(" ", 1421, "margin-left:", 1422, 13, true);
            WriteAttributeValue(" ", 1434, "20px;", 1435, 6, true);
            WriteAttributeValue(" ", 1440, "margin-right:", 1441, 14, true);
            WriteAttributeValue(" ", 1454, "20px;", 1455, 6, true);
            EndWriteAttribute();
            BeginContext(1461, 174, true);
            WriteLiteral(">\r\n            <div>\r\n                <div class=\"content-box\" style=\"width: 380px; height: 360px; box-shadow: 0px 0px 40px 0px rgba(48,48,48,0.2)\">\r\n                    <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1635, "\"", 1757, 10);
            WriteAttributeValue("", 1643, "width:", 1643, 6, true);
            WriteAttributeValue(" ", 1649, "100%;", 1650, 6, true);
            WriteAttributeValue(" ", 1655, "height:", 1656, 8, true);
            WriteAttributeValue(" ", 1663, "100%;", 1664, 6, true);
            WriteAttributeValue(" ", 1669, "background-image:", 1670, 18, true);
            WriteAttributeValue(" ", 1687, "url(\'", 1688, 6, true);
#line 31 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1693, Model.RecentInitiatives[i].ImagePath, 1693, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 1730, "\');", 1730, 3, true);
            WriteAttributeValue(" ", 1733, "background-size:", 1734, 17, true);
            WriteAttributeValue(" ", 1750, "cover;", 1751, 7, true);
            EndWriteAttribute();
            BeginContext(1758, 398, true);
            WriteLiteral(@">
                    </div>
                    <div style=""position: relative; width: 100%; height: 100%; top: -100%;"">
                        <div style=""display: block; position: relative; top: 50%; transform: translateY(-50%); width: 100%;"">
                            <div style=""margin-left: 50%; transform: translateX(-50%); color: white; text-shadow: 1px 1px 5px rgba(0, 0, 0, 0.5)"">");
            EndContext();
            BeginContext(2157, 32, false);
#line 35 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
                                                                                                                                             Write(Model.RecentInitiatives[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2189, 309, true);
            WriteLiteral(@"</div>
                            <button style=""margin-left: 50%; transform: translateX(-50%); background-color: #CCCCCC; border: 0; width: 190px; margin-top: 15px;"">Включи се</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 42 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2505, 126, true);
            WriteLiteral("</div>\r\n<div id=\"Archive\" class=\"second-content\" style=\"display: flex; flex-direction: row; flex-wrap: wrap; display: none\">\r\n");
            EndContext();
#line 45 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
     for (var i = 0; i < Model.ArchivedInitiatives.Length; i++)
    {

#line default
#line hidden
            BeginContext(2703, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2715, "\"", 2801, 7);
            WriteAttributeValue("", 2723, "margin-top:", 2723, 11, true);
#line 47 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2734, i < 3 ? "50px" : "35px", 2735, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 2761, ";", 2761, 1, true);
            WriteAttributeValue(" ", 2762, "margin-left:", 2763, 13, true);
            WriteAttributeValue(" ", 2775, "20px;", 2776, 6, true);
            WriteAttributeValue(" ", 2781, "margin-right:", 2782, 14, true);
            WriteAttributeValue(" ", 2795, "20px;", 2796, 6, true);
            EndWriteAttribute();
            BeginContext(2802, 174, true);
            WriteLiteral(">\r\n            <div>\r\n                <div class=\"content-box\" style=\"width: 380px; height: 360px; box-shadow: 0px 0px 40px 0px rgba(48,48,48,0.2)\">\r\n                    <div");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2976, "\"", 3100, 10);
            WriteAttributeValue("", 2984, "width:", 2984, 6, true);
            WriteAttributeValue(" ", 2990, "100%;", 2991, 6, true);
            WriteAttributeValue(" ", 2996, "height:", 2997, 8, true);
            WriteAttributeValue(" ", 3004, "100%;", 3005, 6, true);
            WriteAttributeValue(" ", 3010, "background-image:", 3011, 18, true);
            WriteAttributeValue(" ", 3028, "url(\'", 3029, 6, true);
#line 50 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3034, Model.ArchivedInitiatives[i].ImagePath, 3034, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 3073, "\');", 3073, 3, true);
            WriteAttributeValue(" ", 3076, "background-size:", 3077, 17, true);
            WriteAttributeValue(" ", 3093, "cover;", 3094, 7, true);
            EndWriteAttribute();
            BeginContext(3101, 398, true);
            WriteLiteral(@">
                    </div>
                    <div style=""position: relative; width: 100%; height: 100%; top: -100%;"">
                        <div style=""display: block; position: relative; top: 50%; transform: translateY(-50%); width: 100%;"">
                            <div style=""margin-left: 50%; transform: translateX(-50%); color: white; text-shadow: 1px 1px 5px rgba(0, 0, 0, 0.5)"">");
            EndContext();
            BeginContext(3500, 34, false);
#line 54 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
                                                                                                                                             Write(Model.ArchivedInitiatives[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(3534, 309, true);
            WriteLiteral(@"</div>
                            <button style=""margin-left: 50%; transform: translateX(-50%); background-color: #CCCCCC; border: 0; width: 190px; margin-top: 15px;"">Включи се</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 61 "D:\Projects\GitRepos\Hackaton2018AsenZlatarovApp\HakatonApp.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3850, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
