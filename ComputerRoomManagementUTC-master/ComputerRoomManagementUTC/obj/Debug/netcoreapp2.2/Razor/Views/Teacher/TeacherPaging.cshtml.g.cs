#pragma checksum "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6dbec192d1e8affde80560bcfcfd06a5bf36b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherPaging), @"mvc.1.0.view", @"/Views/Teacher/TeacherPaging.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/TeacherPaging.cshtml", typeof(AspNetCore.Views_Teacher_TeacherPaging))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6dbec192d1e8affde80560bcfcfd06a5bf36b90", @"/Views/Teacher/TeacherPaging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d203abe104bfc70dc4a09c464acd95446a2328f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_TeacherPaging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Common.Common.ReturnResult<Common.Entity.Models.Teacher.Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
  
    const int ACTIVATE = 1;
    const int DEACTIVATE = 0;


#line default
#line hidden
            BeginContext(136, 1214, true);
            WriteLiteral(@"<div class=""main-content"">
    <section class=""section"">
        <h1 class=""section-header"">
            <div>Manage Teachers</div>
        </h1>
        <div class=""section-body"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Computer Room List</h4>
                        </div>
                        <div class=""card-body p-0"">
                            <div class=""table-responsive"">
                                <table class=""table table-striped"">
                                    <tr>
                                        <th>#</th>
                                        <th>Name</th>
                                        <th>Phone Number</th>
                                        <th>Status</th>
                                        <th>
                                            Action
                                         ");
            WriteLiteral("   <br />\n                                            <button id=\"add-btn\" class=\"ion-plus\"></button>\n                                        </th>\n                                    </tr>\n");
            EndContext();
#line 33 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                     foreach (var teacher in Model.ItemList)
                                    {

#line default
#line hidden
            BeginContext(1465, 77, true);
            WriteLiteral("                                <tr>\n                                    <td>");
            EndContext();
            BeginContext(1543, 13, false);
#line 36 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                   Write(teacher.PK_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1556, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1603, 12, false);
#line 37 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                   Write(teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1615, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1662, 19, false);
#line 38 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                   Write(teacher.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1681, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 39 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                     if (@teacher.Status == ACTIVATE)
                                    {

#line default
#line hidden
            BeginContext(1795, 100, true);
            WriteLiteral("                                        <td><a href=\"javascript:void(0)\" class=\"badge badge-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1895, "\"", 1967, 9);
            WriteAttributeValue("", 1905, "UpdateStatus(\'", 1905, 14, true);
#line 41 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 1919, teacher.PK_Id, 1919, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1933, "\',", 1933, 2, true);
            WriteAttributeValue(" ", 1935, "\'", 1936, 2, true);
#line 41 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 1937, teacher.Name, 1937, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1950, "\',", 1950, 2, true);
            WriteAttributeValue(" ", 1952, "\'", 1953, 2, true);
#line 41 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 1954, DEACTIVATE, 1954, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1965, "\')", 1965, 2, true);
            EndWriteAttribute();
            BeginContext(1968, 17, true);
            WriteLiteral(">Active</a></td>\n");
            EndContext();
#line 42 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2102, 99, true);
            WriteLiteral("                                        <td><a href=\"javascript:void(0)\" class=\"badge badge-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2201, "\"", 2271, 9);
            WriteAttributeValue("", 2211, "UpdateStatus(\'", 2211, 14, true);
#line 45 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 2225, teacher.PK_Id, 2225, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2239, "\',", 2239, 2, true);
            WriteAttributeValue(" ", 2241, "\'", 2242, 2, true);
#line 45 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 2243, teacher.Name, 2243, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2256, "\',", 2256, 2, true);
            WriteAttributeValue(" ", 2258, "\'", 2259, 2, true);
#line 45 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 2260, ACTIVATE, 2260, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2269, "\')", 2269, 2, true);
            EndWriteAttribute();
            BeginContext(2272, 19, true);
            WriteLiteral(">Deactive</a></td>\n");
            EndContext();
#line 46 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2329, 83, true);
            WriteLiteral("                                    <td>\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2412, "\"", 2477, 1);
#line 48 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 2419, Url.Action("Edit", "Teacher", new { Id = teacher.PK_Id }), 2419, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2478, 134, true);
            WriteLiteral(" id=\"edit-btn\" class=\"ion-edit\" width=\"50px\"></a>\n                                        <a href=\"javascript:void(0)\" id=\"delete-btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2612, "\"", 2663, 6);
            WriteAttributeValue("", 2622, "Delete(\'", 2622, 8, true);
#line 49 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 2630, teacher.PK_Id, 2630, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2644, "\',", 2644, 2, true);
            WriteAttributeValue(" ", 2646, "\'", 2647, 2, true);
#line 49 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 2648, teacher.Name, 2648, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2661, "\')", 2661, 2, true);
            EndWriteAttribute();
            BeginContext(2664, 106, true);
            WriteLiteral(" class=\"ion-trash-a\"></a>\n                                    </td>\n                                </tr>\n");
            EndContext();
#line 52 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2808, 522, true);
            WriteLiteral(@"                                </table>
                            </div>
                        </div>
                        <div class=""card-footer text-right"">
                            <nav class=""d-inline-block"">
                                <ul class=""pagination mb-0"">
                                    <li class=""page-item disabled"">
                                        <a class=""page-link"" href=""#"" tabindex=""-1""><i class=""ion ion-chevron-left""></i></a>
                                    </li>

");
            EndContext();
#line 63 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                      
                                        var numberOfPages = Model.TotalRows / ViewBag.PAGE_SIZE;
                                        for (int i = 0; i <= numberOfPages; i++)
                                        {

#line default
#line hidden
            BeginContext(3589, 87, true);
            WriteLiteral("                                            <li class=\"page-item \"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3676, "\"", 3764, 1);
#line 67 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
WriteAttributeValue("", 3683, Url.Action("TeacherPaging", "Teacher", new { PAGE_INDEX = i+1, PAGE_SIZE = 10 }), 3683, 81, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3765, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3768, 3, false);
#line 67 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                                                                                                                                                             Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(3772, 48, true);
            WriteLiteral("<span class=\"sr-only\">(current)</span></a></li>\n");
            EndContext();
#line 68 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                        }
                                    

#line default
#line hidden
            BeginContext(3900, 425, true);
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""#""><i class=""ion ion-chevron-right""></i></a>
                                    </li>
                                </ul>
                            </nav>
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
                BeginContext(4342, 244, true);
                WriteLiteral("\n    <script src=\"//cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js\"></script>\n    <script>\n        $(document).ready(function () {\n            $(\"#add-btn\").click(function () {\n                window.location.href = \'");
                EndContext();
                BeginContext(4587, 28, false);
#line 89 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                                   Write(Url.Action("Add", "Teacher"));

#line default
#line hidden
                EndContext();
                BeginContext(4615, 479, true);
                WriteLiteral(@"';
            });
        })
        function Delete (id, name) {
            // Tạo thông tin xóa Teacher
            var deleteInfo = {
                Title: 'Xác nhận xóa Teacher',
                Content: 'Bạn có muốn xóa <b>' + name + '</b> không?',
                ConfirmButton: 'Xác nhận',
                CancelButton: 'Hủy bỏ',
                Id: id,
                RequestVerificationToken: $(""input[name=__RequestVerificationToken]"").val(),
                Url: '");
                EndContext();
                BeginContext(5095, 31, false);
#line 101 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                 Write(Url.Action("Delete", "Teacher"));

#line default
#line hidden
                EndContext();
                BeginContext(5126, 730, true);
                WriteLiteral(@"',
                errorTitle: 'Thông báo lỗi',
                errorContent: 'Thay đổi trạng thái thất bại'
            };

            
            // Gọi hàm common để xóa trường học
            common.delete(deleteInfo);
        };  

    function UpdateStatus(Id, Name, Status) {
            var updateStatusInfo = {
                Title: 'Xác nhận thay đổi trạng thái Teacher',
                Content: 'Bạn có muốn thay đổi trạng thái của <b>' + Name + '</b> không?',
                ConfirmButton: 'Xác nhận',
                CancelButton: 'Hủy bỏ',
                Id: Id,
                Status: Status,
                RequestVerificationToken: $(""input[name=__RequestVerificationToken]"").val(),
                Url: '");
                EndContext();
                BeginContext(5857, 35, false);
#line 120 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\Teacher\TeacherPaging.cshtml"
                 Write(Url.Action("EditStatus", "Teacher"));

#line default
#line hidden
                EndContext();
                BeginContext(5892, 201, true);
                WriteLiteral("\',\n                errorTitle: \'Thông báo lỗi\',\n                errorContent: \'Thay đổi trạng thái thất bại\'\n            }\n            common.updateStatus(updateStatusInfo);\n        };  \n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Common.Common.ReturnResult<Common.Entity.Models.Teacher.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591