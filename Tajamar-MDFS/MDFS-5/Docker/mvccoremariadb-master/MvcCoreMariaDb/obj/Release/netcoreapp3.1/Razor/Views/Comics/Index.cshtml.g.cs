#pragma checksum "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\Comics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747a0a3f8734a3137d1e979d97bb259680283d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comics_Index), @"mvc.1.0.view", @"/Views/Comics/Index.cshtml")]
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
#line 1 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\_ViewImports.cshtml"
using MvcCoreMariaDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\_ViewImports.cshtml"
using MvcCoreMariaDb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747a0a3f8734a3137d1e979d97bb259680283d04", @"/Views/Comics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0df60a138669e18329ad50082bcb1060ce8341c", @"/Views/_ViewImports.cshtml")]
    public class Views_Comics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\Comics\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Comics MariaDb</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Titulo</th>\r\n            <th>Portada</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\Comics\Index.cshtml"
         foreach (Comic comic in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\Comics\Index.cshtml"
                   Write(comic.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 421, "\"", 440, 1);
#nullable restore
#line 21 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\Comics\Index.cshtml"
WriteAttributeValue("", 427, comic.Imagen, 427, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 200px; height: 280px\"/>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "E:\MCSD\MDFS\MDFS-5\Docker\mvccoremariadb-master\MvcCoreMariaDb\Views\Comics\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
