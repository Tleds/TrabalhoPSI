#pragma checksum "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0fbbdaad4ec2ea27b0c2867dd762cd7c2aaf5a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PUC.LDSI.ModuloAluno.Pages.Views.Prova.Views_Prova_PerformTest), @"mvc.1.0.view", @"/Views/Prova/PerformTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prova/PerformTest.cshtml", typeof(PUC.LDSI.ModuloAluno.Pages.Views.Prova.Views_Prova_PerformTest))]
namespace PUC.LDSI.ModuloAluno.Pages.Views.Prova
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\_ViewImports.cshtml"
using PUC.LDSI.ModuloAluno;

#line default
#line hidden
#line 2 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\_ViewImports.cshtml"
using PUC.LDSI.ModuloAluno.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0fbbdaad4ec2ea27b0c2867dd762cd7c2aaf5a9", @"/Views/Prova/PerformTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0760690a83d44e6cc9c28761c51f37049e085930", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025521faddbbbf0d8c4035ec06dc045788e642a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Prova_PerformTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PUC.LDSI.Domain.QueryResult.AvaliacaoPublicadaQueryResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/PerformTest.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml"
  
    ViewData["Title"] = "Realizar Prova";

#line default
#line hidden
            BeginContext(113, 39, true);
            WriteLiteral("\n<input id=\"PublicacaoId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 152, "\"", 179, 1);
#line 7 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml"
WriteAttributeValue("", 160, Model.PublicacaoId, 160, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(180, 4, true);
            WriteLiteral(" />\n");
            EndContext();
            BeginContext(184, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f88e6baf8f734dc58bc27f1d9fbcc35b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(253, 6, true);
            WriteLiteral("\n\n<h2>");
            EndContext();
            BeginContext(260, 17, false);
#line 10 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(277, 109, true);
            WriteLiteral("</h2>\n\n<hr />\n\n<div class=\"prova-container\">\n    <div class=\"row\">\n        <div class=\"col\">\n            <h4>");
            EndContext();
            BeginContext(388, 66, false);
#line 17 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml"
            Write(Model.Disciplina + " / " + Model.Materia + " / " + Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(455, 764, true);
            WriteLiteral(@"</h4>
        </div>
    </div>
    <div class=""row questao-container"">
        <div class=""col-md-1 questao-icon-navigation"">
            <i class=""fas fa-angle-double-left icon-navigation-left"" style=""font-size:40px""></i>
        </div>
        <div class=""col-md-10 opcoes-prova"">
            <div class=""opcoes-prova-enunciado""></div>
            <div class=""opcoes-prova-opcoes""></div>
            <div class=""opcoes-prova-submit"" style=""display:none"">
                <a id=""btnConcluirProva"" class=""btn btn-default"">Concluir Prova</a>
            </div>
        </div>
        <div class=""col-md-1 questao-icon-navigation"">
            <i class=""fas fa-angle-double-right icon-navigation-right"" style=""font-size:40px""></i>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1237, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 38 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloAluno\Views\Prova\PerformTest.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PUC.LDSI.Domain.QueryResult.AvaliacaoPublicadaQueryResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
