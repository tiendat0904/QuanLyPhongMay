#pragma checksum "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Employee\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7938425127f5c4057d8f8993fdb2cdab07a73916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Add), @"mvc.1.0.view", @"/Views/Employee/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Add.cshtml", typeof(AspNetCore.Views_Employee_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7938425127f5c4057d8f8993fdb2cdab07a73916", @"/Views/Employee/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d203abe104bfc70dc4a09c464acd95446a2328f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 738, true);
            WriteLiteral(@"<div class=""main-content"">
    <section class=""section"">
        <h1 class=""section-header"">
            <div>Manage Employees</div>
        </h1>
        <div class=""section-body"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-12"">
                    <div class=""card"">
                        <div class=""row"">
                            <div class=""col-12 col-md-12 col-lg-12"">
                                <div class=""login-brand"">
                                    Create a new Employee
                                </div>
                                <div class=""card card-primary"">
                                    <div class=""card-body"">
                                        ");
            EndContext();
            BeginContext(738, 4539, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938425127f5c4057d8f8993fdb2cdab07a739166042", async() => {
                BeginContext(797, 1303, true);
                WriteLiteral(@"
                                            <div class=""form-group"">
                                                <label for=""Name"">Employee Name</label>
                                                <input id=""Name"" type=""text"" class=""form-control"" name=""Name"" tabindex=""1"" autofocus>
                                                <span target=""Name"" class=""error""></span>
                                            </div>
                                            <div id=""flatpickrcontainer"" class=""form-group"">
                                                <label for=""Dob"">Dob</label>
                                                <input id=""Dob"" type=""date"" class=""form-control"" name=""Dob"" tabindex=""1"">
                                                <span target=""Dob"" class=""error""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""Gender"">
                     ");
                WriteLiteral(@"                               Employee Gender
                                                </label>
                                                <select id=""Gender"" name=""Gender"" class=""dropdown-item-text"" tabindex=""2"">
                                                    ");
                EndContext();
                BeginContext(2100, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938425127f5c4057d8f8993fdb2cdab07a739167813", async() => {
                    BeginContext(2118, 4, true);
                    WriteLiteral("Male");
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
                BeginContext(2131, 53, true);
                WriteLiteral("\n                                                    ");
                EndContext();
                BeginContext(2184, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938425127f5c4057d8f8993fdb2cdab07a739169326", async() => {
                    BeginContext(2202, 6, true);
                    WriteLiteral("Female");
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
                BeginContext(2217, 1973, true);
                WriteLiteral(@"
                                                </select>
                                                <span target=""Status"" class=""error""></span>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""PhoneNumber"">PhoneNumber</label>
                                                <input id=""PhoneNumber"" type=""text"" class=""form-control"" name=""PhoneNumber"" tabindex=""1"">
                                                <span target=""PhoneNumber"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""ComputerRoom"">Computer Room</label>
                                                <select id=""ComputerRoom"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""ComputerRoom""");
                WriteLiteral(@" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""Province"">Province Name</label>
                                                <select id=""Province"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""Province"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""Status"">
                                                    Employee Status
                                                </label>
                                                <select id=""Status"" name=""Status"" class=""dropdown-item-text"" tabindex=""2"">
                                                    ");
                EndContext();
                BeginContext(4190, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938425127f5c4057d8f8993fdb2cdab07a7391612865", async() => {
                    BeginContext(4208, 6, true);
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
                BeginContext(4223, 53, true);
                WriteLiteral("\n                                                    ");
                EndContext();
                BeginContext(4276, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938425127f5c4057d8f8993fdb2cdab07a7391614381", async() => {
                    BeginContext(4294, 8, true);
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
                BeginContext(4311, 959, true);
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
            BeginContext(5277, 289, true);
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
                BeginContext(5583, 926, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {            
           
            masterData.GetComputerRoomSelect2Data(""ComputerRoom"");
            masterData.GetProvinceSelect2Data(""Province"");

            $(""#add-form"").on('submit', function (event) {
                event.preventDefault();
                $(""#add-form-btn"").attr(""disabled"", true);
                var dataModel = {
                    Name: $(""#Name"").val(),
                    Dob: $(""#Dob"").val(),
                    Gender: $(""#Gender"").val(),
                    Phone: $(""Phone"").val(),
                    Status: $(""Status"").val(),
                    FK_ProvinceId: $(""#Province"").select2('val'),
                    FK_ComputerRoomId: $(""#ComputerRoom"").select2('val'),
                    Status: $(""#Status"").val()
                }
                if (validateInput()) {
                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(6510, 29, false);
#line 110 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Employee\Add.cshtml"
                         Write(Url.Action("Add", "Employee"));

#line default
#line hidden
                EndContext();
                BeginContext(6539, 541, true);
                WriteLiteral(@"',
                        data: dataModel,
                        type: 'POST',
                        success: function (respone) {
                            if (respone.errorCode != 0) {
                                $('span[target=""ErrorMessage""]').text(respone.errorMessage);
                            } else {
                                $('span[target=""ErrorMessage""]').text(""Add Employee successfully"");
                                setTimeout(function () {
                                    window.location.href = '");
                EndContext();
                BeginContext(7081, 91, false);
#line 119 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Employee\Add.cshtml"
                                                       Write(Html.Raw(@Url.Action("EmployeePaging", "Employee", new { PAGE_SIZE = 10, PAGE_INDEX = 1 })));

#line default
#line hidden
                EndContext();
                BeginContext(7172, 851, true);
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

            $(""#cancel-btn"").click(function (event) {
            event.preventDefault();
            $.confirm({
                title: 'Are you want to cancel?',
                useBootstrap: false,
                theme: 'material',
                type: 'red',
                boxWidth: '500px',
                buttons: {
                    confirm: {
                        text: 'Yes',
                        action: function () {
                            window.location.href = '");
                EndContext();
                BeginContext(8024, 90, false);
#line 145 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Employee\Add.cshtml"
                                               Write(Html.Raw(@Url.Action("EmployeePaging", "Employee", new { PAGE_SIZE = 10, PAGE_INDEX = 1})));

#line default
#line hidden
                EndContext();
                BeginContext(8114, 623, true);
                WriteLiteral(@"';
                        }
                    },
                    cancel: {
                        text: 'No',
                        keys: ['esc'],
                        action: function () {
                        }
                    },
                }
                });
            })
       })
       function validateInput() {
           var EmployeeName = $(""#Name"").val();
           if (EmployeeName == '' || EmployeeName == null) {
               $('span[target=""Name""]').text('Employee Name is required');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
