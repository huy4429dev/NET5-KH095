#pragma checksum "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cbde6190decde721e55ffd85f497829e9439d6f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cbde6190decde721e55ffd85f497829e9439d6f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"styles.css\" />\r\n    <link rel=\"stylesheet\" href=\"_responsive.css\" />\r\n");
            }
            );
            WriteLiteral(@"<div class=""banner"" style=""margin-top: 0px"">
  <a href=""https://www.bexinhshop.vn/set-ao-croptop-quan-tole-alibaba-hoa-tiet-de-thuong-cho-be-gai-3-8-tuoi-bgb118181.html""
    onclick=""ga('send', 'event', 'BannerHome1', 'clickBanner', 'set-alibaba');"">
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
          <span class=""text-advert-header"">Đặt hàng trực tuyến<");
            WriteLiteral(@"/span>
          <span class=""text-advert-subheader"">Hotline : 1900.636.100</span>
        </a>
      </div>
    </div>
  </div>
</div>

<div class=""hot-product"">
  <div class=""title"">
    <h2 class=""title-description"">Sản phẩm hot trong tuần</h2>
  </div>
  <div class=""row mt-50"">
");
#nullable restore
#line 42 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
     foreach (var item in ViewBag.ProductHots)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-3\">\r\n      <div class=\"product\">\r\n        <div class=\"product-image\">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 1630, "\"", 1654, 2);
            WriteAttributeValue("", 1637, "/product/", 1637, 9, true);
#nullable restore
#line 47 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 1646, item.Id, 1646, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1674, "\"", 1691, 1);
#nullable restore
#line 48 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 1680, item.Image, 1680, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n          </a>\r\n        </div>\r\n        <div class=\"description\">\r\n          <h6>\r\n            ");
#nullable restore
#line 53 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </h6>\r\n        </div>\r\n        <div class=\"price\">\r\n          <h6>");
#nullable restore
#line 57 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
         Write(item.Price.ToString("N3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</h6>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
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
#line 142 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
   foreach (var item in ViewBag.ProductNews)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-3\">\r\n      <div class=\"product\">\r\n        <div class=\"product-image\">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 4228, "\"", 4252, 2);
            WriteAttributeValue("", 4235, "/product/", 4235, 9, true);
#nullable restore
#line 147 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 4244, item.Id, 4244, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 4272, "\"", 4289, 1);
#nullable restore
#line 148 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
WriteAttributeValue("", 4278, item.Image, 4278, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n          </a>\r\n        </div>\r\n        <div class=\"description\">\r\n          <h6>\r\n            ");
#nullable restore
#line 153 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </h6>\r\n        </div>\r\n        <div class=\"price\">\r\n          <h6>");
#nullable restore
#line 157 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
         Write(item.Price.ToString("N3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</h6>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 161 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n  <div class=\"show-more-btn\">\r\n    <button style=\"border: none; outline: none;cursor: pointer;\">Xem thêm</button>\r\n  </div>\r\n</div>\r\n");
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
