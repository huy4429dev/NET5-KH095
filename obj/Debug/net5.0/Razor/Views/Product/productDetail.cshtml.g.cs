#pragma checksum "E:\project\c#\KH095\Views\Product\productDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89cf074ae71587ca560335d2391de1b5ce70dd3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_productDetail), @"mvc.1.0.view", @"/Views/Product/productDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cf074ae71587ca560335d2391de1b5ce70dd3f", @"/Views/Product/productDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_productDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addcart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/style-product-detail.css\" />\r\n    <link rel=\"stylesheet\" href=\"/_responsive.css\" />\r\n");
            }
            );
            WriteLiteral(@"      <div class=""breadcrumbs"">
        <div class=""container"">
          <ul class=""breadcrumb"">
            <li><a href=""#"">Trang chủ</a></li>
            <li><a href=""#"">Danh mục sản phẩm</a></li>
            <li><a href=""#"">Thời trang trẻ em</a></li>
            <li><a href=""#"">Quần áo bé trai</a></li>
            <li><a href=""#"">Đồ bộ bé trai</a></li>
          </ul>
        </div>
      </div>
      <div class=""product-content"">
        <div class=""container"">
          <div class=""title text-center"" style=""margin:30px 0px 30px 0px;"">
            <h5 style=""font-size:22px;color:black;"">");
#nullable restore
#line 23 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                                               Write(Model?.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n          </div>\r\n          <div class=\"product-detail\">\r\n            <div class=\"row\">\r\n              <div class=\"product-images\">\r\n                <div class=\"row\">\r\n                  <div class=\"product-thumbnails\">\r\n");
#nullable restore
#line 30 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                      
                        var images = Model.Images.Split(",");
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                     foreach (var item in images)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"thumbnail\">\r\n                           <img");
            BeginWriteAttribute("src", " src=\"", 1300, "\"", 1311, 1);
#nullable restore
#line 36 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
WriteAttributeValue("", 1306, item, 1306, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n");
#nullable restore
#line 38 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </div>\r\n                  <div class=\"product-full-image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1474, "\"", 1492, 1);
#nullable restore
#line 41 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
WriteAttributeValue("", 1480, Model.Image, 1480, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                  </div>  \r\n                </div>\r\n                <div class=\"product-description\">\r\n                 ");
#nullable restore
#line 45 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
            Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n\r\n              <div class=\"product-description-board\">\r\n                <div class=\"price\">\r\n                  <h5>");
#nullable restore
#line 51 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                 Write(Model.Price.ToString("N3"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</h5>
                </div>
                <div class=""size"">
                  <div class=""title"">
                    <h6><b>CHỌN KÍCH CỠ</b></h6>
                  </div>
                  <div class=""att-board"">
                    <h6 style=""font-size:12px;"">Màu sắc</h6>
                    <div class=""mt-20"">
                      <div class=""att-options"">
");
#nullable restore
#line 61 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                            
                              var colors = Model.Colors.Split(",");
                          

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                               foreach (var item in colors)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label");
            BeginWriteAttribute("for", " for=\"", 2468, "\"", 2474, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"item-option\">Màu ");
#nullable restore
#line 66 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                                                             Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 67 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </div>
                    </div>
                    <h6 style=""font-size:12px;margin-top:15px;"">
                      Kích thước (<u>Xem chi tiết kích cỡ)</u>
                      <a href=""#"" class=""fixed-center-sm"" style=""color:black;"">
                        <i class=""fas fa-sort-down""></i>
                    </a>
                    </h6>
                    <div class=""mt-10"">
                      <div class=""att-options"">
");
#nullable restore
#line 78 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                            
                              var sizes = Model.Sizes.Split(",");
                          

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                           foreach (var item in sizes)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <label");
            BeginWriteAttribute("for", " for=\"", 3261, "\"", 3267, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"item-option\">");
#nullable restore
#line 83 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                                                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 84 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </div>
                    </div>
                  </div>
                  <div class=""mt-20"">
                    <div class=""row"" style=""padding-left:15px;"">
                      <h6 style=""margin-top:5px;"" >Số lượng:</h6>
                      <div class=""select-quantity-box"">
                        <select name=""quantity"" id=""quantity"">
                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cf074ae71587ca560335d2391de1b5ce70dd3f13135", async() => {
                WriteLiteral("1");
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
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cf074ae71587ca560335d2391de1b5ce70dd3f14316", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cf074ae71587ca560335d2391de1b5ce70dd3f15497", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cf074ae71587ca560335d2391de1b5ce70dd3f16678", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cf074ae71587ca560335d2391de1b5ce70dd3f17859", async() => {
                WriteLiteral("5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"cart\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89cf074ae71587ca560335d2391de1b5ce70dd3f19203", async() => {
                WriteLiteral("\r\n                      <input type=\"text\" name=\"id\" hidden");
                BeginWriteAttribute("value", " value=\"", 4263, "\"", 4280, 1);
#nullable restore
#line 104 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
WriteAttributeValue("", 4271, Model.Id, 4271, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                     <input type=\"submit\" value=\"MUA NGAY\" id=\"button-cart\"  class=\"addtocart\" style=\"margin: 0px !important;\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                  </div>
                  <div class=""love d-flex mt-30"">
                    <div class=""image"">
                        <img
                        src=""/images/love.png""
                        style=""margin: 0px auto 0px auto""
                    /></a>
                    </div>
                    <a href=""#"" id=""wishlist-total"" class=""wish_details"" rel=""nofollow"" style=""color:grey;font-size:12px;""
                      ><u>Yêu thích</u></a
                    >
                  </div>
                  <div class=""note"">
                    <h6>
                      <b style=""color:green;font-size:15px;"">- Miễn phí vẫn chuyển</b>
                      đơn hàng từ 500.000đ trên Toàn quốc. Riêng TPHCM, miễn phí đơn hàng từ 250.000đ.
                    </h6>
                    <h6 style=""color:green;"">
                      BÉ XINH CAM KẾT:
                    </h6>
                    <h6>
                      - KHÔNG bán hàng kém chất lượng.
               ");
            WriteLiteral(@"     </h6>
                    <h6>
                      - Sản phẩm y như hình
                    </h6>
                    <h6>
                      - Đổi trả dễ dàng nếu không vừa ý.
                    </h6>
                    <h6>
                      - Sẽ có mặt tại nhà bạn từ 1-5 ngày làm việc.
                    </h6>
                  </div>
                  <div class=""mt-20"">
                    <div class=""tag row"">
                      <h6><i>Từ khóa:</i><span style=""color:#F5447B"">
                          ");
#nullable restore
#line 143 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                     Write(string.Join(", ",Model.ProductTags.Select(item => item.Tag.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                      </span></h6>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""popular-product"">
        <div class=""container"">
          <div class=""popular-product-board"">
            <div class=""title mb-20"">
              <h6>Có thể bạn quan tâm</h6>
            </div>
            <div class=""popular-product-box"">
");
#nullable restore
#line 160 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
               foreach (var item in ViewBag.productPopular)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product-image\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 6694, "\"", 6718, 2);
            WriteAttributeValue("", 6701, "/product/", 6701, 9, true);
#nullable restore
#line 163 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
WriteAttributeValue("", 6710, item.Id, 6710, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 6724, "\"", 6741, 1);
#nullable restore
#line 163 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
WriteAttributeValue("", 6730, item.Image, 6730, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6742, "\"", 6748, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n");
#nullable restore
#line 165 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""owl-buttons"">
              <div class=""owl-next text-center"">&rsaquo;</div>
              <div class=""owl-prev text-center"">&lsaquo;</div>
            </div>
          </div>
        </div>
      </div>
      <div class=""content-detail"">
        <div class=""container"">
          <div class=""tab row"">
            <div class=""tab-item"" style=""width:5%;background-color: #F5447B;
            color: white;"" >
              <h6>Mô tả</h6>  
            </div>
            <div class=""tab-item"" style=""width:12%"">
              <h6>Phí vẫn chuyển</h6>  
            </div>
            <div class=""tab-item""style=""width:83%"">
              <h6>Bảng size</h6>  
            </div>
          </div>
          <div class=""product-content-detail"">
            <div class=""title mt-20 mb-20"">
              <h4><b>");
#nullable restore
#line 190 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n            </div>\r\n            <div class=\"product-att\">\r\n              <h6>Thuộc tính sản phẩm</h6>\r\n              <div class=\"product-att-detail\">\r\n                 ");
#nullable restore
#line 195 "E:\project\c#\KH095\Views\Product\productDetail.cshtml"
            Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
              </div>
              <div class=""product-full-images"">
                <div class=""product-image-board"">
                  <img src=""/images/setthuncotruquankakixam.jpg"" />
                </div>
                <div class=""product-image-board"">
                  <img src=""/images/setcotruden.jpg"" />
                </div>
                <div class=""product-image-board"">
                  <img src=""/images/setcotrudentrang.jpg"" />
                </div>
              </div>
            </div>
            <div class=""guide"">
              <div class=""guide-title"">
                <h4><b>CÁCH GIẶT ỦI VÀ BẢO QUẢN QUẦN ÁO TRẺ EM</b> </h4>
              </div>
              <div class=""guide-description"">
                <h6>- Vò bằng tay với lần giặt đầu tiên, giặt bằng nước lã và không có xà phòng
                   để lớp in mềm hơn, chống bong tróc. Nên giặt sản phẩm bằng nước lạnh 
                   hoặc nước nóng dưới 40 độ vì nếu giặt trong nước quá nóng sẽ làm vải giãn");
            WriteLiteral(@" ra và lỏng sản phẩm.
                </h6>
                <h6>- Để giữ màu sản được lâu và không bị ra màu trong quá trình giặt, mẹ có thể ngâm sản phẩm trong nước ấm 
                  có pha chút giấm trong khoảng 15-20 phút.
                </h6>
                <h6>- Không đổ trực tiếp các loại xà bông hoặc nước tẩy lên hình in. Mẹ nên hạn chế dùng các loại nước xả mềm vải vì nó sẽ làm sản phẩm bị giãn rất nhanh và khiến hình in bị mềm, dễ bong tróc. Nế n muốn sản phẩm thơm 
                  hơn sau khi giặt, mẹ có thể dùng các loại nước xả thơm.
                </h6>
                <h6>- Không nên để sản phẩm ở những nơi ẩm ướt, với tính chất hút ẩm, hút nước tốt, sản phẩm dễ bị ẩm mốc, thậm chí để lại những vết ố trên vải. Tránh phơi sản phẩm 
                  trực tiếp dưới nắng vì sẽ làm màu và hình in phai màu.
                </h6>
                <h6>- Khi ủi sản phẩm tuyệt đối không được ủi lên bề mặt in hình trên sản phẩm, nên ủi ở nhiệt độ thấp và lộn trái sản phẩm ra trước khi ủ");
            WriteLiteral(@"i để tránh làm chết màu sắc của vải và làm bong tróc
                   hay biến dạng những hình ảnh được in trên sản phẩm.
                </h6>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""hot-product"">
        <div class=""container"">
          <div class=""hot-product-board"">
            <div class=""title"" style=""margin-bottom:10px"">
              <h6>SẢN PHẨM HOT TRONG TUẦN</h6>
            </div>
            <div class=""hot-product-box"">
              <div class=""product-image"">
                <a href=""#""><img src=""/images/hot-product/boreboktrang.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10574, "\"", 10580, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n              </div>\r\n              <div class=\"product-image\">\r\n                <a href=\"#\"><img src=\"/images/hot-product/SETJEANSCOTRUNYDO.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 10733, "\"", 10739, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n              </div>\r\n              <div class=\"product-image\">\r\n                <a href=\"#\"><img src=\"/images/hot-product/setjeansmeotomdo.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 10891, "\"", 10897, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n              </div>\r\n              <div class=\"product-image\">\r\n                <a href=\"#\"><img src=\"/images/hot-product/setjeansmeotomvang1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11052, "\"", 11058, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n              </div>\r\n              <div class=\"product-image\">\r\n                <a href=\"#\"><img src=\"/images/hot-product/setthuncotruquankakixam.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11217, "\"", 11223, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
              </div>
            </div>
            <div class=""owl-buttons"">
              <div class=""owl-next text-center"">&rsaquo;</div>
              <div class=""owl-prev text-center"">&lsaquo;</div>
            </div>
          </div>
        </div>
      </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
