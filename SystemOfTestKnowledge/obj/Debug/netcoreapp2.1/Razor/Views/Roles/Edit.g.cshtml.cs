#pragma checksum "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52f890cedb36b8fef213a17a92c35d31ccfb30bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Edit.cshtml", typeof(AspNetCore.Views_Roles_Edit))]
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
#line 1 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\_ViewImports.cshtml"
using SystemOfTestKnowledge;

#line default
#line hidden
#line 2 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\_ViewImports.cshtml"
using SystemOfTestKnowledge.Models;

#line default
#line hidden
#line 2 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f890cedb36b8fef213a17a92c35d31ccfb30bc", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47858fcf7e6d3c9d632c72c5eb1e13e0ade22527", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemOfTestKnowledge.ViewModels.ChangeRoleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "edit_users_role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(101, 39, true);
            WriteLiteral("\r\n<h2>Изменение ролей для пользователя ");
            EndContext();
            BeginContext(141, 15, false);
#line 5 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
                                Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(156, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(165, 492, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a89a69cba07e45438ec4af0f248032f1", async() => {
                BeginContext(213, 40, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 253, "\"", 274, 1);
#line 8 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 261, Model.UserId, 261, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(275, 35, true);
                WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n");
                EndContext();
#line 10 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
                BeginContext(377, 47, true);
                WriteLiteral("            <input type=\"checkbox\" name=\"roles\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 424, "\"", 442, 1);
#line 12 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 432, role.Name, 432, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(443, 21, true);
                WriteLiteral("\r\n                   ");
                EndContext();
                BeginContext(466, 64, false);
#line 13 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
               Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(531, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(535, 9, false);
#line 13 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
                                                                                    Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(544, 9, true);
                WriteLiteral(" <br />\r\n");
                EndContext();
#line 14 "E:\ИГИ-2019\SystemOfTestKnowledge\SystemOfTestKnowledge\Views\Roles\Edit.cshtml"
            }

#line default
#line hidden
                BeginContext(568, 82, true);
                WriteLiteral("    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Сохранить</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemOfTestKnowledge.ViewModels.ChangeRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
