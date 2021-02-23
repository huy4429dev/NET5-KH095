#pragma checksum "E:\project\c#\KH095\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31504de588f0514b7b74f9adf1369af24d072053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31504de588f0514b7b74f9adf1369af24d072053", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/product/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
  
    var Categories = HttpContextAccessor.HttpContext.Session.Get<List<ProductType>>("categories");
    var cart = HttpContextAccessor.HttpContext.Session.Get<List<CartItem>>("cart");


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31504de588f0514b7b74f9adf1369af24d0720534845", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta name=""description"" content=""Shop"" />
    <title>Document</title>
    <link
      rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.css""
    />
    <link
      href=""https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,400;0,600;0,700;0,800;1,300&display=swap""
      rel=""stylesheet""
    />
    <link
      rel=""stylesheet""
      href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css""
    />
    <script
			src=""https://kit.fontawesome.com/8adbf22b30.js""
			crossorigin=""anonymous""
    ></script>

");
#nullable restore
#line 33 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("Css"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Css", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
                                            

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
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
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31504de588f0514b7b74f9adf1369af24d0720537142", async() => {
                WriteLiteral(@"
    <nav class=""nav"">
      <div class=""container d-flex space-between"">
        <div class=""logo"">
          <a href=""/"">
            <div class=""logo-image"">
              <img src=""/images/Logo.png"" />
            </div>
          </a>
        </div>
        <div class=""search-container"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31504de588f0514b7b74f9adf1369af24d0720537726", async() => {
                    WriteLiteral("\r\n            <input type=\"text\" placeholder=\"Tìm kiếm\" name=\"q\" style=\"margin-left:-50px\"/>\r\n            <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n          ");
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
                WriteLiteral("\r\n        </div>\r\n        <ul class=\"menu__list\">\r\n");
#nullable restore
#line 56 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
           foreach (var item in Categories)
          {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"menu__item d-flex\">\r\n            <div class=\"dropdown\">\r\n              <a href=\"#\" class=\"item__link\">");
#nullable restore
#line 60 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n              <div class=\"dropdown-content\">\r\n                <div class=\"dropdown-list\">\r\n");
#nullable restore
#line 63 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
                   foreach (var child in item.ProductTypeChildrens)
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h6><a");
                BeginWriteAttribute("href", " href=\"", 2192, "\"", 2235, 2);
                WriteAttributeValue("", 2199, "/product/search?categoryId=", 2199, 27, true);
#nullable restore
#line 65 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2226, child.Id, 2226, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 65 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
                                                                  Write(child.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h6>\r\n");
#nullable restore
#line 66 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
                      
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n              </div>\r\n            </div>\r\n              <a href=\"#\" class=\"fixed-center\">\r\n                  <i class=\"fas fa-sort-down\"></i>\r\n              </a>\r\n            </li>\r\n");
#nullable restore
#line 75 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"

          }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n");
                WriteLiteral("        </ul>\r\n        <div class=\"menu__icon\">\r\n          <i\r\n            class=\"fa fa-shopping-cart\"\r\n            style=\"font-size: 30px; color: #ffffff;margin-top:5px\"\r\n          ></i>\r\n          <span class=\"cart-total\">\r\n            ");
#nullable restore
#line 141 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
        Write(cart?.Count() != null ? cart.Count : 0 );

#line default
#line hidden
#nullable disable
                WriteLiteral(@" item(s) - 0 đ
          </span>
          <a href=""#"" class=""fixed-center"">
            <i class=""fas fa-sort-down""></i>
        </a>
        </div>
      </div>
    </nav>
    <header class=""header"">
      <div class=""container"">
        <div class=""row align-center"">
          <div class=""phone"">
            <h6>1900636100</h6>
          </div>
          <div class=""love d-flex"">
            <div class=""image"">
                <img
                src=""/images/love.png""
                style=""margin: 0px auto 0px auto""
            /></a>
            </div>
            <a href=""#"" id=""wishlist-total"" class=""wish_details"" rel=""nofollow"" style=""color:grey""
              >Yêu thích (0)</a
            >
          </div>
          <div class=""welcome"">
            Xin chào! Bạn có thể
            <a rel=""nofollow"" style=""color:black"" href=""https://www.bexinhshop.vn/login""
              >Đăng Nhập</a
            >
            hoặc
            <a rel=""nofollow"" style=""color:black"" hr");
                WriteLiteral("ef=\"https://www.bexinhshop.vn/register\"\r\n              >tạo Tài Khoản</a\r\n            >\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </header>\r\n");
#nullable restore
#line 179 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<footer class=""footer"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-3"">
                <h5><b>Chăm sóc khách hàng</b></h5>
                <h6 class=""mt-20"">Hotline: <a href=""#"">1900 636100</a></h6>
                <h6>Điện thoại: <a href=""#"">028.7300.6800</a></h6>
                <h6>ZALO: <a href=""#"">093.8100.276</a></h6>
                <h6>Làm việc: 8h00 - 17h00 từ Th2 - Th7</h6>
                <h6>Địa chỉ: 115/17B Hưng Phú, P.8, Q.8, TP.HCM</h6>
            </div>
            <div class=""col-3 text-center"">
                <h5><b>Danh mục sản phẩm</b></h5>
                <h6 class=""mt-20""><a href=""#"">Quần áo bé trai</a></h6>
                <h6><a href=""#"">Quần áo bé gái</a></h6>
                <h6><a href=""#"">Xem tất cả danh mục</a></h6>
            </div>
            <div class=""col-3"">
                <h5><b>Qui định chính sách</b></h5>
                <h6 class=""mt-20""><a href=""#"">Qui định đổi trả hàng</a></h6>
                <h6><a hre");
                WriteLiteral(@"f=""#"">Chính sách vận chuyển</a></h6>
                <h6><a href=""#"">Về chúng tôi</a></h6>
            </div>
            <div class=""col-3"">
                <div class=""footer-image"">
                    <img src=""/images/iFrame.png"" />
                </div>
            </div>
        </div>
    </div>
</footer>
<div class=""about"">
    <div class=""about-title"">
        <h4><b style=""color:grey"">BÉ XINH SHOP - THỜI TRANG TRẺ EM</b></h4>
    </div>
    <div class=""description"">
        <h6 style=""color:grey"">""Bé xinh shop chuyên bán quần áo trẻ em online Đẹp - Rẻ - Uy Tín tại Tphcm, giao hàng tận
            nơi trên Toàn quốc. Cam kết:<br /> Hàng chất lượng, mẫu mã đa dạng, đổi trả hàng nếu không vừa ý.""</h6>
    </div>
    <div class=""powered mt-30"">
        <h6>TOP TÌM KIẾM:<a href=""#""> Bộ bé gái đẹp </a> | <a href=""#"">Đồ bé trai sành điệu</a> | <a href=""#"">Quần áo
                trẻ em size đại</a> | <a href=""#"">Đầm trẻ em đẹp</a> | <a href=""#"">Quần áo bé đi chơi</a> | <a
          ");
                WriteLiteral("      href=\"#\">Thời trang thu đông</a> | <a href=\"#\">Bộ trẻ em mùa hè</a> <br />\r\n            © Bé xinh shop 2020 - Trang mua sắm online Quan ao tre em, Thoi trang tre em, Thoi trang cho be</h6>\r\n    </div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 227 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
 if (IsSectionDefined("Script"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
Write(RenderSection("Script", required:false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 229 "E:\project\c#\KH095\Views\Shared\_Layout.cshtml"
                                            
}

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
