#pragma checksum "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04254742f182456b079f6834238ec8e8fd20e697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ComparisonPlace), @"mvc.1.0.view", @"/Views/Home/_ComparisonPlace.cshtml")]
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
#line 1 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\_ViewImports.cshtml"
using RecruitmentTaskNr1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\_ViewImports.cshtml"
using RecruitmentTaskNr1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04254742f182456b079f6834238ec8e8fd20e697", @"/Views/Home/_ComparisonPlace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5544d4b52063bf30fde5aac913d8472bc8677d1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ComparisonPlace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StringComparationVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"partial-div\">\r\n    <div class=\"input-div\">\r\n        <input id=\"FirstStr\" type=\"text\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 136, "\"", 144, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"First String\" required />\r\n        <div class=\"output\">\r\n");
#nullable restore
#line 6 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
             if (Model.Comparison.Count > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"p-out\">OutPut for: <span class=\"red\">");
#nullable restore
#line 8 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                          Write(Model.Comparison[0].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 9 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                if (Model.Comparison[0].CapitalLetters.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"info\">\r\n                        Indexes of Capital Letters:\r\n");
#nullable restore
#line 13 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                         foreach (var capL in Model.Comparison[0].CapitalLetters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"red\">");
#nullable restore
#line 15 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                         Write(capL);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 16 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 18 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                }
                if (Model.Comparison[0].LowerLetters.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"info\">\r\n                        Indexes of Lower Letters:\r\n");
#nullable restore
#line 23 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                         foreach (var capL in Model.Comparison[0].LowerLetters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"red\">");
#nullable restore
#line 25 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                         Write(capL);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 26 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 28 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"info\">Palindrom: <span class=\"red\">");
#nullable restore
#line 29 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                        Write(Model.Comparison[0].IsPalindrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  </p>\r\n                <p class=\"info\">Length:<span class=\"red\">");
#nullable restore
#line 30 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                    Write(Model.Comparison[0].Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  </p>\r\n                <p class=\"info\">Vowels:<span class=\"red\">");
#nullable restore
#line 31 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                    Write(Model.Comparison[0].Vowels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  </p>\r\n                <p class=\"info\">The most common character: <span class=\"red\">a - 3</span>  </p>\r\n                <div class=\"info\">\r\n                    Details:\r\n");
#nullable restore
#line 35 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                     foreach (var item in Model.Comparison[0].LettersTypes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"info p-details\">");
#nullable restore
#line 37 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                             Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <span class=\"red\">");
#nullable restore
#line 37 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                                           Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n");
#nullable restore
#line 38 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 40 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"input-div\">\r\n        <input id=\"SecondStr\" type=\"text\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2067, "\"", 2075, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Second String\" required />\r\n        <div class=\"output\">\r\n");
#nullable restore
#line 46 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
             if (Model.Comparison.Count > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"p-out\">OutPut for: <span class=\"red\">");
#nullable restore
#line 48 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                          Write(Model.Comparison[1].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 49 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                if (Model.Comparison[1].CapitalLetters.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"info\">\r\n                        Indexes of Capital Letters:\r\n");
#nullable restore
#line 53 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                         foreach (var capL in Model.Comparison[1].CapitalLetters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"red\">");
#nullable restore
#line 55 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                         Write(capL);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 56 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 58 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                }
                if (Model.Comparison[1].LowerLetters.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"info\">\r\n                        Indexes of Lower Letters:\r\n");
#nullable restore
#line 63 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                         foreach (var capL in Model.Comparison[1].LowerLetters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"red\">");
#nullable restore
#line 65 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                         Write(capL);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 66 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"info\">Palindrom: <span class=\"red\">");
#nullable restore
#line 69 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                        Write(Model.Comparison[1].IsPalindrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  </p>\r\n                <p class=\"info\">Length:<span class=\"red\">");
#nullable restore
#line 70 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                    Write(Model.Comparison[1].Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  </p>\r\n                <p class=\"info\">Vowels:<span class=\"red\">");
#nullable restore
#line 71 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                    Write(Model.Comparison[1].Vowels);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  </p>\r\n                <p class=\"info\">The most common character: <span class=\"red\">a - 3</span>  </p>\r\n                <div class=\"info\">\r\n                    Details:\r\n");
#nullable restore
#line 75 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                     foreach (var item in Model.Comparison[1].LettersTypes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"info p-details\">");
#nullable restore
#line 77 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                             Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <span class=\"red\">");
#nullable restore
#line 77 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                                                           Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </p>\r\n");
#nullable restore
#line 78 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 80 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"kind-of-footer\">\r\n");
#nullable restore
#line 85 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
     if (Model.Comparison.Count > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p id=\"Anagram-footer\">\r\n            Anagram:     <span class=\"red\">");
#nullable restore
#line 88 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                      Write(Model.Anagrams);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>    \r\n        </p>\r\n        <p id=\"Length-footer\">\r\n            Length Diffrence: <span class=\"red\"> ");
#nullable restore
#line 91 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
                                            Write(Model.LengthDiffrence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </p>\r\n");
#nullable restore
#line 93 "C:\Users\barte\source\repos\RecruitmentTaskNr1\RecruitmentTaskNr1\Views\Home\_ComparisonPlace.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StringComparationVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
