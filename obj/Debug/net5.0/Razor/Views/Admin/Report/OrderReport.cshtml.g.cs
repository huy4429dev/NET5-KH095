#pragma checksum "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "594dc190ceebd1a8e0e58472d1aeda2ac639bc0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Report_OrderReport), @"mvc.1.0.view", @"/Views/Admin/Report/OrderReport.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
using KH095.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"594dc190ceebd1a8e0e58472d1aeda2ac639bc0e", @"/Views/Admin/Report/OrderReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Report_OrderReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "LƯỢT ";
    ViewBag.PageName = "BÁO CÁO SỐ LIỆU MUA SẢN PHẨM";
    ViewBag.Link = "/admin/report/order";
    var user = ViewData["User"] as User;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
                                                                            
    var dataChart  = new List<object>();
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""fix-center loading"" 
										style=""background:white; 
											   position: absolute; 
											   top: 0; left: 0; 
											   width:100%;
											   height:100%;
											   z-index: 4"">

										<img style=""position: absolute; top: 30%; width:50px""  src=""/assets/loading.gif""");
            BeginWriteAttribute("alt", " alt=\"", 697, "\"", 703, 0);
            EndWriteAttribute();
            WriteLiteral(@">
	</div>
<div class=""d-flex justify-content-end"">
    <div>
        <div class=""form-group"">
            <div class=""d-flex"">
                <a href=""/admin/report/order/excel"" class=""btn btn-success mr-1""><i class=""far fa-file-excel""></i></a>
            <input class=""form-control"" type=""text"" name=""datetimes"" />
            </div>
        </div>
    </div>
</div>
<div class=""row mt-4"">
    <div class=""col-12"">
        <h5 class=""text-center mb-5"" style=""font-weight:400;font-size:20px; color: #414141"">
            Biểu đồ thống kê số liệu mua sản phẩm <br />
            <small id=""time""></small> 
        </h5>
        <figure class=""highcharts-figure"">
            <div id=""container""></div>
        </figure>
    </div>
</div>
<div class=""row mt-4"">
    <div class=""col-10 mx-auto"">

    <table  class=""table"">
        <thead>
            <tr class=""text-center"">
                <th>Thời gian</th>
                <th>Lượt mua</th>
                <th>Lượt trả đúng hạn</th>
    ");
            WriteLiteral(@"            <th>Lượt trả trễ hạn</th>
                <th>Tiền nộp phạt</th>
                <th>Số sản phẩm mua</th>
                <th>Số khách hàng</th>
            </tr>
        </thead>
        <tbody id=""report-order-table"">
        </tbody>
        <tfoot id=""report-order-total"">
        </tfoot>
    </table>
    </div>
</div>

");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css\" />\r\n    <style>\r\n\t\t.fix-center{\r\n\t\t\tdisplay: none;\r\n\t\t}\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/jquery/latest/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/momentjs/latest/moment.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js""></script>
    <script>

		var fromDate = ");
#nullable restore
#line 84 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
                  Write(Html.Raw(Json.Serialize("")));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\t\tvar toDate = ");
#nullable restore
#line 85 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
                Write(Html.Raw(Json.Serialize("")));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
		
		$(function() {
            $('input[name=""datetimes""]').daterangepicker({
                timePicker: true,
                startDate: moment().add(-1, 'month'),
                endDate: moment(),
                locale: {
                format: 'DD/MM/YYYY'
                }
            },(start,end,label) => { getDataAjax(start,end,label)});
		});
    </script>
    <script>
            const startOfMonth = moment().clone().startOf('month').format('YYYY-MM-DD hh:mm');
            const endOfMonth   = moment().clone().endOf('month').format('YYYY-MM-DD hh:mm'); 
            const curentDate = moment().add('1','d');
            const lastMonth = moment(curentDate).add(-1,'M').add(-1,'day');
            const tableBodyReportOrder = document.querySelector('#report-order-table');
            const tableFooterReportOrder = document.querySelector('#report-order-total');
            

            const loading = document.querySelector('.fix-center');

            const time = document.");
                WriteLiteral("querySelector(\'#time\');\r\n            time.innerHTML = \'(\' +  moment(lastMonth).format(\"DD/MM/YYYY\") + \' - \' + moment(curentDate).format(\'DD/MM/YYYY\') + \')\'; \r\n            var data = ");
#nullable restore
#line 111 "C:\Users\Johnathan Tran\Desktop\New folder (5)\NET5-KH095\Views\Admin\Report\OrderReport.cshtml"
                  Write(Html.Raw(Json.Serialize(ViewBag.Data)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            
            const row = (record) => { 
                return  (
                    `<tr class=""text-center"">
                        <td>${moment(record.date).format(""DD-MM-YYYY"")}</td>
                        <td>${record.total}</td>
                        <td>${record.totalOrdrerSuccess}</td>
                        <td>${record.totalOrdrerOverdue}</td>
                        <td>${record.penatyFee.toLocaleString()} đ</td>
                        <td>${record.totalProduct}</td>
                        <td>${record.totalCustomer}</td>
                    </tr>` )
            };

            const rowFooterRender = (record) => { 
                return  (
                    `<tr class=""text-center"">
                        <td>Tổng</td>
                        <td>${record.total}</td>
                        <td>${record.totalOrdrerSuccess}</td>
                        <td>${record.totalOrdrerOverdue}</td>
                        <td>${record.penatyFee.toLocaleString(");
                WriteLiteral(@")} đ</td>
                        <td>${record.totalProduct}</td>
                        <td>${record.totalCustomer}</td>
                    </tr>` )
            };

            const renderDataTable = (data) => { 

                let rows = '';
                let rowFooter = {
                    total: 0,
                    totalOrdrerSuccess: 0,
                    totalOrdrerOverdue: 0,
                    penatyFee: 0,
                    totalProduct: 0,
                    totalCustomer: 0
                };

                data.forEach(item => {
                    rows += row(item);
                    rowFooter.total += item.total;
                    rowFooter.totalOrdrerSuccess += item.totalOrdrerSuccess;
                    rowFooter.totalOrdrerOverdue += item.totalOrdrerOverdue;
                    rowFooter.penatyFee += item.penatyFee;
                    rowFooter.totalProduct += item.totalProduct;
                    rowFooter.totalCustomer +=item.totalCustomer;");
                WriteLiteral(@"
                })
                
                tableBodyReportOrder.innerHTML = rows;
                tableFooterReportOrder.innerHTML = rowFooterRender(rowFooter);
            }

            const enumerateDaysBetweenDates = function(startDate, endDate) {
                
                var dates = [];
                var currDate = moment(startDate).startOf('day');
                var lastDate = moment(endDate).startOf('day');
                
                while(currDate.add(1, 'days').diff(lastDate) < 0) {
                    dates.push(currDate.clone().toDate());
                }
                return dates;
            };

            const listDates = enumerateDaysBetweenDates(lastMonth, curentDate).map(item => moment(item).format(""DD/MM/YYYY""));
            const fillDataToChart = (categories , data) => {
                let dataFill = [];

                categories.forEach(c => {
                    const index = data.findIndex(d => moment(d.date).format(""DD/MM/YYY");
                WriteLiteral(@"Y"") === c); 
                    if(index != - 1){
                        dataFill.push({
                            total:  data[index].total,
                            totalOrdrerSuccess:  data[index].totalOrdrerSuccess,
                            totalOrdrerOverdue:  data[index].totalOrdrerOverdue,
                            penatyFee:  data[index].penatyFee,
                            totalProduct:  data[index].totalProduct,
                            totalCustomer:  data[index].totalCustomer
                        }); 
                    }
                    else{
                        dataFill.push({
                                total: 0,
                                totalOrdrerSuccess: 0,
                                totalOrdrerOverdue: 0,
                                penatyFee: 0,
                                totalProduct: 0,
                                totalCustomer: 0,
                        })
                    }           
                })");
                WriteLiteral(@"

                return dataFill;
            }

            const dataFill = fillDataToChart(listDates, data);
            renderDataTable(data);

            // call ajax

            const URL = window.location.origin;

            function getDataAjax(start, end , label){

                    loading.style.display = 'flex';
                    let productsHTML = '';
                    let timerId = null; 
                    fetch(`${URL}/admin/report/order/ajax?toDate=${moment(start).toISOString()}&fromDate=${moment(end).toISOString()}`)
                    .then(response => response.json())
                    .then(data => {
                        timerId = setInterval(() => {
                                loading.style.display = 'none';
                                let listDates = enumerateDaysBetweenDates(moment(start).add(-1,'d'),moment(end).add(1,)).map(item => moment(item).format(""DD/MM/YYYY""));
                                const dataFill = fillDataToChart(listDate");
                WriteLiteral(@"s, data.data);
                                console.log(listDates);
                                renderDataTable(data.data);
                                renderCharts(listDates,dataFill);
                                if(timerId != null){
                                    clearInterval(timerId);
                                }
                        },2000);
                    });
                }

            const renderCharts = (listDates, dataFill) => {

                    Highcharts.chart('container', {
                    chart: {
                        type: 'column'
                    },
                    title: {
                        text: ''
                    },
                    subtitle: {
                        text: ''
                    },
                    xAxis: {
                        categories: listDates,
                        crosshair: true
                    },
                    yAxis: {
                        min: 0,");
                WriteLiteral(@"
                        title: {
                            text: 'lượt'
                        }
                    },
                    tooltip: {
                        headerFormat: '<span style=""font-size:10px"">{point.key}</span><table>',
                        pointFormat: '<tr><td style=""color:{series.color};padding:0"">{series.name}: </td>' +
                            '<td style=""padding:0""><b>{point.y}</b></td></tr>',
                        footerFormat: '</table>',
                        shared: true,
                        useHTML: true
                    },
                    plotOptions: {
                        column: {
                            pointPadding: 0.2,
                            borderWidth: 0
                        }
                    },
                    series: [{
                        name: 'Lượt mua',
                        data: dataFill.map(item => item.total)
                    }, 
                    {
                     ");
                WriteLiteral(@"   name: 'Lượt trả quá hạn',
                        data: dataFill.map(item => item.totalOrdrerOverdue)
                    },
                    {
                        name: 'Lượt trả đúng hạn',
                        data: dataFill.map(item => item.totalOrdrerSuccess)

                    },
                    {
                        name: 'Số sản phẩm mua',
                        data: dataFill.map(item => item.totalProduct)

                    }
                    ]
                });
            }
            // render first
            renderCharts(listDates,dataFill);
    </script>
  

");
            }
            );
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
