#pragma checksum "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1be6454aa9665004928d17868ca34ab298bcf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bandit_Show), @"mvc.1.0.view", @"/Views/Bandit/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bandit/Show.cshtml", typeof(AspNetCore.Views_Bandit_Show))]
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
#line 1 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/_ViewImports.cshtml"
using BanditsOfTheCoast.Solution;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/_ViewImports.cshtml"
using BanditsOfTheCoast.Solution.Models;

#line default
#line hidden
#line 3 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/_ViewImports.cshtml"
using BOTC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1be6454aa9665004928d17868ca34ab298bcf1", @"/Views/Bandit/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00c9bc0fc9c89c9ef57e28daefbedce64f19a7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Bandit_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 99, true);
            WriteLiteral("\r\n<div class=\"splash-title\">\r\n    <h1 class=\"display-4\">BANDITS OF THE COAST</h1>\r\n    <h3>\r\n      ");
            EndContext();
            BeginContext(145, 10, false);
#line 8 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(155, 6, true);
            WriteLiteral(" The\r\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
       if(Model.Stats.Strength > 9)
      {

#line default
#line hidden
            BeginContext(207, 29, true);
            WriteLiteral("        <span>Mighty</span>\r\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
      }
      else
      {

#line default
#line hidden
            BeginContext(266, 27, true);
            WriteLiteral("        <span>Weak</span>\r\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
      }

#line default
#line hidden
            BeginContext(302, 6, true);
            WriteLiteral("      ");
            EndContext();
            BeginContext(309, 16, false);
#line 17 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
 Write(Model.Stats.Name);

#line default
#line hidden
            EndContext();
            BeginContext(325, 20, true);
            WriteLiteral("\r\n    </h3>\r\n    <p>");
            EndContext();
            BeginContext(346, 20, false);
#line 19 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
  Write(Model.Stats.Strength);

#line default
#line hidden
            EndContext();
            BeginContext(366, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(380, 25, false);
#line 20 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
  Write(Model.Stats.CurrentHealth);

#line default
#line hidden
            EndContext();
            BeginContext(405, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(419, 23, false);
#line 21 "/Users/Guest/Desktop/BanditsOfTheCoast.Solution/BOTC/Views/Bandit/Show.cshtml"
  Write(Model.Stats.TotalHealth);

#line default
#line hidden
            EndContext();
            BeginContext(442, 18, true);
            WriteLiteral("</p>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
