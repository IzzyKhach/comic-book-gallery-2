#pragma checksum "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6033f39700da849b32e3699a85d876b8945659"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComicBooks_Detail), @"mvc.1.0.view", @"/Views/ComicBooks/Detail.cshtml")]
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
#line 1 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\_ViewImports.cshtml"
using Commic_Book_Gallery_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\_ViewImports.cshtml"
using Commic_Book_Gallery_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6033f39700da849b32e3699a85d876b8945659", @"/Views/ComicBooks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa5a1d2fe1b27c9b0185bdc5475afae316146fe", @"/Views/_ViewImports.cshtml")]
    public class Views_ComicBooks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Commic_Book_Gallery_2.Models.ComicBook>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml"; //Layout = null;
    ViewBag.Title = Model.DisplayText;

    //var seriesTitle = "The amazing Spider-Man";
    //var issueNumber = 700;
    //var description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
    //var artists = new string[]
    //{
    //    "Script: Dan Slott",
    //    "Pencils: Humberto Ramos",
    //    "Inks: Victor Olazaba",
    //    "Colors: Edgar Delgado",
    //    "Letters: Chris Eliopoulos"
    //};

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 34 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
Write(Model.DisplayText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"well\">\r\n            <h5><label>Series Title:</label> ");
#nullable restore
#line 39 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                                        Write(Model.SeriesTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5><label>Issue #:</label> ");
#nullable restore
#line 40 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                                   Write(Model.IssueNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5><label>Favorite:</label> ");
#nullable restore
#line 41 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                                     Write(Model.Favorite ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 42 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
             if (Model.Artists.Length > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>Artists</h5>\r\n                <div>\r\n                    <ul>\r\n");
#nullable restore
#line 47 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                         foreach (var artist in Model.Artists)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 49 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                           Write(artist.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 49 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                                         Write(artist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 50 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <h5>Description</h5>
        <p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>
    </div>
    <div class=""col-md-6"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e6033f39700da849b32e3699a85d876b89456598454", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1984, "~/images/", 1984, 9, true);
#nullable restore
#line 59 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
AddHtmlAttributeValue("", 1993, Model.CoverImageFileName, 1993, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "C:\Users\Israel HP\source\repos\IzzyKhach\comic-book-gallery-2\src\Commic-Book-Gallery-2\Commic-Book-Gallery-2\Views\ComicBooks\Detail.cshtml"
AddHtmlAttributeValue("", 2039, Model.DisplayText, 2039, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Commic_Book_Gallery_2.Models.ComicBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
