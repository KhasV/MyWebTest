#pragma checksum "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ecd02b246f44ef462dfe5e2715bbeadaaab2abf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserSetting), @"mvc.1.0.view", @"/Views/Users/UserSetting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/UserSetting.cshtml", typeof(AspNetCore.Views_Users_UserSetting))]
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
#line 3 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
using System.Globalization;

#line default
#line hidden
#line 4 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ecd02b246f44ef462dfe5e2715bbeadaaab2abf", @"/Views/Users/UserSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738d16b6889538c818c5e2982a9d0d1c555785ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_UserSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebTest.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "edit_user", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "change_password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "change_password_admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(137, 61, true);
            WriteLiteral("\n<table class=\"table\" id=\"body\">\n    <tbody>\n        <tr><th>");
            EndContext();
            BeginContext(199, 18, false);
#line 9 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
           Write(Localizer["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(217, 9, true);
            WriteLiteral("</th><th>");
            EndContext();
            BeginContext(227, 17, false);
#line 9 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                       Write(Localizer["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(244, 9, true);
            WriteLiteral("</th><th>");
            EndContext();
            BeginContext(254, 16, false);
#line 9 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                  Write(Localizer["age"]);

#line default
#line hidden
            EndContext();
            BeginContext(270, 57, true);
            WriteLiteral("</th></tr>\n                 <tr>\n                    <td>");
            EndContext();
            BeginContext(328, 11, false);
#line 11 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                   Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(339, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(370, 10, false);
#line 12 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(380, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(411, 9, false);
#line 13 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                   Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(420, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(475, 780, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ecd02b246f44ef462dfe5e2715bbeadaaab2abf8535", async() => {
                BeginContext(540, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(573, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ecd02b246f44ef462dfe5e2715bbeadaaab2abf8948", async() => {
                    BeginContext(655, 17, false);
#line 16 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                                                            Write(Localizer["edit"]);

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
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 16 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                                          WriteLiteral(Model.Id);

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
                BeginContext(676, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 17 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                 if (!User.IsInRole("admin"))
                                {

#line default
#line hidden
                BeginContext(773, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(809, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ecd02b246f44ef462dfe5e2715bbeadaaab2abf12223", async() => {
                    BeginContext(897, 24, false);
#line 19 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                                                                      Write(Localizer["change_pass"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                                                    WriteLiteral(Model.Id);

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
                BeginContext(925, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 20 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1031, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1067, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ecd02b246f44ef462dfe5e2715bbeadaaab2abf15537", async() => {
                    BeginContext(1161, 24, false);
#line 23 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                                                                            Write(Localizer["change_pass"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 23 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                                                                          WriteLiteral(Model.Id);

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
                BeginContext(1189, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 24 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                }

#line default
#line hidden
                BeginContext(1224, 24, true);
                WriteLiteral("                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\Varva\Desktop\DISC\IGI\MyWebTest\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Users\UserSetting.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1255, 73, true);
            WriteLiteral("\n                    </td>\n                  </tr>\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebTest.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
