#pragma checksum "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9158787bd31ca13fb5a1997e90d1ee9879dfef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Appointment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Appointment/Index.cshtml")]
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
#line 1 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\_ViewImports.cshtml"
using final_MVC_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\_ViewImports.cshtml"
using final_MVC_Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9158787bd31ca13fb5a1997e90d1ee9879dfef", @"/Areas/Admin/Views/Appointment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7af602928edcd35c8562fdbd4b559fce851688", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Appointment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<final_MVC_Test.Models.ViewModels.AppointmentsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("productPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary p-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary p-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c9158787bd31ca13fb5a1997e90d1ee9879dfef5763", async() => {
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n\r\n    <h2 class=\"text-info\">Appointment List</h2>\r\n\r\n    <br />\r\n\r\n    <div style=\"height:150px; background-color:aliceblue\" class=\"container\">\r\n");
                WriteLiteral("\r\n\r\n        <div class=\"col-12\">\r\n            <div class=\"row\" style=\"padding-top:10px;\">\r\n                <div class=\"col-2\">\r\n                    Customer Name\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    Email\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"row\" style=\"padding-top:10px;\">\r\n                <div class=\"col-2\">\r\n                    Phone Number\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    Appointment Date\r\n                </div>\r\n                <div class=\"col-3\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.Editor("searchDate", new { htmlAttributes = new { @class = "form-control", @id = "datepicker" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>

            <div class=""row"" style=""padding-top:10px;"">

                <div class=""text-center "">
                    <button type=""submit"" name=""submit"" value=""Search"" class=""rounded-pill btn btn-primary col-4"">
                        <i class=""fas fa-search""></i>Search
                    </button>
                </div>
            </div>

        </div>

    </div>

    <div>
        <table class=""table table-striped border"">

            <tr class=""table-info"">
                <th>
                    ");
#nullable restore
#line 72 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().SalesPerson.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 76 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().AppointmentDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 80 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 84 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().CustomerPhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 88 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().CustomerEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 92 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Appointments.FirstOrDefault().isConfirmed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </th>\r\n                <th>\r\n                </th>\r\n                <th>\r\n                </th>\r\n                <th>\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
             foreach (var item in Model.Appointments)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SalesPerson.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                   Write(Html.DisplayFor(m => item.AppointmentDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 112 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 115 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerPhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 118 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CustomerEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 121 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                   Write(Html.DisplayFor(m => item.isConfirmed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c9158787bd31ca13fb5a1997e90d1ee9879dfef14651", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 125 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 129 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n    </div>\r\n\r\n");
                WriteLiteral("<div>\r\n");
#nullable restore
#line 139 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
      
        int totalPages = Model.PagingInfo.totalPage;

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
     for (int i = 1; i <= totalPages; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
         if (i == Model.PagingInfo.CurrentPage)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c9158787bd31ca13fb5a1997e90d1ee9879dfef17595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productPage", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                              WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["productPage"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productPage", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["productPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 148 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
AddHtmlAttributeValue("", 4843, i, 4843, 2, false);

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
                WriteLiteral(" ");
#nullable restore
#line 148 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                                                                                                                          }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c9158787bd31ca13fb5a1997e90d1ee9879dfef20824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productPage", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                              WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["productPage"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productPage", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["productPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 151 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
AddHtmlAttributeValue("", 5001, i, 5001, 2, false);

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
#nullable restore
#line 151 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                                                                                                                                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
                                                                                                                                  
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n    <div");
                BeginWriteAttribute("page-model", " page-model=\"", 5035, "\"", 5065, 1);
#nullable restore
#line 155 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Appointment\Index.cshtml"
WriteAttributeValue("", 5048, Model.PagingInfo, 5048, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" page-action=\"Index\"\r\n         page-class-enabled=\"true\" page-class=\"btn border\"\r\n         page-class-normal=\"btn btn-default active\"\r\n         page-class-selected=\"btn btn-primary active\"\r\n         class=\"btn-group m-1\"></div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('.timepicker').timepicker({
    timeFormat: 'h:mm p',
    interval: 30,
    minTime: '10',
    maxTime: '3:00pm',
    startTime: '10:00',
    dynamic: true,
    dropdown: true,
    scrollbar: true
});

        $(function () {
            $(""#datepicker"").datepicker({
                minDate: +1, maxDate: ""_3M""
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<final_MVC_Test.Models.ViewModels.AppointmentsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591