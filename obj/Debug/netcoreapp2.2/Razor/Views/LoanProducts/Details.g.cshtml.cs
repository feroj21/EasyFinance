#pragma checksum "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b77cff8c6546e9cb19f3195ec92c71d8569dd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanProducts_Details), @"mvc.1.0.view", @"/Views/LoanProducts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoanProducts/Details.cshtml", typeof(AspNetCore.Views_LoanProducts_Details))]
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
#line 1 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\_ViewImports.cshtml"
using EasyFinance;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\_ViewImports.cshtml"
using EasyFinance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b77cff8c6546e9cb19f3195ec92c71d8569dd0", @"/Views/LoanProducts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c59f4bece0398dd0fbb7a0249e512efcbc73e0", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanProducts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFinance.Models.LoanProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>LoanProduct</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(219, 40, false);
#line 14 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(259, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(323, 36, false);
#line 17 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(359, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(422, 48, false);
#line 20 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(470, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(534, 44, false);
#line 23 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.InterestRate));

#line default
#line hidden
            EndContext();
            BeginContext(578, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(641, 43, false);
#line 26 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Summary));

#line default
#line hidden
            EndContext();
            BeginContext(684, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(748, 39, false);
#line 29 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Summary));

#line default
#line hidden
            EndContext();
            BeginContext(787, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(850, 48, false);
#line 32 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FinancialMin));

#line default
#line hidden
            EndContext();
            BeginContext(898, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(962, 44, false);
#line 35 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.FinancialMin));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1069, 48, false);
#line 38 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FinancialMax));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1181, 44, false);
#line 41 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.FinancialMax));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1288, 45, false);
#line 44 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenureMin));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1397, 41, false);
#line 47 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenureMin));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1501, 45, false);
#line 50 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenureMax));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1610, 41, false);
#line 53 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenureMax));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1714, 42, false);
#line 56 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AgeMin));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1820, 38, false);
#line 59 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.AgeMin));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1921, 42, false);
#line 62 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AgeMax));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2027, 38, false);
#line 65 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.AgeMax));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2128, 45, false);
#line 68 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2237, 41, false);
#line 71 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2341, 45, false);
#line 74 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2450, 41, false);
#line 77 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(2491, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2554, 41, false);
#line 80 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Banks));

#line default
#line hidden
            EndContext();
            BeginContext(2595, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2659, 42, false);
#line 83 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Banks.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2764, 45, false);
#line 86 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanTypes));

#line default
#line hidden
            EndContext();
            BeginContext(2809, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2873, 46, false);
#line 89 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
       Write(Html.DisplayFor(model => model.LoanTypes.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2919, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2966, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b77cff8c6546e9cb19f3195ec92c71d8569dd015433", async() => {
                BeginContext(3012, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 94 "C:\Users\user\source\repos\EasyFinance\EasyFinance\Views\LoanProducts\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3020, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3028, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b77cff8c6546e9cb19f3195ec92c71d8569dd017760", async() => {
                BeginContext(3050, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3066, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFinance.Models.LoanProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
