#pragma checksum "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-MVC\Bacola-MVC\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29b2d60cb99b3e9c85d60493de2efa9602842cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29b2d60cb99b3e9c85d60493de2efa9602842cb", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-MVC\Bacola-MVC\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""contact-title"">
        <div class=""contact-title"">
            <div class=""container"">
                <div class=""row mt-5"">
                    <h1>Get In Touch </h1>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Expedita quaerat unde quam dolor culpa
                        veritatis inventore, aut commodi eum veniam vel.
                    </p>
                </div>
            </div>
        </div>

    </section>
    <section id=""contact-data"">
        <div class=""contact-info"">
            <div class=""container"">
                <div class=""row mt-5"">
                    <div class=""col-4"">
                        <div class=""location"">
                            <i class=""fas fa-map-marker-alt""></i>
                            <h5 class=""mt-5"">102 Street 2714 Donovan</h5>
                            <p class=""mt-3"">Lorem ipsum dolar site amet discont</p>
                        </div>
   ");
            WriteLiteral(@"                 </div>
                    <div class=""col-lg-4 col-sm-12"">
                        <div class=""phone"">
                            <i class=""fas fa-phone-alt""></i>
                            <h5 class=""mt-5"">+02 1234 567 88</h5>
                            <p class=""mt-3"">Lorem ipsum dolar site amet discont</p>
                        </div>

                    </div>
                    <div class=""col-4"">
                        <div class=""mail"">
                            <i class=""fas fa-envelope""></i>
                            <h5 class=""mt-5"">info@example.com</h5>
                            <p class=""mt-3"">Lorem ipsum dolar site amet discont</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section id=""send-us"">
        <div class=""send-us"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""send-us-content"">
       ");
            WriteLiteral(@"                 <div class=""send-us-title"">
                            <h2>Send Us</h2>
                            <p>
                                Lorem, ipsum dolor sit amet consectetur adipisicing elit. Expedita quaerat unde quam
                                dolor culpa veritatis inventore, aut commodi eum veniam vel.
                            </p>
                        </div>
                        <hr>
                        <div class=""send-us-form mt-5"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29b2d60cb99b3e9c85d60493de2efa9602842cb6149", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""mb-3"">
                                        <div class=""row"">
                                            <div class=""col-lg-6 col-sm-12"">
                                                <label for=""send-us-name"" class=""form-label"">Your Name *</label>
                                                <input id=""send-us-name"" type=""text"" aria-label=""First name"" class=""form-control"">
                                            </div>
                                            <div class=""col-lg-6 col-sm-12"">
                                                <label for=""exampleInputEmail1"" class=""form-label"">Your Email *</label>
                                                <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"">

                                            </div>
                                        </div>
                                   ");
                WriteLiteral(@"     <div class=""row mt-3"">
                                            <div class=""col-12"">
                                                <label for=""send-us-subject"" class=""form-label"">Your Subject *</label>
                                                <input id=""send-us-subject"" type=""text"" aria-label=""First name"" class=""form-control"">
                                            </div>

                                        </div>
                                        <div class=""row mt-3"">
                                            <div class=""col-12"">
                                                <label for=""send-us-textarea"" class=""form-label"">Your message *</label>
                                                <textarea id=""send-us-textarea"" class=""form-control"" aria-label=""With textarea""></textarea>
                                            </div>
                                        </div>
                                    </div>
                                </di");
                WriteLiteral("v>\r\n                                <button type=\"button\" class=\"btn btn-primary send-us-btn mt-5\">Send Message</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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