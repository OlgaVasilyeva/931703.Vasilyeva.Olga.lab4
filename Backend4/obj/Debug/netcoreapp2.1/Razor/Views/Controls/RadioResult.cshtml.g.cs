#pragma checksum "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b31d85d93fac17d5d7ec36544a934e25a83778e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_RadioResult), @"mvc.1.0.view", @"/Views/Controls/RadioResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Controls/RadioResult.cshtml", typeof(AspNetCore.Views_Controls_RadioResult))]
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
#line 1 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml"
using Backend4.Models.Controls;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31d85d93fac17d5d7ec36544a934e25a83778e9", @"/Views/Controls/RadioResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe404492c1e10f332e537f600dcb9fd9fd7c9bd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_RadioResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Backend4.Models.Controls.RadioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml"
  
    ViewBag.Title = "Radio";
    var allMonths = ViewBag.AllMonths as Month[];
    var montsMap = allMonths.ToDictionary(x => x.Id);

#line default
#line hidden
            BeginContext(224, 66, true);
            WriteLiteral("\r\n<h2>Radio</h2>\r\n<dl class=\"dl-horizontal\">\r\n    <dt>Month</dt>\r\n");
            EndContext();
#line 12 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml"
     if (Model.Month.HasValue)
    {

#line default
#line hidden
            BeginContext(329, 12, true);
            WriteLiteral("        <dd>");
            EndContext();
            BeginContext(342, 32, false);
#line 14 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml"
       Write(montsMap[Model.Month.Value].Name);

#line default
#line hidden
            EndContext();
            BeginContext(374, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 15 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(405, 25, true);
            WriteLiteral("        <dd>(none)</dd>\r\n");
            EndContext();
#line 19 "C:\Учебное\Веб20\Web 2 semestr\Лабы\Лабы2\Backend4\Backend4\Views\Controls\RadioResult.cshtml"
    }

#line default
#line hidden
            BeginContext(437, 5, true);
            WriteLiteral("</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Backend4.Models.Controls.RadioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591