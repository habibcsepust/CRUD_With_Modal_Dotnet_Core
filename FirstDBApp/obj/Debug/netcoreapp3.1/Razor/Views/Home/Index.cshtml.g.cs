#pragma checksum "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aafd812496bf928fd3ed986094dcc916b6984fe"
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
#line 1 "C:\Users\bg----\Downloads\FirstDBApp\Views\_ViewImports.cshtml"
using FirstDBApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bg----\Downloads\FirstDBApp\Views\_ViewImports.cshtml"
using FirstDBApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aafd812496bf928fd3ed986094dcc916b6984fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f5b9570aac4f2ad207a8e28a7abecc037627c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"color:red;\">");
#nullable restore
#line 5 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
                   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<a href=""#"" data-toggle=""modal"" data-target=""#AddNewRecord"">Add New</a>

<table class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th colspan=""2"">Operations</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
         foreach(var item in ViewBag.emplist)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
           Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
           Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td colspan=\"2\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#EditRecord\" class=\"edit\" data-id=\"");
#nullable restore
#line 28 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
                                                                                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a>  |  \r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#DeleteRecord\" class=\"delete\" data-id=\"");
#nullable restore
#line 29 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
                                                                                               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\bg----\Downloads\FirstDBApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""AddNewRecord"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Add New Record</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aafd812496bf928fd3ed986094dcc916b6984fe8242", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label>ID:</label>
                        <input type=""text"" class=""form-control"" name=""id"" required />
                    </div>
                    <div class=""form-group"">
                        <label>Name:</label>
                        <input type=""text"" class=""form-control"" name=""Name"" required />
                    </div>
                    <div class=""form-group"">
                        <label>Email:</label>
                        <input type=""text"" class=""form-control"" name=""Email"" required />
                    </div>
                    <div class=""form-group"">
                        <label>Phone:</label>
                        <input type=""text"" class=""form-control"" name=""phone"" required />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dis");
                WriteLiteral("miss=\"modal\">Close</button>\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Save changes</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div> 

<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""EditRecord"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Edit Record</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aafd812496bf928fd3ed986094dcc916b6984fe11872", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label>ID:</label>
                        <input type=""text"" class=""form-control"" name=""id"" id=id required readonly/>
                    </div>
                    <div class=""form-group"">
                        <label>Name:</label>
                        <input type=""text"" class=""form-control"" name=""Name"" id=""name"" required />
                    </div>
                    <div class=""form-group"">
                        <label>Email:</label>
                        <input type=""text"" class=""form-control"" name=""Email"" id=""email"" required />
                    </div>
                    <div class=""form-group"">
                        <label>Phone:</label>
                        <input type=""text"" class=""form-control"" name=""phone"" id=""phone"" required />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button ty");
                WriteLiteral("pe=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Save changes</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""DeleteRecord"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Edit Record</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aafd812496bf928fd3ed986094dcc916b6984fe15556", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <h3 style=""color:red;"">Do you want to delete this record?</h3>
                    <div class=""form-group"">
                        <label>ID:</label>
                        <input type=""text"" class=""form-control"" name=""id"" id=id required readonly />
                    </div>
                    <div class=""form-group"">
                        <label>Name:</label>
                        <input type=""text"" class=""form-control"" name=""Name"" id=""name"" required readonly />
                    </div>
                    <div class=""form-group"">
                        <label>Email:</label>
                        <input type=""text"" class=""form-control"" name=""Email"" id=""email"" required  readonly/>
                    </div>
                    <div class=""form-group"">
                        <label>Phone:</label>
                        <input type=""text"" class=""form-control"" name=""phone"" id=""phone"" required readonly />
              ");
                WriteLiteral(@"      </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Yes</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

<script>
    $(document).ready(function () {
        $('table .edit').on('click', function () {
            var id = $(this).data(""id"");

            $.ajax({
                type: 'POST',
                url: 'Home/FindRecord/',
                data: { ""cusid"": id },
                success: function (response) {
                    $('#EditRecord #id').val(response.id);
                    $('#EditRecord #name').val(response.name);
                    $('#EditRecord #email').val(response.email);
                    $('#EditRecord #phone').val(response.phone);
                }
            })
        });

        $('table .delete').on('click', function () {
            var id = $(this).data(""id"");

            $.ajax({
                type: 'POST',
                url: 'Home/FindRecord/',
                data: { ""cusid"": id },
                success: fu");
            WriteLiteral(@"nction (response) {
                    $('#DeleteRecord #id').val(response.id);
                    $('#DeleteRecord #name').val(response.name);
                    $('#DeleteRecord #email').val(response.email);
                    $('#DeleteRecord #phone').val(response.phone);
                }
            })
        });
    });
</script>");
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
