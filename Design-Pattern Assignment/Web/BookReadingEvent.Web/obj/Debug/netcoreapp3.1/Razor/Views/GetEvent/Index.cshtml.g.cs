#pragma checksum "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5a90d80940d7290ddeabe527072a7d63210cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GetEvent_Index), @"mvc.1.0.view", @"/Views/GetEvent/Index.cshtml")]
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
#line 1 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\_ViewImports.cshtml"
using BookReadingEvent.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\_ViewImports.cshtml"
using BookReadingEvent.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5a90d80940d7290ddeabe527072a7d63210cf1", @"/Views/GetEvent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21fcb4ba77a8a8aad2479fcaa3c6fc050a80d3b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GetEvent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteByEventId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GetEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:30px;margin-top:30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
  
    if (ViewBag.checkLayout == "Home")
    {
        Layout = "_Layout";
    }
    else
    {

        Layout = "_LayoutEvent";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4 style=\"text-align:center\">Event Details</h4>\n<hr />\n<div class=\"jumbotron\" style=\"width:90%; margin-bottom: 3px; align-content:center; margin-left:30px;\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title  display-4\">");
#nullable restore
#line 17 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <h6 class=\"card-subtitle lead mb-3 \"><b>Description: &nbsp;</b>");
#nullable restore
#line 18 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n        <h6 class=\"card-subtitle lead  mb-3 \"><b>Date: &nbsp;</b>");
#nullable restore
#line 19 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                            Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n        <h6 class=\"card-subtitle lead  mb-3 \"><b>Duration: &nbsp;</b>");
#nullable restore
#line 20 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hrs</h6>\n        <h6 class=\"card-subtitle lead  mb-3 \"><b>Location: &nbsp;</b>");
#nullable restore
#line 21 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        <h6 class=\"card-subtitle lead mb-3 \"><b>StartTime: &nbsp;</b>");
#nullable restore
#line 22 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                Write(Model.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        <h6 class=\"card-subtitle lead mb-3 \"><b>OtherDetails: &nbsp;</b>");
#nullable restore
#line 23 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                   Write(Model.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        <h6 class=\"card-subtitle lead mb-3 \"><b>CreatedBy: &nbsp;</b>");
#nullable restore
#line 24 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n    </div>\n\n    <div>\n");
#nullable restore
#line 28 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
         if (ViewBag.emailId != null && ViewBag.check == "MyEvent")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5a90d80940d7290ddeabe527072a7d63210cf110150", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                                                                   WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5a90d80940d7290ddeabe527072a7d63210cf112765", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                        WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 32 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
#nullable restore
#line 36 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
 if (ViewBag.emailId != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5a90d80940d7290ddeabe527072a7d63210cf115703", async() => {
                WriteLiteral("Add Comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                                                                                                                               WriteLiteral(Model.EventId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n    <hr />\n");
#nullable restore
#line 41 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
 if (ViewBag.count == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"" style=""margin-top:50px; margin-bottom:50px; width:80%; margin-left:30px; margin-bottom:50px;"">
        <table class=""table table-bordered"">
            <thead style=""background-color:Highlight; color:aliceblue"">
                <tr class=""fs-5"">
                    <th colspan=""2"">Past Comments</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 53 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                 foreach (var comment in ViewBag.Comments)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"fs-5\" style=\"margin-bottom:10px;\">\n                        <td>");
#nullable restore
#line 57 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 58 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                       Write(comment.Comment1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 60 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
#nullable restore
#line 64 "C:\Modified DP\MVC Assignment\Web\BookReadingEvent.Web\Views\GetEvent\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591