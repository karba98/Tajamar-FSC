#pragma checksum "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958a01924fcb543fc59f2f642c23526fc1959074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enfermos_Detalles), @"mvc.1.0.view", @"/Views/Enfermos/Detalles.cshtml")]
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
#line 1 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\_ViewImports.cshtml"
using MVCEntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\_ViewImports.cshtml"
using MVCEntityFramework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"958a01924fcb543fc59f2f642c23526fc1959074", @"/Views/Enfermos/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b927ad6eeebc99e5bebc43c53de3e0002d598b", @"/Views/_ViewImports.cshtml")]
    public class Views_Enfermos_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Enfermo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br/>\r\n<br/>\r\n");
#nullable restore
#line 4 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
Write(Html.ActionLink("Volver", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1><u>");
#nullable restore
#line 6 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
  Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></h1>\r\n<hr/>\r\n<h3><a>");
#nullable restore
#line 8 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
  Write(Model.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3> \r\n<h3><b>NSS: ");
#nullable restore
#line 9 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
       Write(Model.NSS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3> \r\n<hr/>\r\n<a>Fecha NAcimiento: ");
#nullable restore
#line 11 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
                Write(Model.Fecha_Nac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br/>\r\n<a>Inscripción: ");
#nullable restore
#line 12 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
           Write(Model.Inscripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br/>\r\n<a>Sexo: ");
#nullable restore
#line 13 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
    Write(Model.S);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br/><br/><hr/>\r\n");
#nullable restore
#line 14 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\Detalles.cshtml"
Write(Html.ActionLink("Modificar","Modificar",new { inscripcion = Model.Inscripcion}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Enfermo> Html { get; private set; }
    }
}
#pragma warning restore 1591