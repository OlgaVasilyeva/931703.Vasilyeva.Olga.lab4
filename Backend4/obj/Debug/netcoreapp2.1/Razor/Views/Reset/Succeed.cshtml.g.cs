#pragma checksum "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Reset\Succeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b803a1a1544ec5baa09e350f8f9f5a470b1f3b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reset_Succeed), @"mvc.1.0.view", @"/Views/Reset/Succeed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reset/Succeed.cshtml", typeof(AspNetCore.Views_Reset_Succeed))]
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
#line 1 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\_ViewImports.cshtml"
using Backend4;

#line default
#line hidden
#line 2 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\_ViewImports.cshtml"
using Backend4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b803a1a1544ec5baa09e350f8f9f5a470b1f3b0e", @"/Views/Reset/Succeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe404492c1e10f332e537f600dcb9fd9fd7c9bd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Reset_Succeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Backend4.Models.ResetPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Reset\Succeed.cshtml"
  
    ViewBag.Title = "Reset your password";

#line default
#line hidden
            BeginContext(98, 82, true);
            WriteLiteral("\r\n<h2>Reset results</h2>\r\n<dl class=\"dl-horizontal\">\r\n    <dt>Email</dt>\r\n    <dd>");
            EndContext();
            BeginContext(181, 11, false);
#line 9 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Reset\Succeed.cshtml"
   Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(192, 34, true);
            WriteLiteral("</dd>\r\n    <dt>Code</dt>\r\n    <dd>");
            EndContext();
            BeginContext(227, 10, false);
#line 11 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Reset\Succeed.cshtml"
   Write(Model.Code);

#line default
#line hidden
            EndContext();
            BeginContext(237, 42, true);
            WriteLiteral("</dd>\r\n    <dt>New password</dt>\r\n    <dd>");
            EndContext();
            BeginContext(280, 14, false);
#line 13 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Reset\Succeed.cshtml"
   Write(Model.Password);

#line default
#line hidden
            EndContext();
            BeginContext(294, 12, true);
            WriteLiteral("</dd>\r\n</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Backend4.Models.ResetPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
