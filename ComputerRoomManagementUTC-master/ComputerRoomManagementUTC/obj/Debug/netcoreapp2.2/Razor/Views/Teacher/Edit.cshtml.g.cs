#pragma checksum "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffbce849694666eb952b1d419bcff4e0736ddc51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Edit), @"mvc.1.0.view", @"/Views/Teacher/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Edit.cshtml", typeof(AspNetCore.Views_Teacher_Edit))]
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
#line 1 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\_ViewImports.cshtml"
using ComputerRoomManagementUTC;

#line default
#line hidden
#line 2 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\_ViewImports.cshtml"
using ComputerRoomManagementUTC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbce849694666eb952b1d419bcff4e0736ddc51", @"/Views/Teacher/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d203abe104bfc70dc4a09c464acd95446a2328f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Common.Entity.Models.Teacher.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 526, true);
            WriteLiteral(@"<div class=""main-content"">
    <section class=""section"">
        <h1 class=""section-header"">
            <div>Manage Computers</div>
        </h1>
        <div class=""section-body"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-12"">
                    <div class=""card"">
                        <div class=""row"">
                            <div class=""col-12 col-md-12 col-lg-12"">
                                <div class=""login-brand"">
                                    Edit Teacher ");
            EndContext();
            BeginContext(571, 10, false);
#line 14 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(581, 204, true);
            WriteLiteral("\n                                </div>\n                                <div class=\"card card-primary\">\n                                    <div class=\"card-body\">\n                                        ");
            EndContext();
            BeginContext(785, 2577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbce849694666eb952b1d419bcff4e0736ddc516479", async() => {
                BeginContext(844, 45, true);
                WriteLiteral("\n                                            ");
                EndContext();
                BeginContext(890, 38, false);
#line 19 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml"
                                       Write(Html.HiddenFor(teacher => Model.PK_Id));

#line default
#line hidden
                EndContext();
                BeginContext(928, 289, true);
                WriteLiteral(@"
                                            <div class=""form-group"">
                                                <label for=""Name"">Teacher Name</label>
                                                <input id=""Name"" type=""text"" class=""form-control"" name=""Name"" tabindex=""1"" autofocus");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1217, "\"", 1236, 1);
#line 22 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml"
WriteAttributeValue("", 1225, Model.Name, 1225, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1237, 442, true);
                WriteLiteral(@">
                                                <span target=""Name"" class=""error""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""Phone"">Teacher Phone Number</label>
                                                <input id=""Phone"" type=""text"" class=""form-control"" name=""Phone"" tabindex=""1"" autofocus");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1679, "\"", 1705, 1);
#line 27 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml"
WriteAttributeValue("", 1687, Model.PhoneNumber, 1687, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1706, 569, true);
                WriteLiteral(@">
                                                <span target=""Phone"" class=""error""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""Status"">
                                                    Teacher Status
                                                </label>
                                                <select name=""Status"" class=""dropdown-item-text"" tabindex=""2"">
                                                    ");
                EndContext();
                BeginContext(2275, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbce849694666eb952b1d419bcff4e0736ddc519654", async() => {
                    BeginContext(2293, 6, true);
                    WriteLiteral("Active");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2308, 53, true);
                WriteLiteral("\n                                                    ");
                EndContext();
                BeginContext(2361, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffbce849694666eb952b1d419bcff4e0736ddc5111169", async() => {
                    BeginContext(2379, 8, true);
                    WriteLiteral("Deactive");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2396, 959, true);
                WriteLiteral(@"
                                                </select>
                                                <span target=""Status"" class=""error""></span>
                                            </div>
                                            <span target=""ErrorMessage"" class=""error""></span>
                                            <div class=""form-group"">
                                                <button id=""submit-btn"" type=""submit"" class=""btn btn-primary btn-block "" tabindex=""3"">
                                                    Submit
                                                </button>
                                                <button id=""cancel-btn"" type=""submit"" class=""btn btn-primary btn-block"" tabindex=""4"">
                                                    Cancel
                                                </button>
                                            </div>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3362, 257, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3636, 307, true);
                WriteLiteral(@"
    <script>
       $(document).ready(function () {
            $(""#add-form"").on('submit', function (event) {
                event.preventDefault();
                $(""#submit-btn"").attr(""disabled"", true);
                if (validateInput()) {
                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(3944, 29, false);
#line 70 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml"
                         Write(Url.Action("Edit", "Teacher"));

#line default
#line hidden
                EndContext();
                BeginContext(3973, 557, true);
                WriteLiteral(@"',
                        data: $(""#add-form"").serialize(),
                        type: 'POST',
                        success: function (respone) {
                            if (respone.errorCode != 0) {
                                $('span[target=""ErrorMessage""]').text(respone.errorMessage);
                            } else {
                                $('span[target=""ErrorMessage""]').text(""Add Teacher successfully"");
                                setTimeout(function () {
                                    window.location.href = '");
                EndContext();
                BeginContext(4531, 89, false);
#line 79 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\Edit.cshtml"
                                                       Write(Html.Raw(@Url.Action("TeacherPaging", "Teacher", new { PAGE_SIZE = 10, PAGE_INDEX = 1 })));

#line default
#line hidden
                EndContext();
                BeginContext(4620, 918, true);
                WriteLiteral(@"';
                                }, 1000)
                            }
                        },
                        error: function (error) {
                            console.log(error);
                        },
                        complete: function () {

                        }
                    })
                }
            })
       })
       function validateInput() {
           var teacherName = $(""#Name"").val();
           if (teacherName == '' || teacherName == null) {
               $('span[target=""Name""]').text('Teacher Name is required');
               return false;
           };
           var TeacherPhoneNumber = $(""#Phone"").val();
           if (TeacherPhoneNumber == '' || TeacherPhoneNumber == null) {
               $('span[target=""Phone""]').text('Teacher Phone is required');
               return false;
           };
           return true;
       }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Common.Entity.Models.Teacher.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591