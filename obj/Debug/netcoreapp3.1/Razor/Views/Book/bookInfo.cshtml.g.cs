#pragma checksum "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13da866b9ebdfa14902215163d5045e391707a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_bookInfo), @"mvc.1.0.view", @"/Views/Book/bookInfo.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13da866b9ebdfa14902215163d5045e391707a2e", @"/Views/Book/bookInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_bookInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    tr\r\n    {\r\n        line-height: 7;\r\n        \r\n    }\r\n    tr:hover \r\n    {\r\n        background-color: #f5f5f5;\r\n    }\r\n</style>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Book Information</h1>\r\n    <table>\r\n");
            WriteLiteral("            <tr>\r\n                <th>Title: </th>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.bookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Thumbnail: </th>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 483, "\"", 507, 1);
#nullable restore
#line 25 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
WriteAttributeValue("", 489, ViewBag.thumbnail, 489, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n            </tr>\r\n            <tr>\r\n                <th>Authors: </th>\r\n");
#nullable restore
#line 29 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
                 for (var i = 0; i < @ViewBag.authors; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
                   Write(ViewBag.authors[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n            <tr>\r\n                <th>Publisher: </th>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Published Date: </th>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.publishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr style=\"line-height: normal;\">\r\n                <th>Description: </th>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\user\Desktop\Vina-Girdhar-Assignment1\Views\Book\bookInfo.cshtml"
               Write(ViewBag.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
            WriteLiteral("    </table>\r\n</div>\r\n");
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
