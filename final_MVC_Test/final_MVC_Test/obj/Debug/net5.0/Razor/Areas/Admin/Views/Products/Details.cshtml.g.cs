#pragma checksum "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e0f31f21381fd2151cc1445fc463e6a63c6989e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e0f31f21381fd2151cc1445fc463e6a63c6989e", @"/Areas/Admin/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7af602928edcd35c8562fdbd4b559fce851688", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<final_MVC_Test.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div class=\"row d-flex\">\r\n    <div class=\"col-6\">\r\n        <h4>Product</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
            WriteLiteral("            <!--<dd class=\"col-4\">-->\r\n");
            WriteLiteral("\r\n            <!--</dd>-->\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 40 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ShadeColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.ShadeColor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SpecialTag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.SpecialTag.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div class=\"form-group col-5 mx-auto\" >\r\n        <div class=\"col-2\">\r\n        </div>\r\n        <img class=\"rounded-circle col-6 img-fluid \"");
            BeginWriteAttribute("src", " src=\"", 2031, "\"", 2049, 1);
#nullable restore
#line 62 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue("", 2037, Model.Image, 2037, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e0f31f21381fd2151cc1445fc463e6a63c6989e10272", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Kiro Abadier\Desktop\final_MVC_Test\final_MVC_Test\final_MVC_Test\Areas\Admin\Views\Products\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e0f31f21381fd2151cc1445fc463e6a63c6989e12535", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<final_MVC_Test.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
