#pragma checksum "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17bd5fea42c0c09151566963b61879e12a29a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#nullable restore
#line 1 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/_ViewImports.cshtml"
using WebCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/_ViewImports.cshtml"
using WebCoreMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/_ViewImports.cshtml"
using WebCoreMVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a17bd5fea42c0c09151566963b61879e12a29a56", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d488721331e76c153cda75bd04a9ca6fae0d12ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/checkbox-mylib.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/users"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
  
    ViewData["Title"] = "Users List";
    var pager = Model.Page;
    var users = Model.Users;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17bd5fea42c0c09151566963b61879e12a29a564769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>

        //Chọn droplist page size

        var $choicePageSize = $('#dropdownlist-pageSize');
        $choicePageSize.on('change', function () {
            var $this = $(this);

            window.location = `/home/users?pageSize=${$this.val()}`;
        });

        //Xóa bằng ajax

        var $ajaxDelete = $('.ajaxdeleteuser');
        $ajaxDelete.on('click', function () {
            var $this = $(this);

            swal(""Bạn có chắc muốn xóa không?"", ""Hành động này sẽ không thể nào khôi phục!"", ""warning"", {
                type: ""warning"",
                showCancelButton: true,
                confirmButtonClass: ""btn-warning"",
                confirmButtonText: ""Đồng ý"",
                cancelButtonText: ""Không xóa"",
                closeOnConfirm: false,
                closeOnCancel: false
            }).then((isConfirm) => {
                if (isConfirm) {
                    $.ajax({
                        url: '");
#nullable restore
#line 41 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                         Write(Url.Action("AjaxDeleteUser", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                        method: 'POST',
                        dataType: 'json',
                        data: {
                            id: $this.data('id')
                        }
                    }).done(function (data) {
                        if (data) {
                            swal(""Xóa thành công!"", {
                                button: false,
                                type: 'success',
                            });
                            window.location.reload();
                        }
                        else {
                            alert('Xóa thất bại!');
                        }
                    })
                        .fail(function (jqXHR, textStatus, errorThrown) {
                            alert('something wrong here');
                        });
                } else {
                    swal(""Đã hủy!"", ""Dữ liệu vẫn còn"", ""error"");
                }
            });
        });

        //Chọn 1 hoặc tất cả
");
                WriteLiteral(@"
        var $table = $('#users-table');
        var $btnDeleteMany = $('#btnDeleteManyUser');

        var $multiChecknoxesModule = MyLib.Ui.MultiCheckBoxes({
            checkboxAllSelector: '#checkbox_all',
            checkboxListSelector: '#users-table tbody tr td:first-child'
        });

        $multiChecknoxesModule.init();

        function deleteRecord(sendData, currentNumberOfRows) {
            if (sendData.ids.length == 0) {
                swal('', 'Lựa Chọn Ít Nhất Một Sản Phẩm Để Thực Hiện Thao Tác Này', 'warning');
            } else {
                $.ajax({
                    url: '");
#nullable restore
#line 85 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                     Write(Url.Action("DeleteManyUser", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    method: 'POST',
                    dataType: 'json',
                    data: sendData
                    }).done(function () {
                        swal(
                            'Đã Xóa!',
                            'Dữ Liệu Đã Được Xóa Khỏi Danh Sách.',
                            'success'
                        ).then(() => {
                            window.location.reload();
                        });
                })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                    swal(
                        'Lỗi!',
                        errorThrown,
                        'error'
                    );
                });
            }
        }

        $btnDeleteMany.on('click', function () {
            swal({
                title: 'Bạn có chắc không?',
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonC");
                WriteLiteral(@"olor: '#d33',
                confirmButtonText: 'Có',
                cancelButtonText: 'Không'
            }).then((result) => {
                console.log(result);
                if (result) {
                    deleteRecord({
                        ids: $multiChecknoxesModule.getSelectedItemValues(),
                    }, $multiChecknoxesModule.getSelectedItemValues().length);
                }
            });
        });

    </script>
");
            }
            );
            WriteLiteral("<div>\r\n    <div class=\"btn-group btn-group-justified col-md-offset-1\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17bd5fea42c0c09151566963b61879e12a29a5610713", async() => {
                WriteLiteral(@"
            <div>
                <!--Nút chọn PageSize-->
                <div class=""col-md-1"">
                    <select name=""pageSize"" class=""col-1""
                            id=""dropdownlist-pageSize"" style=""color: #007bff; border-color: #007bff; font-size: 12px;"">
");
#nullable restore
#line 137 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                          
                            int[] pageSize = new int[] { 5, 10, 20, 30 };

                            foreach (var item in pageSize)
                            {
                                if (Convert.ToInt32(Context.Request.Query["pageSize"]) == item)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17bd5fea42c0c09151566963b61879e12a29a5611810", async() => {
#nullable restore
#line 144 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                                              Write(item);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" Trang");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                                WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 145 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17bd5fea42c0c09151566963b61879e12a29a5614362", async() => {
#nullable restore
#line 148 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                                     Write(item);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" Trang");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                       WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 149 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div>
        <div class=""container"">
            <div class=""row"">
                <table id=""users-table"" class=""table table-dark table-striped"">
                    <thead>
                        <tr>
                            <th>
                                Tất Cả
                                <div class=""btn-group pull-right"">
                                    <input id=""checkbox_all"" type=""checkbox"" />
                                </div>
                            </th>
                            <th>STT</th>
                            <th>
                                ");
#nullable restore
#line 171 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                           Write(Html.ActionLink("Tên Đăng Nhập", "users", "home",
                                     new
                                     {
                                         sortOrder = ViewBag.SortUserName,
                                         currentPage = Context.Request.Query["currentPage"],
                                         searchString = Context.Request.Query["searchString"]
                                     }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 180 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                           Write(Html.ActionLink("SĐT", "users", "home",
                                     new
                                     {
                                         sortOrder = ViewBag.SortPhoneNumber,
                                         currentPage = Context.Request.Query["currentPage"],
                                         searchString = Context.Request.Query["searchString"]
                                     }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 189 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                           Write(Html.ActionLink("Email", "users", "home",
                                     new
                                     {
                                         sortOrder = ViewBag.SortEmail,
                                         currentPage = Context.Request.Query["currentPage"],
                                         searchString = Context.Request.Query["searchString"]
                                     }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 198 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                           Write(Html.ActionLink("Địa Chỉ", "users", "home",
                                     new
                                     {
                                         sortOrder = ViewBag.SortAddress,
                                         currentPage = Context.Request.Query["currentPage"],
                                         searchString = Context.Request.Query["searchString"]
                                     }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 207 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                           Write(Html.ActionLink("Tỉnh", "users", "home",
                                     new
                                     {
                                         sortOrder = ViewBag.Sortprovince,
                                         currentPage = Context.Request.Query["currentPage"],
                                         searchString = Context.Request.Query["searchString"]
                                     }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </th>
                            <th>
                                <button id=""btnDeleteManyUser"" class=""btn btn-danger ajaxDelete"">
                                    Xóa Đã Chọn
                                </button>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 223 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                         for (int i = 0; i < users.Count(); i++)
                        {
                            var user = users.ElementAtOrDefault(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td align=\"left\">\r\n                                    <input");
            BeginWriteAttribute("value", " value=\"", 9544, "\"", 9560, 1);
#nullable restore
#line 228 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 9552, user.Id, 9552, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"customerCheck\" type=\"checkbox\" />\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 230 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                Write(((pager.CurrentPage - 1) * pager.PageSize) + i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <!--Tạo bộ đếm STT-->\r\n                                <td>");
#nullable restore
#line 231 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 232 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                               Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 233 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 234 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                               Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 235 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                               Write(user.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a data-id=\"");
#nullable restore
#line 237 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                                           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" role=\"button\" class=\"ajaxDelete btn btn-link\">Xóa</a>\r\n                                    ||\r\n                                    <a role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 10288, "\"", 10351, 1);
#nullable restore
#line 239 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 10295, Url.Action("DetailsUser", "home", new { id = user.Id }), 10295, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-link\">Chi Tiết</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 242 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <div class=""container row form-inline"">
        <!--Phân trang bên dưới-->
        <div class=""col-md-6 col-md-offset-6"" style=""font-size: 15px;"">
            <ul class=""pagination"">

                <!--Tạo nút first-->
                <li");
            BeginWriteAttribute("class", " class=\"", 10845, "\"", 10916, 2);
            WriteAttributeValue("", 10853, "page-item", 10853, 9, true);
#nullable restore
#line 255 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue(" ", 10862, pager.CurrentPage == 1 ? "disabled" : string.Empty, 10863, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 10960, "\"", 11329, 1);
#nullable restore
#line 256 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 10967, Url.Action("users", "home",
                    new
                    {
                        currentPage = 1,
                        pageSize = Context.Request.Query["pageSize"],
                        category = Context.Request.Query["category"],
                        searchString = Context.Request.Query["searchString"]
                    }), 10967, 362, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        First\r\n                    </a>\r\n                </li>\r\n\r\n                <!--Tạo nút Previous-->\r\n");
#nullable restore
#line 269 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                 if (pager.CurrentPage == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item disabled\">\r\n                        <a class=\"page-link\">Previous</a>\r\n                    </li>\r\n");
#nullable restore
#line 274 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 11808, "\"", 12171, 1);
#nullable restore
#line 278 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 11815, Url.Action("users", "home",
                        new { currentPage = pager.CurrentPage - 1,
                            pageSize = Context.Request.Query["pageSize"],
                            category = Context.Request.Query["category"],
                            searchString = Context.Request.Query["searchString"]
                        }), 11815, 356, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a>\r\n                    </li>\r\n");
#nullable restore
#line 285 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 287 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                 for (int i = pager.StartPage; i <= pager.EndPage; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 12350, "\"", 12419, 2);
            WriteAttributeValue("", 12358, "page-item", 12358, 9, true);
#nullable restore
#line 289 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue(" ", 12367, pager.CurrentPage == i ? "active" : string.Empty, 12368, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 12467, "\"", 12858, 1);
#nullable restore
#line 291 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 12502, Url.Action("users", "home",
                            new { currentPage = i,
                                pageSize = Context.Request.Query["pageSize"],
                                category = Context.Request.Query["category"],
                                searchString = Context.Request.Query["searchString"]
                            }), 12502, 356, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 296 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 298 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--Tạo nút next-->\r\n");
#nullable restore
#line 301 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                 if (pager.CurrentPage == pager.TotalPages || pager.TotalPages == 1 || pager.TotalPages == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item disabled\">\r\n                        <a class=\"page-link\">Next</a>\r\n                    </li>\r\n");
#nullable restore
#line 306 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 13374, "\"", 13785, 1);
#nullable restore
#line 311 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 13409, Url.Action("users", "home",
                            new { currentPage = pager.CurrentPage + 1,
                                pageSize = Context.Request.Query["pageSize"],
                                category = Context.Request.Query["category"],
                                searchString = Context.Request.Query["searchString"]
                            }), 13409, 376, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Next\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 320 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--Tạo nút Last-->\r\n");
#nullable restore
#line 323 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                 if (pager.TotalPages == 1 || pager.TotalPages == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item disabled\">\r\n                        <a class=\"page-link\">Last</a>\r\n                    </li>\r\n");
#nullable restore
#line 328 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 14245, "\"", 14331, 2);
            WriteAttributeValue("", 14253, "page-item", 14253, 9, true);
#nullable restore
#line 331 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue(" ", 14262, pager.CurrentPage == pager.TotalPages ? "disabled" : string.Empty, 14263, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 14379, "\"", 14763, 1);
#nullable restore
#line 332 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
WriteAttributeValue("", 14386, Url.Action("users", "home",
                    new
                    {
                        currentPage = pager.TotalPages,
                        pageSize = Context.Request.Query["pageSize"],
                        category = Context.Request.Query["category"],
                        searchString = Context.Request.Query["searchString"]
                    }), 14386, 377, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Last\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 343 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
