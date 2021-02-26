#pragma checksum "E:\project\c#\KH095\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d5a9a03f4b07b4f72776075be1643913f118a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d5a9a03f4b07b4f72776075be1643913f118a8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/owl-carousel/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "E:\project\c#\KH095\Views\Home\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""styles.css"" />
    <link rel=""stylesheet"" href=""_responsive.css"" />
    <link rel=""stylesheet"" href=""/lib/owl-carousel/assets/owl.carousel.min.css"" />
    <link rel=""stylesheet"" href=""/lib/owl-carousel/assets/owl.theme.default.css"" />
    <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
      $(document).ready(function(){
      $('.owl-carousel').owlCarousel({
        loop:true,
        margin:0,
        nav:true,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:3
            },
            1000:{
                items:5
            }
        }
            });
        });
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""banner"" style=""margin-top: 0px"">
  <a>
    <img src=""images/banner-style-street.jpg"" style=""margin: 0px auto 0px auto"" /></a>

  <div id=""adverts"">
    <div class=""row"">
      <div class=""adverts-item col-4"">
        <a href=""#"" rel=""nofollow"">
          <span class=""text-advert-header"">Giao hàng miễn phí</span>
          <span class=""text-advert-subheader"">Đơn hàng từ 250K</span>
        </a>
      </div>
      <div class=""adverts-item col-4"">
        <a rel=""nofollow"" href=""#"">
          <span class=""text-advert-header"">Dễ dàng đổi trả hàng</span>
          <span class=""text-advert-subheader"">Trong vòng 3 ngày</span>
        </a>
      </div>
      <div class=""adverts-item col-4"">
        <a rel=""nofollow"" href=""#"">
          <span class=""text-advert-header"">Đặt hàng trực tuyến</span>
          <span class=""text-advert-subheader"">Hotline : 1900.636.100</span>
        </a>
      </div>
    </div>
  </div>
</div>

<div class=""hot-product"">
  <div class=""title"">
    <h");
            WriteLiteral("2 class=\"title-description\">Sản phẩm hot trong tuần</h2>\r\n  </div>\r\n  <div class=\"row mt-50\">\r\n");
#nullable restore
#line 67 "E:\project\c#\KH095\Views\Home\Index.cshtml"
     foreach (var item in ViewBag.ProductHots)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-3\">\r\n      <div class=\"product\">\r\n        <div class=\"product-image\">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 2099, "\"", 2123, 2);
            WriteAttributeValue("", 2106, "/product/", 2106, 9, true);
#nullable restore
#line 72 "E:\project\c#\KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 2115, item.Id, 2115, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2143, "\"", 2160, 1);
#nullable restore
#line 73 "E:\project\c#\KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 2149, item.Image, 2149, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n          </a>\r\n        </div>\r\n        <div class=\"description\">\r\n          <h6>\r\n            ");
#nullable restore
#line 78 "E:\project\c#\KH095\Views\Home\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </h6>\r\n        </div>\r\n        <div class=\"price\">\r\n          <h6>");
#nullable restore
#line 82 "E:\project\c#\KH095\Views\Home\Index.cshtml"
         Write(item.Price.ToString("N3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</h6>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 86 "E:\project\c#\KH095\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>
</div>

<div class=""product-category"">
  <div class=""title"">
    <h2 class=""title-description"">Danh mục sản phẩm</h2>
  </div>
  <div class=""category"">
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/1.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/2.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/3.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/4.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
 ");
            WriteLiteral(@"     </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/5.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/6.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/7.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
    <div class=""category-card"">
      <div class=""category-image"">
        <img src=""images/category/8.jpg"" />
      </div>
      <div class=""description"">
        <h6>Quần áo bé gái</h6>
      </div>
    </div>
  </div>
</div>

<div class=""children-fashion"">
  <div class=""title"">
    <h2 class=""title-description"">Thời trang");
            WriteLiteral(" trẻ em mới về</h2>\r\n  </div>\r\n  <div class=\"row mt-50\">\r\n");
#nullable restore
#line 167 "E:\project\c#\KH095\Views\Home\Index.cshtml"
   foreach (var item in ViewBag.ProductNews)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-3\">\r\n      <div class=\"product\">\r\n        <div class=\"product-image\">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 4697, "\"", 4721, 2);
            WriteAttributeValue("", 4704, "/product/", 4704, 9, true);
#nullable restore
#line 172 "E:\project\c#\KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 4713, item.Id, 4713, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 4741, "\"", 4758, 1);
#nullable restore
#line 173 "E:\project\c#\KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 4747, item.Image, 4747, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n          </a>\r\n        </div>\r\n        <div class=\"description\">\r\n          <h6>\r\n            ");
#nullable restore
#line 178 "E:\project\c#\KH095\Views\Home\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </h6>\r\n        </div>\r\n        <div class=\"price\">\r\n          <h6>");
#nullable restore
#line 182 "E:\project\c#\KH095\Views\Home\Index.cshtml"
         Write(item.Price.ToString("N3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</h6>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 186 "E:\project\c#\KH095\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>
  <div class=""show-more-btn"">
    <a style=""color: gray;""  href=""/product/search"">Xem thêm</a>
  </div>
</div>

<div class=""popular-product"">
        <div class=""container"">
          <div class=""row"" style=""margin:10px 0px;"">
            <h6 class=""popular-product-description"">Mới được đặt hàng</h6>
            <h6 class=""popular-product-description"" style=""color:black;background: #EEE;width: 87.5%;"">Phổ biến</h6>
          </div>
          <div class=""row owl-carousel owl-theme"">
");
#nullable restore
#line 200 "E:\project\c#\KH095\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.ProductHots)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"popular-product-image\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 5685, "\"", 5709, 2);
            WriteAttributeValue("", 5692, "/product/", 5692, 9, true);
#nullable restore
#line 203 "E:\project\c#\KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 5701, item.Id, 5701, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5737, "\"", 5754, 1);
#nullable restore
#line 204 "E:\project\c#\KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 5743, item.Image, 5743, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                  </a>\r\n                </div>\r\n");
#nullable restore
#line 207 "E:\project\c#\KH095\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </div>\r\n        </div>\r\n      </div>\r\n\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7d5a9a03f4b07b4f72776075be1643913f118a813898", async() => {
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
