#pragma checksum "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87cccc0a21f8c1851a04992402dca8bd12040fc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_UserList), @"mvc.1.0.view", @"/Views/Roles/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/UserList.cshtml", typeof(AspNetCore.Views_Roles_UserList))]
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
#line 2 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
using System.Globalization;

#line default
#line hidden
#line 3 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cccc0a21f8c1851a04992402dca8bd12040fc6", @"/Views/Roles/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738d16b6889538c818c5e2982a9d0d1c555785ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyWebTest.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "edit_users_role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(149, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(155, 22, false);
#line 6 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
Write(Localizer["userslist"]);

#line default
#line hidden
            EndContext();
            BeginContext(177, 28, true);
            WriteLiteral("</h2>\n<table class=\"table\">\n");
            EndContext();
#line 8 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(244, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(274, 10, false);
#line 11 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(284, 39, true);
            WriteLiteral("</td>\n            <td>\n                ");
            EndContext();
            BeginContext(323, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87cccc0a21f8c1851a04992402dca8bd12040fc65791", async() => {
                BeginContext(414, 19, false);
#line 13 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
                                                                                                     Write(Localizer["access"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
                                                                                    WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(437, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 16 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
    }

#line default
#line hidden
            BeginContext(476, 10, true);
            WriteLiteral("</table>\n\n");
            EndContext();
            BeginContext(486, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87cccc0a21f8c1851a04992402dca8bd12040fc68849", async() => {
                BeginContext(508, 18, false);
#line 19 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\UserList.cshtml"
                Write(Localizer["roles"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(530, 1, true);
            WriteLiteral("\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyWebTest.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591