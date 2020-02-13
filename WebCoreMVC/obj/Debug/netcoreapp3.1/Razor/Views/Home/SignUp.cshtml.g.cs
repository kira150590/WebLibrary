#pragma checksum "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4e2f272ae45d0ac58e2db99453622fff11cf78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SignUp), @"mvc.1.0.view", @"/Views/Home/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4e2f272ae45d0ac58e2db99453622fff11cf78", @"/Views/Home/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d488721331e76c153cda75bd04a9ca6fae0d12ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
  
    Layout = "~/Views/Shared/_LayoutSignUp.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#cbShowPassword').click(function () {
                var currentPassowrdFiled = $('#txtPassword');
                var currentPassword = currentPassowrdFiled.val();
                currentPassowrdFiled.remove();

                if ($(this).is(':checked')) {
                    $(this).before('<input type=""text"" id=""txtPassword"" value=""'
                        + currentPassword + '"">');
                }
                else {
                    $(this).before('<input type=""password"" id=""txtPassword"" value=""'
                        + currentPassword + '"">');
                }
            });
        });

        var $province = $('#Province');
        var $district = $('#District');

        $province.on('change', function () {
            var $this = $(this);
            $.ajax({
                u");
                WriteLiteral("rl: \'");
#nullable restore
#line 34 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
                 Write(Url.Action("GetDistricts", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                method: 'Get',
                dataType: 'json',
                data: {
                    provinceId: $this.val()
                }
            }).done(function (data) {
                $district.find('option:not(:first)').remove();
                var result = '';
                data.forEach(ele => {
                    result += `<option value=""${ele.value}"">${ele.text}</option>`;
                });
                $district.append(result);
            })
        });
    </script>

    <script type=""text/javascript"">
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
            WriteLiteral("\r\n<div class=\"sub-main-w3\">\r\n");
#nullable restore
#line 63 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
     using (Html.BeginForm("SignUp", "home", FormMethod.Post, new { @class = "col-md-4" }))
    {
        Html.AntiForgeryToken();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
   Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 69 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 70 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.UserName, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 71 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 74 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.PassWord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 75 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.PasswordFor(x => x.PassWord, new { placeholder = "", id = "txtPassword" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"checkbox\" id=\"cbShowPassword\" />Show password\r\n            ");
#nullable restore
#line 77 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.PassWord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 80 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 81 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.FirstName, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 82 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 85 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 86 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.LastName, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 87 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 90 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 91 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.Birthday, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 92 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 95 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 96 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.PhoneNumber, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 97 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 100 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 101 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.Email, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 102 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 105 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 106 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.TextBoxFor(x => x.Address, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 107 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-2\">\r\n            <label for=\"Province\">Tỉnh thành</label>\r\n            <select id=\"Province\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4e2f272ae45d0ac58e2db99453622fff11cf7813653", async() => {
                WriteLiteral("--Không chọn--");
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
            WriteLiteral("\r\n");
#nullable restore
#line 113 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
                 foreach (var option in (ViewBag.Province as IEnumerable<SelectListItem>))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4e2f272ae45d0ac58e2db99453622fff11cf7815119", async() => {
#nullable restore
#line 115 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
                                             Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
                       WriteLiteral(option.Value);

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
#line 116 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group col-md-2\">\r\n            <label for=\"District\">Quận huyện</label>\r\n            <select id=\"District\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4e2f272ae45d0ac58e2db99453622fff11cf7817313", async() => {
                WriteLiteral("--Không chọn--");
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
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div id=\"imageUpload\" class=\"form-group\">\r\n            ");
#nullable restore
#line 126 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.LabelFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 127 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.DisplayFor(x => x.Image, new { placeholder = "", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 128 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
       Write(Html.ValidationMessageFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <input type=""file"" name=""Image"" />
        </div>
        <div class=""form-group"">
            <label class=""checkbox-inline"">
                <input type=""checkbox"" value=""true"" required>I agree to the terms and conditions
            </label>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Tạo Tài Khoản</button>
");
#nullable restore
#line 137 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/SignUp.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
