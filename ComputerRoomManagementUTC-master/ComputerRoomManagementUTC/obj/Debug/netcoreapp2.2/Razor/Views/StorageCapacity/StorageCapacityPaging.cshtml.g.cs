#pragma checksum "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e139b1090eeb8325ddfc0e0c41c50f4d34036b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StorageCapacity_StorageCapacityPaging), @"mvc.1.0.view", @"/Views/StorageCapacity/StorageCapacityPaging.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StorageCapacity/StorageCapacityPaging.cshtml", typeof(AspNetCore.Views_StorageCapacity_StorageCapacityPaging))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e139b1090eeb8325ddfc0e0c41c50f4d34036b5", @"/Views/StorageCapacity/StorageCapacityPaging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d203abe104bfc70dc4a09c464acd95446a2328f7", @"/Views/_ViewImports.cshtml")]
    public class Views_StorageCapacity_StorageCapacityPaging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Common.Common.ReturnResult<Common.Entity.Models.StorageCapacity.StorageCapacity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
  
    const int ACTIVATE = 1;
    const int DEACTIVATE = 0;


#line default
#line hidden
            BeginContext(152, 1153, true);
            WriteLiteral(@"<div class=""main-content"">
    <section class=""section"">
        <h1 class=""section-header"">
            <div>Manage Computers</div>
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
                                        <th>Status</th>
                                        <th>
                                            Action
                                            <br />
                                            <button");
            WriteLiteral(" id=\"add-btn\" class=\"ion-plus\"></button>\n                                        </th>\n                                    </tr>\n");
            EndContext();
#line 32 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                     foreach (var storageCapacity in Model.ItemList)
                                    {

#line default
#line hidden
            BeginContext(1428, 77, true);
            WriteLiteral("                                <tr>\n                                    <td>");
            EndContext();
            BeginContext(1506, 21, false);
#line 35 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                   Write(storageCapacity.PK_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1527, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(1574, 20, false);
#line 36 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                   Write(storageCapacity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1594, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 37 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                     if (@storageCapacity.Status == ACTIVATE)
                                    {

#line default
#line hidden
            BeginContext(1716, 100, true);
            WriteLiteral("                                        <td><a href=\"javascript:void(0)\" class=\"badge badge-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1816, "\"", 1904, 9);
            WriteAttributeValue("", 1826, "UpdateStatus(\'", 1826, 14, true);
#line 39 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 1840, storageCapacity.PK_Id, 1840, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 1862, "\',", 1862, 2, true);
            WriteAttributeValue(" ", 1864, "\'", 1865, 2, true);
#line 39 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 1866, storageCapacity.Name, 1866, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1887, "\',", 1887, 2, true);
            WriteAttributeValue(" ", 1889, "\'", 1890, 2, true);
#line 39 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 1891, DEACTIVATE, 1891, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1902, "\')", 1902, 2, true);
            EndWriteAttribute();
            BeginContext(1905, 17, true);
            WriteLiteral(">Active</a></td>\n");
            EndContext();
#line 40 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2039, 99, true);
            WriteLiteral("                                        <td><a href=\"javascript:void(0)\" class=\"badge badge-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2138, "\"", 2224, 9);
            WriteAttributeValue("", 2148, "UpdateStatus(\'", 2148, 14, true);
#line 43 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 2162, storageCapacity.PK_Id, 2162, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 2184, "\',", 2184, 2, true);
            WriteAttributeValue(" ", 2186, "\'", 2187, 2, true);
#line 43 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 2188, storageCapacity.Name, 2188, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 2209, "\',", 2209, 2, true);
            WriteAttributeValue(" ", 2211, "\'", 2212, 2, true);
#line 43 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 2213, ACTIVATE, 2213, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2222, "\')", 2222, 2, true);
            EndWriteAttribute();
            BeginContext(2225, 19, true);
            WriteLiteral(">Deactive</a></td>\n");
            EndContext();
#line 44 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2282, 83, true);
            WriteLiteral("                                    <td>\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2446, 1);
#line 46 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 2372, Url.Action("Edit", "StorageCapacity", new { Id = storageCapacity.PK_Id }), 2372, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2447, 134, true);
            WriteLiteral(" id=\"edit-btn\" class=\"ion-edit\" width=\"50px\"></a>\n                                        <a href=\"javascript:void(0)\" id=\"delete-btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2581, "\"", 2648, 6);
            WriteAttributeValue("", 2591, "Delete(\'", 2591, 8, true);
#line 47 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 2599, storageCapacity.PK_Id, 2599, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 2621, "\',", 2621, 2, true);
            WriteAttributeValue(" ", 2623, "\'", 2624, 2, true);
#line 47 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 2625, storageCapacity.Name, 2625, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 2646, "\')", 2646, 2, true);
            EndWriteAttribute();
            BeginContext(2649, 106, true);
            WriteLiteral(" class=\"ion-trash-a\"></a>\n                                    </td>\n                                </tr>\n");
            EndContext();
#line 50 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2793, 522, true);
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
#line 61 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                      
                                        var numberOfPages = Model.TotalRows / ViewBag.PAGE_SIZE;
                                        for (int i = 0; i <= numberOfPages; i++)
                                        {

#line default
#line hidden
            BeginContext(3574, 87, true);
            WriteLiteral("                                            <li class=\"page-item \"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3661, "\"", 3765, 1);
#line 65 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
WriteAttributeValue("", 3668, Url.Action("StorageCapacityPaging", "StorageCapacity", new { PAGE_INDEX = i+1, PAGE_SIZE = 10 }), 3668, 97, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3766, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3769, 3, false);
#line 65 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                                                                                                                                                                             Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(3773, 48, true);
            WriteLiteral("<span class=\"sr-only\">(current)</span></a></li>\n");
            EndContext();
#line 66 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                        }
                                    

#line default
#line hidden
            BeginContext(3901, 425, true);
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
                BeginContext(4343, 244, true);
                WriteLiteral("\n    <script src=\"//cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js\"></script>\n    <script>\n        $(document).ready(function () {\n            $(\"#add-btn\").click(function () {\n                window.location.href = \'");
                EndContext();
                BeginContext(4588, 36, false);
#line 87 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                                   Write(Url.Action("Add", "StorageCapacity"));

#line default
#line hidden
                EndContext();
                BeginContext(4624, 495, true);
                WriteLiteral(@"';
            });
        })
        function Delete (id, name) {
            // Tạo thông tin xóa StorageCapacity
            var deleteInfo = {
                Title: 'Xác nhận xóa StorageCapacity',
                Content: 'Bạn có muốn xóa <b>' + name + '</b> không?',
                ConfirmButton: 'Xác nhận',
                CancelButton: 'Hủy bỏ',
                Id: id,
                RequestVerificationToken: $(""input[name=__RequestVerificationToken]"").val(),
                Url: '");
                EndContext();
                BeginContext(5120, 39, false);
#line 99 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                 Write(Url.Action("Delete", "StorageCapacity"));

#line default
#line hidden
                EndContext();
                BeginContext(5159, 738, true);
                WriteLiteral(@"',
                errorTitle: 'Thông báo lỗi',
                errorContent: 'Thay đổi trạng thái thất bại'
            };

            
            // Gọi hàm common để xóa trường học
            common.delete(deleteInfo);
        };  

    function UpdateStatus(Id, Name, Status) {
            var updateStatusInfo = {
                Title: 'Xác nhận thay đổi trạng thái StorageCapacity',
                Content: 'Bạn có muốn thay đổi trạng thái của <b>' + Name + '</b> không?',
                ConfirmButton: 'Xác nhận',
                CancelButton: 'Hủy bỏ',
                Id: Id,
                Status: Status,
                RequestVerificationToken: $(""input[name=__RequestVerificationToken]"").val(),
                Url: '");
                EndContext();
                BeginContext(5898, 43, false);
#line 118 "E:\laptrinhweb\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC-master\ComputerRoomManagementUTC\Views\StorageCapacity\StorageCapacityPaging.cshtml"
                 Write(Url.Action("EditStatus", "StorageCapacity"));

#line default
#line hidden
                EndContext();
                BeginContext(5941, 201, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Common.Common.ReturnResult<Common.Entity.Models.StorageCapacity.StorageCapacity>> Html { get; private set; }
    }
}
#pragma warning restore 1591