#pragma checksum "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf11bb735966b1ffc8c00670d70483e28648ca9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateBook), @"mvc.1.0.view", @"/Views/Home/CreateBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf11bb735966b1ffc8c00670d70483e28648ca9f", @"/Views/Home/CreateBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d488721331e76c153cda75bd04a9ca6fae0d12ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateBookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        div {\r\n            font-size: 16px;\r\n            color: #007bff;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(imageUpload).on('change', function () {
                var fileName = $(this).val().split(""\\"").pop();
                $(this).next('')
            })
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 25 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
 using (Html.BeginForm("createbook", "home", FormMethod.Post, new { @class = "col-md-4", enctype = "multipart/form-data" }))
{
    Html.AntiForgeryToken();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>(Có dấu * vui lòng điền đầy đủ thông tin)</div>\r\n    <div class=\"form-group\">\r\n        <!--Gọi lại nhãn ở ViewModel hiển thị tên-->\r\n        ");
#nullable restore
#line 32 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.NameOfBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.TextBoxFor(x => x.NameOfBook, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!--Hiển thị lỗi khi k nhập đúng-->\r\n        ");
#nullable restore
#line 35 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.NameOfBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.TextBoxFor(x => x.Author, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 43 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.DropDownListFor(x => x.CategoryId, (IEnumerable<SelectListItem>)ViewBag.Categories, "Danh Mục", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 45 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 48 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.YearOfPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 49 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.TextBoxFor(x => x.YearOfPrint, new { placeholder = "", @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 50 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.YearOfPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">Ví dụ: 2000</small>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 54 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 55 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.TextBoxFor(x => x.Quantity, new { placeholder = "", @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 56 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 59 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 60 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.TextBoxFor(x => x.Code, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 61 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">Ví dụ: a1234</small>\r\n    </div>\r\n    <div id=\"imageUpload\" class=\"form-group\">\r\n        ");
#nullable restore
#line 65 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.LabelFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 66 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.DisplayFor(x => x.Image, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 67 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <input type=""file"" name=""Image"" />
    </div>
    <button type=""submit"" class=""btn btn-primary"">Tạo Mới</button>
    <button action=""/home/books"" type=""submit"" class=""btn btn-primary"" style=""position: relative; right: -30px;"">Trở Về</button>
");
#nullable restore
#line 72 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/CreateBook.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
