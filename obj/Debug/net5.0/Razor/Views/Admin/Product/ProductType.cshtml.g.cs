#pragma checksum "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f3396df4ac4afdb3fe8c265daae410ee95b425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Product_ProductType), @"mvc.1.0.view", @"/Views/Admin/Product/ProductType.cshtml")]
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
#line 1 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\_ViewImports.cshtml"
using KH095;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\_ViewImports.cshtml"
using KH095.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\_ViewImports.cshtml"
using KH095.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f3396df4ac4afdb3fe8c265daae410ee95b425", @"/Views/Admin/Product/ProductType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Product_ProductType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/product/producttype/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/product/producttype"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "LOẠI SẢN PHẨM";
    ViewBag.PageName = "LOẠI SẢN PHẨM";
    ViewBag.Link = "/admin/product/producttype";
    var user = ViewData["User"] as User;
    
    List<ProductType> ProductTypes = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n   <style>\r\n       \r\n     /* Styles for validation helpers\r\n-----------------------------------------------------------*/\r\n\r\n\r\n    .alert.alert-danger.validation-summary-valid {\r\n        display: none;\r\n    }\r\n   </style>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n                    <div class=\"card mb-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b4256814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 27 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            \r\n");
#nullable restore
#line 29 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 32 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 34 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b4259461", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm loại sản phẩm"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                            <div class=""input-group-append"">
                                                <button type=""submit"" class=""input-group-text"" id=""basic-addon2"">Tìm kiếm</button>
                                            </div>
                                    </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                            <div class=""card-header d-flex justify-content-between "">
                                <span>
                                    <i class=""fas fa-table mr-1""></i>
                                    Danh sản phẩm loại sản phẩm
                                </span>
                                 <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#addCategory"" >Thêm mới</button>
                            </div>
                         
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Loại sản phẩm</th>
                                ");
            WriteLiteral(@"                <th>Mô tả</th>
                                                <th colspan=""2"" class=""text-center"">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 66 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                              
                                                int index = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                             foreach (var item in ProductTypes)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 72 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 73 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 74 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"width: 100px\"><button class=\"btn btn-sm btn-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#editCategory");
#nullable restore
#line 75 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                                                                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sửa</button></td>\r\n                                                    <td style=\"width: 100px\"><button class=\"btn btn-danger btn-sm\"  type=\"button\" data-toggle=\"modal\" data-target=\"#deleteModal");
#nullable restore
#line 76 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                                                                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Xóa</button></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"

                                                index ++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                     </div>\r\n\r\n");
            WriteLiteral(@"     <div class=""modal fade"" id=""addCategory"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm Loại Sản Phẩm</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b42517072", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tên loại:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""name"">
                </div>
                <div class=""form-group"">
                    <label for=""message-text"" class=""col-form-label"">Mô tả:</label>
                    <textarea class=""form-control"" id=""message-text"" name=""description""></textarea>
                </div>
                <div class=""form-group"">
                        <label for=""message-text"" class=""col-form-label"">Danh mục cha:</label>
                        <select name=""TypeParentId"" class=""custom-select"">
                             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b42518153", async() => {
                    WriteLiteral("Không lựa chọn");
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
                WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                             foreach (var item in ProductTypes)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b42519724", async() => {
#nullable restore
#line 114 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                WriteLiteral(item.Id);

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
#line 115 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                           
                        </select>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Lưu</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n     </div>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
        foreach (var item in ProductTypes)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 6481, "\"", 6508, 2);
            WriteAttributeValue("", 6486, "editCategory", 6486, 12, true);
#nullable restore
#line 133 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
WriteAttributeValue("", 6498, item.Id, 6498, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Chỉnh Sửa Loại Sản Phẩm</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b42524839", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tên Loại:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""name""");
                BeginWriteAttribute("value", " value=\"", 7292, "\"", 7312, 1);
#nullable restore
#line 147 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
WriteAttributeValue("", 7300, item.Name, 7300, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"message-text\" class=\"col-form-label\">Mô Tả:</label>\r\n                    <textarea class=\"form-control\" id=\"message-text\" name=\"description\">");
#nullable restore
#line 151 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                </div>\r\n");
#nullable restore
#line 153 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                 if(item.ProductTypeParent != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label for=\"message-text\" class=\"col-form-label\">Danh mục cha:</label>\r\n                        <label for=\"message-text\" class=\"col-form-label\">");
#nullable restore
#line 156 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                                                                    Write(item.ProductTypeParent.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 158 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Lưu</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6981, "/admin/product/producttype/update/", 6981, 34, true);
#nullable restore
#line 142 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
AddHtmlAttributeValue("", 7015, item.Id, 7015, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n     </div>\r\n     </div>\r\n     </div>\r\n");
#nullable restore
#line 168 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 173 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
        foreach (var item in ProductTypes){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 8397, "\"", 8423, 2);
            WriteAttributeValue("", 8402, "deleteModal", 8402, 11, true);
#nullable restore
#line 175 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
WriteAttributeValue("", 8413, item.Id, 8413, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Delete Category</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn đồng ý xóa loại sản phẩm này ?
            </div>
            <div class=""modal-footer"">
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f3396df4ac4afdb3fe8c265daae410ee95b42531264", async() => {
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Hủy</button>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Lưu</button>\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9126, "/admin/product/producttype/delete/", 9126, 34, true);
#nullable restore
#line 188 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
AddHtmlAttributeValue("", 9160, item.Id, 9160, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 196 "C:\Users\Johnathan Tran\Desktop\New folder (6)\NET5-KH095\Views\Admin\Product\ProductType.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   <script>\r\n\r\n       \r\n   </script>\r\n");
            }
            );
            WriteLiteral("   ");
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
