#pragma checksum "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e51718e7c0670518591d2849581f447ccfd4f49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e51718e7c0670518591d2849581f447ccfd4f49", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d488721331e76c153cda75bd04a9ca6fae0d12ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/SignUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admin/Desktop/Code/MVC/WebCoreMVC/WebCoreMVC/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""js/move-top.js""></script>
    <script type=""text/javascript"" src=""js/easing.js""></script>
    <script type=""text/javascript"">
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: ""slide"",
                start: function (slider) {
                    $('body').removeClass('loading');
                }
            });
        });

        $(window).load(function () {
            $('#JiSlider').JiSlider({ color: '#fff', start: 3, reverse: true }).addClass('ff')
        })

        jQuery(document).ready(function ($) {
            $("".scroll"").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
            });
        });
        $(document).ready(function () {
            $().UItoTop({ easingType: 'easeOutQuart' });
        });


    </script>
");
            }
            );
            WriteLiteral(@"
<!-- banner -->
<div class=""banner-silder"">
    <div id=""JiSlider"" class=""jislider"">
        <ul>
            <li>
                <div class=""w3layouts-banner-top"">
                    <div class=""container"">
                        <div class=""agileits-banner-info"">
                            <span>Education</span>
                            <h3>For the Creatives</h3>
                            <p>You can learn anything</p>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""w3layouts-banner-top w3layouts-banner-top1"">
                    <div class=""container"">
                        <div class=""agileits-banner-info"">
                            <span>Free</span>
                            <h3>Premium Courses</h3>
                            <p>You only have to know one thing</p>
                        </div>
                    </div>
                </div>
            </li>
      ");
            WriteLiteral(@"      <li>
                <div class=""w3layouts-banner-top w3layouts-banner-top2"">
                    <div class=""container"">
                        <div class=""agileits-banner-info"">
                            <span>Education</span>
                            <h3>For the Creatives</h3>
                            <p>You can learn anything.</p>
                        </div>
                    </div>
                </div>
            </li>

        </ul>
    </div>
</div>

<!-- //banner -->
<!-- Modal1 -->
<div class=""modal fade"" id=""myModal2"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <div class=""signin-form profile"">
                    <h3 class=""agileinfo_sign"">Sign In</h3>
                    <div class=""login-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e51718e7c0670518591d2849581f447ccfd4f497731", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" name=\"email\" placeholder=\"E-mail\"");
                BeginWriteAttribute("required", " required=\"", 3198, "\"", 3209, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"password\" name=\"password\" placeholder=\"Password\"");
                BeginWriteAttribute("required", " required=\"", 3302, "\"", 3313, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <div class=\"tp\">\r\n                                <input type=\"submit\" value=\"Sign In\">\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""login-social-grids"">
                        <ul>
                            <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-rss""></i></a></li>
                        </ul>
                    </div>
                    <p><a href=""#"" data-toggle=""modal"" data-target=""#myModal3""> Don't have an account?</a></p>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- //Modal1 -->
<!-- Modal2 -->
<div class=""modal fade"" id=""myModal3"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>

                <div class=""signin-form profile"">
                    <h");
            WriteLiteral("3 class=\"agileinfo_sign\">Sign Up</h3>\r\n                    <div class=\"login-form\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e51718e7c0670518591d2849581f447ccfd4f4911130", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" name=\"name\" placeholder=\"Username\"");
                BeginWriteAttribute("required", " required=\"", 4759, "\"", 4770, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"password\" name=\"password\" placeholder=\"Password\"");
                BeginWriteAttribute("required", " required=\"", 4863, "\"", 4874, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"password\" name=\"password\" placeholder=\"Confirm Password\"");
                BeginWriteAttribute("required", " required=\"", 4975, "\"", 4986, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"text\" name=\"Address\" placeholder=\"Address\"");
                BeginWriteAttribute("required", " required=\"", 5073, "\"", 5084, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"datetime\" name=\"BirthDay\" placeholder=\"BirthDay\"");
                BeginWriteAttribute("required", " required=\"", 5177, "\"", 5188, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"number\" name=\"PhoneNumber\" placeholder=\"PhoneNumber\"");
                BeginWriteAttribute("required", " required=\"", 5285, "\"", 5296, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"submit\" value=\"Sign Up\">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <p><a href=""#""> By clicking register, I agree to your terms</a></p>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- //Modal2 -->
<!-- bootstrap-pop-up -->
<div class=""modal video-modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <section>
                <div class=""modal-body"">
                    <h5>Mastering</h5>
                    <img src=""images/2.jpg"" alt="" "" class=""img-responsive"" />
                </div>
            </section>
        </div>
    </div>
</div>
<!-- //bootstrap-pop-up -->
<!-- //banner-bottom -->
<!-- services -->
<div class=""services"" id=""services"">
    <di");
            WriteLiteral(@"v class=""container"">
        <h3 class=""w3l_header w3_agileits_header two"">Our <span>Benefits</span></h3>
        <div class=""agile_inner_w3ls-grids two"">
            <div class=""col-md-3 service-box"">
                <figure class=""icon"">
                    <span>1</span>
                    <i class=""fa fa-graduation-cap"" aria-hidden=""true""></i>
                </figure>
                <h5>Experienced Faculty</h5>
            </div>
            <div class=""col-md-3 service-box"">

                <figure class=""icon"">
                    <span>2</span>
                    <i class=""fa fa-laptop"" aria-hidden=""true""></i>
                </figure>
                <h5>Online Courses</h5>
            </div>
            <div class=""col-md-3 service-box"">
                <figure class=""icon"">
                    <span>3</span>
                    <i class=""fa fa-book"" aria-hidden=""true""></i>
                </figure>
                <h5>Central Library</h5>
            </div>
            ");
            WriteLiteral(@"<div class=""col-md-3 service-box"">
                <figure class=""icon"">
                    <span>4</span>
                    <i class=""fa fa-lightbulb-o"" aria-hidden=""true""></i>
                </figure>
                <h5>Creative Thinking</h5>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<!-- //services -->
<!-- blog -->
<div class=""blog"" id=""blog"">
    <div class=""container"">

        <h3 class=""w3l_header w3_agileits_header""><span>News</span></h3>
        <div class=""agile_inner_w3ls-grids"">

            <div class=""col-sm-6 w3-agile-post-grids"">
                <div class=""w3-agile-post-img w3-agile-post-img1"">
                    <a href=""#"" data-toggle=""modal"" data-target=""#myModal"">
                        <ul>
                            <li><i class=""fa fa-comments"" aria-hidden=""true""></i> 05</li>
                            <li><i class=""fa fa-heart"" aria-hidden=""true""></i> 874</li>
                            <li><i clas");
            WriteLiteral(@"s=""fa fa-share"" aria-hidden=""true""></i> Share</li>
                        </ul>
                    </a>
                </div>
                <div class=""w3-agile-post-info"">
                    <h4><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Người nổi tiếng</a></h4>
                    <ul>
                        <li>By <a href=""#"">Admin</a></li>
                        <li>Jan 28th,2019</li>
                    </ul>
                    <p>Người mẫu Ngọc Trinh cũng đã ghé thăm để tìm tư liệu làm Vlog du lịch của cô</p>
                </div>
            </div>
            <div class=""col-sm-6 w3-agile-post-grids"">
                <div class=""w3-agile-post-img w3-agile-post-img2"">
                    <a href=""#"" data-toggle=""modal"" data-target=""#myModal"">
                        <ul>
                            <li><i class=""fa fa-comments"" aria-hidden=""true""></i> 21</li>
                            <li><i class=""fa fa-heart"" aria-hidden=""true""></i> 287</li>
                ");
            WriteLiteral(@"            <li><i class=""fa fa-share"" aria-hidden=""true""></i> Share</li>
                        </ul>
                    </a>
                </div>
                <div class=""w3-agile-post-info"">
                    <h4><a href=""#"" data-toggle=""modal"" data-target=""#myModal"">Tài liệu mới</a></h4>
                    <ul>
                        <li>By <a href=""#"">Admin</a></li>
                        <li>Feb 24th,2019</li>
                    </ul>
                    <p>Đã thêm vào 200 công trình nghiên cứu khoa học trong năm nay</p>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<!-- //blog -->
<!-- stats -->
<div class=""stats"" id=""stats"">
    <div class=""container"">
        <div class=""inner_w3l_agile_grids"">
            <div class=""col-md-3 w3layouts_stats_left w3_counter_grid"">
                <i class=""fa fa-laptop"" aria-hidden=""true""></i>
                <p class=""counter"">45</p>
                <h3>Cour");
            WriteLiteral(@"ses</h3>
            </div>
            <div class=""col-md-3 w3layouts_stats_left w3_counter_grid1"">
                <i class=""fa fa-smile-o"" aria-hidden=""true""></i>
                <p class=""counter"">165</p>
                <h3>Members</h3>
            </div>
            <div class=""col-md-3 w3layouts_stats_left w3_counter_grid2"">
                <i class=""fa fa-trophy"" aria-hidden=""true""></i>
                <p class=""counter"">563</p>
                <h3>Awards</h3>
            </div>
            <div class=""col-md-3 w3layouts_stats_left w3_counter_grid3"">
                <i class=""fa fa-user"" aria-hidden=""true""></i>
                <p class=""counter"">245</p>
                <h3>Instructors</h3>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<!-- //stats -->
<!-- testimonials -->
<div class=""testimonials"">
    <div class=""col-md-6 w3layouts_event_left"">
        <img src=""images/test.jpg"" alt="" "" class=""img-responsive"" />
    </div>
  ");
            WriteLiteral(@"  <div class=""col-md-6 w3layouts_event_right"">
        <h3>what people says</h3>
        <section class=""slider"">
            <div class=""flexslider"">
                <ul class=""slides"">
                    <li>
                        <div class=""w3_event_right_grid"">
                            <div class=""w3layouts_event_right_para"">
                                <p>
                                    Thư viện có rất nhiều những cuốn sách hay và bổ ích.
                                    Giúp cho việc học và tìm kiếm tư liệu của tôi dễ dàng
                                </p>
                                <div class=""w3layouts_event_right_para_pos""></div>
                            </div>
                            <div class=""w3_agile_event_right_grids"">
                                <div class=""col-xs-4 w3_agile_event_right_grid_left"">
                                    <img src=""images/test1.jpg"" alt="" "" class=""img-responsive"" />
                                </div>
     ");
            WriteLiteral(@"                           <div class=""col-xs-8 w3_agile_event_right_grid_right"">
                                    <h4>Williams Stall</h4>
                                    <p>Graphic & web designer</p>
                                </div>
                                <div class=""clearfix""> </div>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div class=""w3_event_right_grid"">
                            <div class=""w3layouts_event_right_para"">
                                <p>
                                    Tôi có thể tìm được những quyển sách về ngành học của tôi rất nhiều ở đây.
                                    Tôi mong là các bạn cũng thế
                                </p>
                                <div class=""w3layouts_event_right_para_pos""></div>
                            </div>
                            <div class=""w3_agile_event_right_grids"">
                 ");
            WriteLiteral(@"               <div class=""col-xs-4 w3_agile_event_right_grid_left"">
                                    <img src=""images/test2.jpg"" alt="" "" class=""img-responsive"" />
                                </div>
                                <div class=""col-xs-8 w3_agile_event_right_grid_right"">
                                    <h4>Catherine Mark</h4>
                                    <p>PHP & web developer</p>
                                </div>
                                <div class=""clearfix""> </div>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </section>
    </div>
    <div class=""clearfix""> </div>
</div>
");
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
