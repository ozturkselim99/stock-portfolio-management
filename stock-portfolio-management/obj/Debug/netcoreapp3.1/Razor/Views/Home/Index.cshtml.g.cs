#pragma checksum "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46145d5d843bd5065743524c0a2b124d6951acb1"
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
#line 1 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\_ViewImports.cshtml"
using stock_portfolio_management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\_ViewImports.cshtml"
using stock_portfolio_management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46145d5d843bd5065743524c0a2b124d6951acb1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5fa72be885857df905b17045717e6573401b30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StockListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToPortfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div id=""BorsaIstanbul"">
    <div class=""card border-0 shadow my-5"">
        <div class=""card-header"">
            Borsa Istanbul
        </div>
        <div class=""card-body"">
            <table id=""example"" class=""table table-striped table-bordered dt-responsive "" style=""width:100%"">
                <thead>
                    <tr>
                        <th>Code</th>
                        <th>Company</th>
                        <th>Last Price</th>
                        <th>Change</th>
                        <th>Change %</th>
                        <th>Volume</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 21 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                     foreach (var item in Model.stocks)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                           Write(item.code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                           Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                           Write(item.lastprice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 27 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                             if (@Math.Round((item.lastprice - item.lastprice / ((item.rate / 100) + 1)), 3) < 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:#EF5350\">");
#nullable restore
#line 29 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                                                     Write(Math.Round((item.lastprice - item.lastprice / ((item.rate / 100) + 1)), 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:#26A69A\">");
#nullable restore
#line 33 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                                                     Write(Math.Round((item.lastprice - item.lastprice / ((item.rate / 100) + 1)), 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                             if (item.rate < 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:#EF5350\">");
#nullable restore
#line 37 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                                                     Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 38 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td style=\"color:#26A69A\">");
#nullable restore
#line 41 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                                                     Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 42 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 43 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                           Write(item.hacim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46145d5d843bd5065743524c0a2b124d6951acb19921", async() => {
                WriteLiteral("\r\n                                    <input name=\"code\"");
                BeginWriteAttribute("value", " value=\"", 2159, "\"", 2177, 1);
#nullable restore
#line 46 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
WriteAttributeValue("", 2167, item.code, 2167, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                                    <button type=\"button\" class=\"btn btn-secondary btn-sm\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 47 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                                                                                                                        Write(item.code);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><small><i class=\"fas fa-plus-circle mr-1\"></i>Add to Portfolio</small></button>\r\n                                    <div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=\"", 2474, "\"", 2489, 1);
#nullable restore
#line 48 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
WriteAttributeValue("", 2479, item.code, 2479, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                        <div class=""modal-dialog"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLabel"">Stock Details(");
#nullable restore
#line 52 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                                                                                                            Write(item.code);

#line default
#line hidden
#nullable disable
                WriteLiteral(@")</h5>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    <div class=""row"">
                                                        <div class=""col-md-6"">
                                                            <div class=""input-group input-group-sm mb-3"">
                                                                <div class=""input-group-prepend"">
                                                                    <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Quantity</span>
                                                                </div>
                         ");
                WriteLiteral(@"                                       <input type=""number"" class=""form-control"" name=""quantity"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"">
                                                            </div>
                                                        </div>
                                                        <div class=""col-md-6"">
                                                            <div class=""input-group input-group-sm mb-3"">
                                                                <div class=""input-group-prepend"">
                                                                    <span class=""input-group-text"" id=""inputGroup-sizing-sm"">Cost</span>
                                                                </div>
                                                                <input type=""number"" step=0.01 class=""form-control"" name=""cost"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"">
                                                 ");
                WriteLiteral(@"           </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    <button type=""submit"" class=""btn btn-primary"">Add to Portfolio</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 87 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"card-footer text-muted\">\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js""></script>
    <script src=""https://cdn.datatables.net/responsive/2.2.5/js/dataTables.responsive.min.js""></script>
    <script src=""https://cdn.datatables.net/responsive/2.2.5/js/responsive.bootstrap4.min.js""></script>
    <script>
        function updateBorsaIstanbulData() {
            var portfolio = $(""#BorsaIstanbul"");
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 106 "C:\Users\oztur\source\repos\stock-portfolio-management\stock-portfolio-management\Views\Home\Index.cshtml"
                 Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                dataType: ""html"",
                cache: false,
                success: function (data) {
                    var data = $.parseHTML(data);  //<----try with $.parseHTML().
                    $(data).find('#BorsaIstanbul').each(function () {
                        $(BorsaIstanbul).html($(this).html());
                    });
                    $('#example').DataTable({
                        ""destroy"": true, //use for reinitialize datatable
                    });
                },
            });
        }
    </script>
    <script>
        $(document).ready(function () {
            $('#example').DataTable({});
            setInterval(updateBorsaIstanbulData, 150000);
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StockListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
