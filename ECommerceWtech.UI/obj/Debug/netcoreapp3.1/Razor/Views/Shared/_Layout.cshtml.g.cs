#pragma checksum "C:\Users\alitu\OneDrive\Masaüstü\ConsoleCalısma\ECommerceWtech\ECommerceWtech.UI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdd391f8f809fe59fae773bfe2421d811c66daa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdd391f8f809fe59fae773bfe2421d811c66daa", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcdd391f8f809fe59fae773bfe2421d811c66daa2764", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 195, "\"", 205, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 234, "\"", 244, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>Shop Homepage - Start Bootstrap Template</title>
    <!-- Favicon-->
    <link rel=""icon"" type=""image/x-icon"" href=""assets/favicon.ico"" />
    <!-- Bootstrap icons-->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css"" rel=""stylesheet"" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href=""css/styles.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcdd391f8f809fe59fae773bfe2421d811c66daa4656", async() => {
                WriteLiteral("\r\n    <!-- Navigation-->\r\n    ");
#nullable restore
#line 18 "C:\Users\alitu\OneDrive\Masaüstü\ConsoleCalısma\ECommerceWtech\ECommerceWtech.UI\Views\Shared\_Layout.cshtml"
Write(Html.Partial("Partial/Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- Header-->\r\n    ");
#nullable restore
#line 21 "C:\Users\alitu\OneDrive\Masaüstü\ConsoleCalısma\ECommerceWtech\ECommerceWtech.UI\Views\Shared\_Layout.cshtml"
Write(Html.Partial("Partial/Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Section-->\r\n    <section class=\"py-5\">\r\n        <div>");
#nullable restore
#line 24 "C:\Users\alitu\OneDrive\Masaüstü\ConsoleCalısma\ECommerceWtech\ECommerceWtech.UI\Views\Shared\_Layout.cshtml"
        Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
        <div class=""container px-4 px-lg-5 mt-5"">

            <div class=""row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center"">

                <div class=""col mb-5"">
                    <div class=""card h-100"">
                        <!-- Product image-->
                        <img class=""card-img-top"" src=""https://dummyimage.com/450x300/dee2e6/6c757d.jpg"" alt=""..."" />
                        <!-- Product details-->
                        <div class=""card-body p-4"">
                            <div class=""text-center"">
                                <!-- Product name-->
                                <h5 class=""fw-bolder"">Fancy Product</h5>
                                <!-- Product price-->
                                $40.00 - $80.00
                            </div>
                        </div>
                        <!-- Product actions-->
                        <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
         ");
                WriteLiteral(@"                   <div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">View options</a></div>
                        </div>
                    </div>
                </div>
                <div class=""col mb-5"">
                    <div class=""card h-100"">
                        <!-- Sale badge-->
                        <div class=""badge bg-dark text-white position-absolute"" style=""top: 0.5rem; right: 0.5rem"">Sale</div>
                        <!-- Product image-->
                        <img class=""card-img-top"" src=""https://dummyimage.com/450x300/dee2e6/6c757d.jpg"" alt=""..."" />
                        <!-- Product details-->
                        <div class=""card-body p-4"">
                            <div class=""text-center"">
                                <!-- Product name-->
                                <h5 class=""fw-bolder"">Special Item</h5>
                                <!-- Product reviews-->
                                <div class=""d-flex justify-");
                WriteLiteral(@"content-center small text-warning mb-2"">
                                    <div class=""bi-star-fill""></div>
                                    <div class=""bi-star-fill""></div>
                                    <div class=""bi-star-fill""></div>
                                    <div class=""bi-star-fill""></div>
                                    <div class=""bi-star-fill""></div>
                                </div>
                                <!-- Product price-->
                                <span class=""text-muted text-decoration-line-through"">$20.00</span>
                                $18.00
                            </div>
                        </div>
                        <div>");
#nullable restore
#line 72 "C:\Users\alitu\OneDrive\Masaüstü\ConsoleCalısma\ECommerceWtech\ECommerceWtech.UI\Views\Shared\_Layout.cshtml"
                        Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n    </section>\r\n    <!-- Footer-->\r\n    ");
#nullable restore
#line 75 "C:\Users\alitu\OneDrive\Masaüstü\ConsoleCalısma\ECommerceWtech\ECommerceWtech.UI\Views\Shared\_Layout.cshtml"
Write(Html.Partial("Partial/Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Bootstrap core JS-->\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"></script>\r\n    <!-- Core theme JS-->\r\n    <script src=\"js/scripts.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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