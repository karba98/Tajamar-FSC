#pragma checksum "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d770a336f822c3628be592844456b4e15506b304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matematicas_TablaMultiplicar), @"mvc.1.0.view", @"/Views/Matematicas/TablaMultiplicar.cshtml")]
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
#line 1 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\_ViewImports.cshtml"
using ProyectoMatematicas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\_ViewImports.cshtml"
using ProyectoMatematicas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d770a336f822c3628be592844456b4e15506b304", @"/Views/Matematicas/TablaMultiplicar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7621cb76ff106b7b8ab31904fb03fe56478a294c", @"/Views/_ViewImports.cshtml")]
    public class Views_Matematicas_TablaMultiplicar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Operacion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Tabla Multiplicar</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d770a336f822c3628be592844456b4e15506b3043630", async() => {
                WriteLiteral("\r\n    <input type=\"number\" name=\"num\" />\r\n    <button type=\"submit\" class=\"btn btn-info\">Mostrar tabla</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr/>\r\n");
#nullable restore
#line 8 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table style=""width:80%;border:solid"">
        <thead style=""border:solid"">
            <tr style=""border:solid;background-color:grey;color:white"">
                <th>Numero 1</th>
                <th></th>
                <th>Numero 2</th>
                <th></th>
                <th>Resultado</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
             foreach(Operacion op in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"border:solid\">\r\n                    <td>");
#nullable restore
#line 24 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
                   Write(op.n1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>x</td>\r\n                    <td>");
#nullable restore
#line 26 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
                   Write(op.n2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>=</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
                   Write(op.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 33 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\TablaMultiplicar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Operacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
