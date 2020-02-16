#pragma checksum "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4d7e9aa138e5f8ce35f60c85507c11bdcb0deed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateBook), @"mvc.1.0.view", @"/Views/Home/UpdateBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d7e9aa138e5f8ce35f60c85507c11bdcb0deed", @"/Views/Home/UpdateBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d488721331e76c153cda75bd04a9ca6fae0d12ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpdateBookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("with", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 25 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
 using (Html.BeginForm("updatebook", "home", new { id = Model.Id }, FormMethod.Post, null, new { @class = "col-md-4", enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
                              ;
    Html.AntiForgeryToken();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
                                   //báo lỗi tổng khi người dùng ấn submit

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>(Có dấu * vui lòng điền đầy đủ thông tin)</div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 32 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.NameOfBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.TextBoxFor(x => x.NameOfBook, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.NameOfBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.TextBoxFor(x => x.Author, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 43 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.DropDownListFor(x => x.CategoryId, (IEnumerable<SelectListItem>)ViewBag.Categories, "Danh Mục", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 47 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.YearOfPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.TextBoxFor(x => x.YearOfPrint, new { placeholder = "", @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 49 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.YearOfPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">Ví dụ: 2000</small>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 53 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 54 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.TextBoxFor(x => x.Quantity, new { placeholder = "", @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 55 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 58 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 59 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.TextBoxFor(x => x.Code, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 60 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">Ví dụ: a1234</small>\r\n    </div>\r\n    <div id=\"imageUpload\" class=\"form-group\">\r\n        ");
#nullable restore
#line 64 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.LabelFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 65 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.DisplayFor(x => x.Image, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 66 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ValidationMessageFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4d7e9aa138e5f8ce35f60c85507c11bdcb0deed12218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2640, "~/images/", 2640, 9, true);
#nullable restore
#line 67 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
AddHtmlAttributeValue("", 2649, Model.Photo, 2649, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <input type=\"file\" name=\"Image\" />\r\n    </div>\r\n    <div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Đồng Ý</button>\r\n        ");
#nullable restore
#line 72 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
   Write(Html.ActionLink("Hủy", "Books", "home", null,
                                   new { @class = "btn btn-primary", type = "button", style = "position: relative; right: -30px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 75 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/UpdateBook.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
