#pragma checksum "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f80ef2b5c51c605928c72d3a0dd2a1fd8a8170e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enfermos_EnfermosGenero), @"mvc.1.0.view", @"/Views/Enfermos/EnfermosGenero.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f80ef2b5c51c605928c72d3a0dd2a1fd8a8170e4", @"/Views/Enfermos/EnfermosGenero.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b927ad6eeebc99e5bebc43c53de3e0002d598b", @"/Views/_ViewImports.cshtml")]
    public class Views_Enfermos_EnfermosGenero : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Enfermo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enfermos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnfermosGenero", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br/>\r\n<h1>Enfermos por Igualdad de Genero</h1>\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 5 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
     foreach (Genero g in ViewBag.Generos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80ef2b5c51c605928c72d3a0dd2a1fd8a8170e44424", async() => {
#nullable restore
#line 10 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                                      Write(g.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-genero", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                     WriteLiteral(g.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-genero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 12 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<hr />\r\n");
#nullable restore
#line 15 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Apellido</th>
                <th>Direccion</th>
                <th>Fecha Nacimiento</th>
                <th>NSS</th>
                <th>S</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                 foreach (Enfermo e in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 34 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                       Write(e.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                       Write(e.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                       Write(e.Fecha_Nac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                       Write(e.NSS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                       Write(e.S);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f80ef2b5c51c605928c72d3a0dd2a1fd8a8170e49745", async() => {
                WriteLiteral("Ver detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-inscripcion", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                                                                                          WriteLiteral(e.Inscripcion);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["inscripcion"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-inscripcion", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["inscripcion"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 50 "E:\MCSD\MDFS\MDFS-4\NetCore\MVCEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Enfermo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
