#pragma checksum "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31082e0226da636deafa9b72156f8597bfb413ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FilmTitles_Index), @"mvc.1.0.view", @"/Views/FilmTitles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FilmTitles/Index.cshtml", typeof(AspNetCore.Views_FilmTitles_Index))]
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
#line 1 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\_ViewImports.cshtml"
using dvdCollection;

#line default
#line hidden
#line 2 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\_ViewImports.cshtml"
using dvdCollection.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31082e0226da636deafa9b72156f8597bfb413ed", @"/Views/FilmTitles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7b755d793feaa88d7402e9f4871888f53be0058", @"/Views/_ViewImports.cshtml")]
    public class Views_FilmTitles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dvdCollection.Models.FilmTitles>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31082e0226da636deafa9b72156f8597bfb413ed4891", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 45, false);
#line 16 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmTitle));

#line default
#line hidden
            EndContext();
            BeginContext(300, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(356, 45, false);
#line 19 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmStory));

#line default
#line hidden
            EndContext();
            BeginContext(401, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(457, 50, false);
#line 22 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmRelaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(507, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(563, 48, false);
#line 25 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmDuration));

#line default
#line hidden
            EndContext();
            BeginContext(611, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(667, 54, false);
#line 28 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmAdditionalInfo));

#line default
#line hidden
            EndContext();
            BeginContext(721, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(777, 46, false);
#line 31 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmGenere));

#line default
#line hidden
            EndContext();
            BeginContext(823, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(879, 51, false);
#line 34 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmCertificate));

#line default
#line hidden
            EndContext();
            BeginContext(930, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1048, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1097, 44, false);
#line 43 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1197, 44, false);
#line 46 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmStory));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1297, 49, false);
#line 49 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmRelaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1402, 47, false);
#line 52 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmDuration));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1505, 53, false);
#line 55 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmAdditionalInfo));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1614, 55, false);
#line 58 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmGenere.GenreDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1725, 66, false);
#line 61 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmCertificate.FilmCertificate));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1846, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31082e0226da636deafa9b72156f8597bfb413ed13245", async() => {
                BeginContext(1900, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
                                       WriteLiteral(item.FilmTitleID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1908, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1928, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31082e0226da636deafa9b72156f8597bfb413ed15638", async() => {
                BeginContext(1985, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
                                          WriteLiteral(item.FilmTitleID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1996, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2016, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31082e0226da636deafa9b72156f8597bfb413ed18037", async() => {
                BeginContext(2072, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
                                         WriteLiteral(item.FilmTitleID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2082, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "c:\Users\hatzsen\Documents\UAZ\9noSemestre\desaplicacionesweb\desappnet\dvdCollectionv5\Views\FilmTitles\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2121, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<dvdCollection.Models.FilmTitles>> Html { get; private set; }
    }
}
#pragma warning restore 1591
