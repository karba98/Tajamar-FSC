#pragma checksum "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb02759d2407ddef3d23374624735c8902da5f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matematicas_Collatz), @"mvc.1.0.view", @"/Views/Matematicas/Collatz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb02759d2407ddef3d23374624735c8902da5f9", @"/Views/Matematicas/Collatz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7621cb76ff106b7b8ab31904fb03fe56478a294c", @"/Views/_ViewImports.cshtml")]
    public class Views_Matematicas_Collatz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<int>>
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
#nullable restore
#line 2 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
   
    List<int> numeros = ViewBag.Numeros as List<int>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Collatz</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb02759d2407ddef3d23374624735c8902da5f93790", async() => {
                WriteLiteral("\r\n    <input type=\"number\" name=\"numero\" />\r\n    <button type=\"submit\">¿Es igual a 1?</button>\r\n");
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
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 11 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
 if ( numeros != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
     foreach (int i in ViewBag.Numeros)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
   Write(Html.ActionLink(i.ToString() + "  ", "Collatz", "Matematicas", new { numero = i }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
                                                                                           
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 20 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
 if (Model != null)
{
    foreach (int i in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
         if (i == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 style=\"color:blue\">");
#nullable restore
#line 26 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 27 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 30 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 31 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\MCSD\MDFS\MDFS-4\NetCore\ProyectoMatematicas\Views\Matematicas\Collatz.cshtml"
         
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<int>> Html { get; private set; }
    }
}
#pragma warning restore 1591