#pragma checksum "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363b252987a8ea1143897904c12bfc9c077bae48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_Index), @"mvc.1.0.view", @"/Views/Index/Index.cshtml")]
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
#line 1 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\_ViewImports.cshtml"
using ProyectoCeroEF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363b252987a8ea1143897904c12bfc9c077bae48", @"/Views/Index/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4724430b80d4a5fdb1c56ff77b2571e3e20a42ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Index_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Departamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div style=""padding-left: 50px;
        padding-right: 50px;
        padding-top: 150px;
        width:100%;
        height: 100%;"">
        <h1 style=""text-align:left""><u>Departamentos</u></h1>
        <hr />
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Numero</th>
                    <th>Nombre</th>
                    <th>Localidad</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                     foreach (Departamento dep in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                           Write(dep.Dept_NO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                           Write(dep.DNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                           Write(dep.Loc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 27 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoCeroEF\Views\Index\Index.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
