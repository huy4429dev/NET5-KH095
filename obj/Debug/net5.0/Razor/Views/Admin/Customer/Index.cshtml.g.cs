#pragma checksum "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65fd7715e714c47138c96812e1c8e89b9b2c458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Customer_Index), @"mvc.1.0.view", @"/Views/Admin/Customer/Index.cshtml")]
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
#line 1 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65fd7715e714c47138c96812e1c8e89b9b2c458", @"/Views/Admin/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/customer/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "KHÁCH HÀNG";
    ViewBag.PageName = "KHÁCH HÀNG";
    ViewBag.Link = "/admin/customer";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                               

        List<User> Customers = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n   <style>\r\n    .alert.alert-danger.validation-summary-valid {\r\n        display: none;\r\n    }\r\n   </style>\r\n");
            }
            );
            WriteLiteral("\r\n <main>\r\n                     <div class=\"card mb-4\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65fd7715e714c47138c96812e1c8e89b9b2c4586308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 24 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
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
#line 26 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 29 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 31 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                             if(@TempData["error"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    ");
#nullable restore
#line 35 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                               Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 37 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65fd7715e714c47138c96812e1c8e89b9b2c4589583", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3 p-3"">
                                            <input name=""query"" type=""text"" class=""form-control"" placeholder=""Tìm khách hàng"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                                            <div class=""input-group-append"">
                                                <button type=""submit"" class=""input-group-text"" id=""basic-addon2""><i class=""fas fa-search""></i></button>
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
                                 <button type=""button"" class=""btn btn-primary btn-sm"" data-toggle=""modal"" data-target=""#addCustomer"" ><i class=""fas fa-plus""></i></button>
                            </div>
                         
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Avatar</th>
                                                <th>Tên khách hàng</th>
                                                <th>Điện thoại</th>
                                                <th>Email</th>
                               ");
            WriteLiteral(@"                 <th>Ngày tạo</th>
                                                <th>Trạng thái</th>
                                                <th colspan=""2"" class=""text-center"">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 69 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                              
                                                int index = 1;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                             foreach (var item in Customers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td style=\"width:80px\">");
#nullable restore
#line 75 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                                      Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                    <td style=""width:80px""><img style=""width:60px; border-radius: 50%"" src=""https://banner2.cleanpng.com/20180528/ccc/kisspng-computer-icons-user-avatar-woman-avatar-5b0c5b2f6ecaa1.2446433615275364314538.jpg"" /></td>
                                                    <td>");
#nullable restore
#line 77 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 78 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 79 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 80 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                   Write(item.CreatTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td style=\"width:110px\" class=\"text-center\">");
#nullable restore
#line 81 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                                                            Write(item.Status ? @Html.Raw("<i class='far fa-check-circle' style='color: green'></i>") : @Html.Raw("<i class='far fa-times-circle' style='color: red'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\"><button  style=\"font-size:10px\" class=\"btn btn-sm btn-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#editCustomer");
#nullable restore
#line 82 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                                                                                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-edit\"></i></button></td>\r\n                                                    <td class=\"text-center\"><button  style=\"font-size:10px\" class=\"btn btn-danger btn-sm\"  type=\"button\" data-toggle=\"modal\" data-target=\"#deleteModal");
#nullable restore
#line 83 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
                                                                                                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-trash\"></i></button></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 85 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"

                                                index ++;
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                     </div>\r\n </main>\r\n\r\n\r\n                   \r\n\r\n");
            WriteLiteral(@"     <div class=""modal fade"" id=""addCustomer"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Thêm Khách hàng</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65fd7715e714c47138c96812e1c8e89b9b2c45818599", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tài khoản (*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""username"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Mật khẩu (*):</label>
                    <input type=""password"" class=""form-control"" id=""recipient-name"" name=""password"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Họ (*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""FirstName"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tên (*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name""");
                WriteLiteral(@" name=""LastName"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Điện thoại:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""Phone"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Email:</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""Email"">
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Ngày sinh:</label>
                    <input type=""text"" class=""form-control"" id=""datepicker"" name=""BirthDate"">
                </div>

                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Trạng thái:</label>
                    <input class=""form-control"" type=""radio"" name=""status"">
               ");
                WriteLiteral(@"     <input class=""form-control"" type=""radio"" name=""status"">
                </div>
            
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Tạo</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
#line 157 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
        foreach (var item in Customers)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 8604, "\"", 8631, 2);
            WriteAttributeValue("", 8609, "editCustomer", 8609, 12, true);
#nullable restore
#line 159 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
WriteAttributeValue("", 8621, item.Id, 8621, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
        <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Cập nhật khách hàng</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65fd7715e714c47138c96812e1c8e89b9b2c45823971", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">

               <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Tài khoản (*):</label>
                    <input type=""text"" class=""form-control"" id=""recipient-name"" name=""username""");
                BeginWriteAttribute("value", " value=\"", 9408, "\"", 9430, 1);
#nullable restore
#line 173 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
WriteAttributeValue("", 9416, item.Username, 9416, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled >
                </div>
                <div class=""form-group"">
                    <label for=""recipient-name"" class=""col-form-label"">Mật khẩu (*):</label>
                    <input type=""password"" class=""form-control"" id=""recipient-name"" name=""password""  value=""******"">
                </div>
");
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Điện thoại:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"recipient-name\" name=\"Phone\"");
                BeginWriteAttribute("value", " value=\"", 10532, "\"", 10551, 1);
#nullable restore
#line 189 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
WriteAttributeValue("", 10540, item.Phone, 10540, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Email:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"recipient-name\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 10800, "\"", 10819, 1);
#nullable restore
#line 193 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
WriteAttributeValue("", 10808, item.Email, 10808, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"recipient-name\" class=\"col-form-label\">Ngày sinh:</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"datepicker\" name=\"BirthDate\"");
                BeginWriteAttribute("value", " value=\"", 11072, "\"", 11095, 1);
#nullable restore
#line 197 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
WriteAttributeValue("", 11080, item.BirthDate, 11080, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
             <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""status"" id=""exampleRadios1"" value=""option1"" checked>
            <label class=""form-check-label"" for=""exampleRadios1"">
                Đang hoạt động
            </label>
            </div>
            <div class=""form-check"">
            <input class=""form-check-input"" type=""radio"" name=""status"" id=""exampleRadios2"" value=""option2"" >
            <label class=""form-check-label"" for=""exampleRadios2"">
                Không hoạt động
            </label>
            </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""submit"" class=""btn btn-primary"">Cập nhật</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9100, "/admin/customer/update/", 9100, 23, true);
#nullable restore
#line 168 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
AddHtmlAttributeValue("", 9123, item.Id, 9123, 10, false);

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
#line 220 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 225 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
        foreach (var item in Customers){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 12144, "\"", 12170, 2);
            WriteAttributeValue("", 12149, "deleteModal", 12149, 11, true);
#nullable restore
#line 227 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
WriteAttributeValue("", 12160, item.Id, 12160, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Xóa khách hàng</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bạn chắc chắn xóa khách hàng này không ?
            </div>
            <div class=""modal-footer"">
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c65fd7715e714c47138c96812e1c8e89b9b2c45831347", async() => {
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Hủy</button>\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Xóa</button>\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 12878, "/admin/customer/delete/", 12878, 23, true);
#nullable restore
#line 240 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
AddHtmlAttributeValue("", 12901, item.Id, 12901, 10, false);

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
#line 248 "E:\project\c#\KH095\Views\Admin\Customer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   <script>\r\n        $( function() {\r\n            $( \"#datepicker\" ).datepicker();\r\n        } );\r\n        \r\n   </script>\r\n");
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
