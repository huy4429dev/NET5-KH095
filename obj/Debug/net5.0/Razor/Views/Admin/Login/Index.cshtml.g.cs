#pragma checksum "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67dbacc239a3c1dc9bd069757e3e444d54020bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login_Index), @"mvc.1.0.view", @"/Views/Admin/Login/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\_ViewImports.cshtml"
using KH095;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\_ViewImports.cshtml"
using KH095.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\_ViewImports.cshtml"
using KH095.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67dbacc239a3c1dc9bd069757e3e444d54020bd", @"/Views/Admin/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b67dbacc239a3c1dc9bd069757e3e444d54020bd4915", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 258, "\"", 268, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 297, "\"", 307, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>Page Title - SB Admin</title>
    <link href=""/assets/admin/css/styles.css"" rel=""stylesheet"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js""
    crossorigin=""anonymous""></script>
    <script src=""http://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js""></script> <!-- stats.js lib -->
    <script src=""http://threejs.org/examples/js/libs/stats.min.js""></script><!-- particles.js container -->
    <style>
        /* ---- reset ---- */
        body {
        margin: 0;
        font: normal 75% Arial, Helvetica, sans-serif;
        }

        canvas {
        display: block;
        vertical-align: bottom;
        }

        /* ---- particles.js container ---- */
        #particles-js {
        position: absolute;
        width: 100%;
        height: 100%;
        background-color: #b61924;
        background-image: url("""");
        background-repeat: no-repeat;
        background-size: cover;
        background-position: 5");
                WriteLiteral(@"0% 50%;
        }

        /* ---- stats.js ---- */
        .count-particles {
        background: #000022;
        position: absolute;
        top: 48px;
        left: 0;
        width: 80px;
        color: #13E8E9;
        font-size: .8em;
        text-align: left;
        text-indent: 4px;
        line-height: 14px;
        padding-bottom: 2px;
        font-family: Helvetica, Arial, sans-serif;
        font-weight: bold;
        }

        .js-count-particles {
        font-size: 1.1em;
        }

        #stats,
        .count-particles {
        -webkit-user-select: none;
        margin-top: 5px;
        margin-left: 5px;
        }

        #stats {
        border-radius: 3px 3px 0 0;
        overflow: hidden;
        }

        .count-particles {
        border-radius: 0 0 3px 3px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b67dbacc239a3c1dc9bd069757e3e444d54020bd8397", async() => {
                WriteLiteral(@"
    <!-- particles.js container -->
    <div id=""particles-js""></div> <!-- stats - count particles -->
    <div id=""layoutAuthentication"">
        <div id=""layoutAuthentication_content"">
            <main>
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-4"">
                            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                                <div class=""card-header"">
                                    <h3 class=""text-center font-weight-light my-4"">Login</h3>
                                </div>
                                <div class=""card-body"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b67dbacc239a3c1dc9bd069757e3e444d54020bd9406", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Login\Index.cshtml"
                                         if (ViewData.ModelState.Any(x => x.Value.Errors.Any()))
                                        {
                                            // Bootstrap 2 = "alert-error", Bootstrap 3 and 4 = "alert-danger"

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                            <div class=\"alert alert-danger alert-error\">\r\n                                                <a class=\"close\" data-dismiss=\"alert\">&times;</a>\r\n                                                ");
#nullable restore
#line 99 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Login\Index.cshtml"
                                           Write(Html.ValidationSummary(true, "Errors: "));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </div>\r\n");
#nullable restore
#line 101 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Login\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                        <div class=""form-group"">
                                            <label class=""small mb-1"" for=""inputEmailAddress"">Email</label>
                                            <input name=""username"" class=""form-control py-4"" id=""inputEmailAddress""
                                            type=""text"" placeholder=""Enter username"" />
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""small mb-1"" for=""inputPassword"">Password</label>
                                            <input name=""password"" class=""form-control py-4"" id=""inputPassword""
                                            type=""password"" placeholder=""Enter password"" />
                                        </div>
                                        <div class=""form-group"">
                                            <div class=""custom-control custom-checkbox"">
         ");
                    WriteLiteral(@"                                       <input name=""password"" class=""custom-control-input""
                                                id=""rememberPasswordCheck"" type=""checkbox"" />
                                                <label class=""custom-control-label"" for=""rememberPasswordCheck"">Remember
                                                    password</label>
                                            </div>
                                        </div>
                                        <div
                                        class=""form-group d-flex align-items-center justify-content-between mt-4 mb-0"">
                                            <a class=""small"" href=""password.html"">Forgot Password?</a>
                                            <button class=""btn btn-primary"" type=""submit"">Login</button>
                                        </div>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                                <div class=""card-footer text-center"">
                                    <div class=""small""><a href=""register.html"">Need an account? Sign up!</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
        <div id=""layoutAuthentication_footer"">
            <footer class=""py-4 bg-light mt-auto"">
                <div class=""container-fluid"">
                    <div class=""d-flex align-items-center justify-content-between small"">
                        <div class=""text-muted"">Copyright &copy; Your Website 2020</div>
                        <div>
                            <a href=""#"">Privacy Policy</a>
                            &middot;
                            <a href=""#"">Terms &amp; Conditions</a>
                        </div>
                    </div>
             ");
                WriteLiteral(@"   </div>
            </footer>
        </div>
    </div>

    <script src=""http://cdn.jsdelivr.net/particles.js/2.0.0/particles.min.js""></script> <!-- stats.js lib -->
    <script src=""http://threejs.org/examples/js/libs/stats.min.js""></script>
    <script>
        particlesJS(""particles-js"", { ""particles"": { ""number"": { ""value"": 80, ""density"": { ""enable"": true, ""value_area"": 800 } }, ""color"": { ""value"": ""#ffffff"" }, ""shape"": { ""type"": ""circle"", ""stroke"": { ""width"": 0, ""color"": ""#000000"" }, ""polygon"": { ""nb_sides"": 5 }, ""image"": { ""src"": ""img/github.svg"", ""width"": 100, ""height"": 100 } }, ""opacity"": { ""value"": 0.5, ""random"": false, ""anim"": { ""enable"": false, ""speed"": 1, ""opacity_min"": 0.1, ""sync"": false } }, ""size"": { ""value"": 3, ""random"": true, ""anim"": { ""enable"": false, ""speed"": 40, ""size_min"": 0.1, ""sync"": false } }, ""line_linked"": { ""enable"": true, ""distance"": 150, ""color"": ""#ffffff"", ""opacity"": 0.4, ""width"": 1 }, ""move"": { ""enable"": true, ""speed"": 6, ""direction"": ""none"", ""random"": false, ""straigh");
                WriteLiteral(@"t"": false, ""out_mode"": ""out"", ""bounce"": false, ""attract"": { ""enable"": false, ""rotateX"": 600, ""rotateY"": 1200 } } }, ""interactivity"": { ""detect_on"": ""canvas"", ""events"": { ""onhover"": { ""enable"": true, ""mode"": ""repulse"" }, ""onclick"": { ""enable"": true, ""mode"": ""push"" }, ""resize"": true }, ""modes"": { ""grab"": { ""distance"": 400, ""line_linked"": { ""opacity"": 1 } }, ""bubble"": { ""distance"": 400, ""size"": 40, ""duration"": 2, ""opacity"": 8, ""speed"": 3 }, ""repulse"": { ""distance"": 200, ""duration"": 0.4 }, ""push"": { ""particles_nb"": 4 }, ""remove"": { ""particles_nb"": 2 } } }, ""retina_detect"": true }); var count_particles, stats, update; stats = new Stats; stats.setMode(0); stats.domElement.style.position = 'absolute'; stats.domElement.style.left = '0px'; stats.domElement.style.top = '0px'; document.body.appendChild(stats.domElement); count_particles = document.querySelector('.js-count-particles'); update = function () { stats.begin(); stats.end(); if (window.pJSDom[0].pJS.particles && window.pJSDom[0].pJS.particles.array) { count_pa");
                WriteLiteral("rticles.innerText = window.pJSDom[0].pJS.particles.array.length; } requestAnimationFrame(update); }; requestAnimationFrame(update);;\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
