#pragma checksum "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\Home\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28234f38bf41ed372d69bf0ace1bc19ec2971d5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detalles), @"mvc.1.0.view", @"/Views/Home/Detalles.cshtml")]
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
#line 1 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\_ViewImports.cshtml"
using PruebaNugets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\_ViewImports.cshtml"
using PruebaNugets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\_ViewImports.cshtml"
using CochesNuget;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\_ViewImports.cshtml"
using NorthWindNuGetRC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28234f38bf41ed372d69bf0ace1bc19ec2971d5e", @"/Views/Home/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001c72eb376cb1407c14dfda40627b81783ee3f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerNode>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 2 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\Home\Detalles.cshtml"
Write(Model.customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr/>\r\n<a>");
#nullable restore
#line 4 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\Home\Detalles.cshtml"
Write(Model.customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 4 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\Home\Detalles.cshtml"
                        Write(Model.customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br/>\r\n<a>");
#nullable restore
#line 5 "E:\MCSD\MDFS\MDFS-5\NuGet\PruebaNugets\Views\Home\Detalles.cshtml"
Write(Model.customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br/>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerNode> Html { get; private set; }
    }
}
#pragma warning restore 1591
