#pragma checksum "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\Pedidoes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bef97cebb212c12e76551a3aa8ba47f56448c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidoes_Edit), @"mvc.1.0.view", @"/Views/Pedidoes/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidoes/Edit.cshtml", typeof(AspNetCore.Views_Pedidoes_Edit))]
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
#line 1 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\_ViewImports.cshtml"
using BarC;

#line default
#line hidden
#line 2 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\_ViewImports.cshtml"
using BarC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bef97cebb212c12e76551a3aa8ba47f56448c2", @"/Views/Pedidoes/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caeae47e419fc3ce689c4773f071c3a23bd0d1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidoes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BarC.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\Pedidoes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(69, 80, true);
            WriteLiteral("\r\n<h2>Editar Pedido</h2>\r\n<hr />\r\n\r\n<div>\r\n    <a class=\"btn btn-warning btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 149, "\"", 190, 1);
#line 11 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\Pedidoes\Edit.cshtml"
WriteAttributeValue("", 156, Url.Action("Create","Productoes"), 156, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(191, 79, true);
            WriteLiteral(">Agregar Productos</a>\r\n    </div>\r\n<div>\r\n    <a class=\"btn btn-danger btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 270, "\"", 311, 1);
#line 14 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\Pedidoes\Edit.cshtml"
WriteAttributeValue("", 277, Url.Action("Create","Productoes"), 277, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(312, 75, true);
            WriteLiteral(">Eliminar Producto</a>\r\n</div>\r\n<div>\r\n    <a class=\"btn btn-danger btn-lg\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 387, "\"", 431, 1);
#line 17 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\Pedidoes\Edit.cshtml"
WriteAttributeValue("", 394, Url.Action("Consultar","Productoes"), 394, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 52, true);
            WriteLiteral(">Consultar Producto</a>\r\n</div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(484, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97febe5f41004c23909fdfaa4dc3a04f", async() => {
                BeginContext(534, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(544, 33, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(577, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcf6fc8427bf4403915d2ea09404df1f", async() => {
                BeginContext(627, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(637, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(675, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\Administrador.DESKTOP-RVH9C23\Desktop\lalala\BarC\BarC\Views\Pedidoes\Edit.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(749, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BarC.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591