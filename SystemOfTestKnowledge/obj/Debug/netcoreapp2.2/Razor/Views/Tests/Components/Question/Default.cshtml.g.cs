#pragma checksum "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c42869aff7e47b097fcbb90bb87a7f7547e98871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_Components_Question_Default), @"mvc.1.0.view", @"/Views/Tests/Components/Question/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tests/Components/Question/Default.cshtml", typeof(AspNetCore.Views_Tests_Components_Question_Default))]
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
#line 1 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\_ViewImports.cshtml"
using MyWebTest;

#line default
#line hidden
#line 2 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\_ViewImports.cshtml"
using MyWebTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c42869aff7e47b097fcbb90bb87a7f7547e98871", @"/Views/Tests/Components/Question/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738d16b6889538c818c5e2982a9d0d1c555785ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Tests_Components_Question_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebTest.ViewModels.QuestionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-default "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 38, true);
            WriteLiteral("\n<tr>\n    <td><p id=\"just-line-break\">");
            EndContext();
            BeginContext(85, 22, false);
#line 4 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
                           Write(Model.Index.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(107, 3, true);
            WriteLiteral(" . ");
            EndContext();
            BeginContext(111, 10, false);
#line 4 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
                                                     Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(121, 10, true);
            WriteLiteral("</p></td>\n");
            EndContext();
#line 5 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
       Model.Index++; 

#line default
#line hidden
            BeginContext(155, 25, true);
            WriteLiteral("</tr>\n\n\n<table>\n    <tr>\n");
            EndContext();
#line 11 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
         foreach (var answer in Model.AnswerOptions.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {

#line default
#line hidden
            BeginContext(293, 46, true);
            WriteLiteral("            <td width=\"80px\">\n                ");
            EndContext();
            BeginContext(339, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c42869aff7e47b097fcbb90bb87a7f7547e988716065", async() => {
                BeginContext(571, 6, false);
#line 14 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
                                                                                                                                                                                                                                                  Write(answer);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 14 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = new Dictionary<string, string> { { "id", Model.Id.ToString() }, { "answer", answer }, { "correctAnswer", Model.CorrectAnswer} } ;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 19, true);
            WriteLiteral("\n            </td>\n");
            EndContext();
#line 16 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Tests\Components\Question\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(610, 51, true);
            WriteLiteral("    </tr>\n</table>\n<p><span id=\"status\"></span></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebTest.ViewModels.QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
