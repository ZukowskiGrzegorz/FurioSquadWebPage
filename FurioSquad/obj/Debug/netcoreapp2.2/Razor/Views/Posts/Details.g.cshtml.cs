#pragma checksum "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97ecaca5c2cf58c2ea11d8c770842a3d3a009a5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
#line 1 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\_ViewImports.cshtml"
using FurioSquad;

#line default
#line hidden
#line 2 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\_ViewImports.cshtml"
using FurioSquad.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97ecaca5c2cf58c2ea11d8c770842a3d3a009a5b", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d3309ca6c7546ee6816f0856d00a7b86f5fc9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FurioSquad.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 111, true);
            WriteLiteral("\r\n<!--<div>\r\n    <h4>Post</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(212, 41, false);
#line 14 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(253, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(317, 37, false);
#line 17 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(354, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(417, 43, false);
#line 20 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(460, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(524, 39, false);
#line 23 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(563, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(626, 44, false);
#line 26 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostDate));

#line default
#line hidden
            EndContext();
            BeginContext(670, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(734, 40, false);
#line 29 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostDate));

#line default
#line hidden
            EndContext();
            BeginContext(774, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(837, 46, false);
#line 32 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EditedDate));

#line default
#line hidden
            EndContext();
            BeginContext(883, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(947, 42, false);
#line 35 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.EditedDate));

#line default
#line hidden
            EndContext();
            BeginContext(989, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1052, 45, false);
#line 38 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LikeCount));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1161, 41, false);
#line 41 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.LikeCount));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1265, 40, false);
#line 44 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1369, 41, false);
#line 47 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Nick));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 72, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n    -->\r\n\r\n<div>\r\n    \r\n        <h1>");
            EndContext();
            BeginContext(1483, 37, false);
#line 55 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 25, true);
            WriteLiteral("</h1>\r\n        <p><small>");
            EndContext();
            BeginContext(1546, 40, false);
#line 56 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
             Write(Html.DisplayFor(model => model.PostDate));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 12, true);
            WriteLiteral("/ Edytowany ");
            EndContext();
            BeginContext(1599, 42, false);
#line 56 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
                                                                  Write(Html.DisplayFor(model => model.EditedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 91, true);
            WriteLiteral("</small></p>\r\n        <div class=\"vl\">\r\n            <article class=\"col-md-9 text-justify\">");
            EndContext();
            BeginContext(1733, 39, false);
#line 58 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 63, true);
            WriteLiteral("</article>\r\n        </div>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1835, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97ecaca5c2cf58c2ea11d8c770842a3d3a009a5b11874", async() => {
                BeginContext(1885, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Grzegorz Żukowski\source\repos\FurioSquad\FurioSquad\Views\Posts\Details.cshtml"
                                       WriteLiteral(Model.PostId);

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
            BeginContext(1893, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1913, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97ecaca5c2cf58c2ea11d8c770842a3d3a009a5b14234", async() => {
                BeginContext(1935, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1951, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1971, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97ecaca5c2cf58c2ea11d8c770842a3d3a009a5b15633", async() => {
                BeginContext(2006, 15, true);
                WriteLiteral("Dodaj komentarz");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2025, 44, true);
            WriteLiteral("\r\n            </div>\r\n        \r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FurioSquad.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
