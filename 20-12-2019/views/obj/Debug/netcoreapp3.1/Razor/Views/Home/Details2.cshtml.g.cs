#pragma checksum "C:\Users\Bizruntime-54\source\repos\views\views\Views\Home\Details2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02065b9009c31a3be0ec70181c10429336c95747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details2), @"mvc.1.0.view", @"/Views/Home/Details2.cshtml")]
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
#line 1 "C:\Users\Bizruntime-54\source\repos\views\views\Views\_ViewImports.cshtml"
using views.Viewmodels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bizruntime-54\source\repos\views\views\Views\_ViewImports.cshtml"
using views.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02065b9009c31a3be0ec70181c10429336c95747", @"/Views/Home/Details2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e2d4dc477cbed75f78c1cf42a1b4fdd8938b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsviewmodels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Bizruntime-54\source\repos\views\views\Views\Home\Details2.cshtml"
  
    //Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Employee Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 10 "C:\Users\Bizruntime-54\source\repos\views\views\Views\Home\Details2.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    Name: ");
#nullable restore
#line 13 "C:\Users\Bizruntime-54\source\repos\views\views\Views\Home\Details2.cshtml"
     Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Email:");
#nullable restore
#line 16 "C:\Users\Bizruntime-54\source\repos\views\views\Views\Home\Details2.cshtml"
     Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Department: ");
#nullable restore
#line 19 "C:\Users\Bizruntime-54\source\repos\views\views\Views\Home\Details2.cshtml"
           Write(Model.Employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsviewmodels> Html { get; private set; }
    }
}
#pragma warning restore 1591
