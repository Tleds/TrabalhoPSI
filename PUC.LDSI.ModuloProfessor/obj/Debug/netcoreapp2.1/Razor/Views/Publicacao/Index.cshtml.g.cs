#pragma checksum "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02cbf07c347583a40759268e29f17ee3c56205b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PUC.LDSI.ModuloProfessor.Pages.Views.Publicacao.Views_Publicacao_Index), @"mvc.1.0.view", @"/Views/Publicacao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Publicacao/Index.cshtml", typeof(PUC.LDSI.ModuloProfessor.Pages.Views.Publicacao.Views_Publicacao_Index))]
namespace PUC.LDSI.ModuloProfessor.Pages.Views.Publicacao
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\_ViewImports.cshtml"
using PUC.LDSI.ModuloProfessor;

#line default
#line hidden
#line 2 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\_ViewImports.cshtml"
using PUC.LDSI.ModuloProfessor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02cbf07c347583a40759268e29f17ee3c56205b2", @"/Views/Publicacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"accf249d7bafc46b91ab17b28454b4df98a041b5", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b82f82ef274679fca069479be055279a5ace83", @"/Views/_ViewImports.cshtml")]
    public class Views_Publicacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PUC.LDSI.Domain.Entities.Publicacao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
  
    ViewData["Title"] = "Publicações";

#line default
#line hidden
            BeginContext(101, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(107, 17, false);
#line 7 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 15, true);
            WriteLiteral("</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(139, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db79e3a1faf4a27a5f20c8aa3f5b854", async() => {
                BeginContext(186, 15, true);
                WriteLiteral("Nova Publicação");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(205, 501, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr style=""background-color:lightblue"">
            <th>
                Turma
            </th>
            <th>
                Avaliação
            </th>
            <th>
                Valor
            </th>
            <th>
                Publicado Em
            </th>
            <th>
                Início
            </th>
            <th>
                Fim
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(737, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(786, 45, false);
#line 41 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Turma.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(831, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(888, 93, false);
#line 44 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
            Write(item.Avaliacao.Materia + " - " + item.Avaliacao.Disciplina + " - " + item.Avaliacao.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(982, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1038, 45, false);
#line 47 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorProva));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1140, 112, false);
#line 50 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
            Write(item.DataPublicacao.ToString("dd/MM/yyyy") + " - " + item.DataPublicacao.Hour + ":" + item.DataPublicacao.Minute);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1310, 100, false);
#line 53 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
            Write(item.DataInicio.ToString("dd/MM/yyyy") + " - " + item.DataInicio.Hour + ":" + item.DataInicio.Minute);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1468, 91, false);
#line 56 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
            Write(item.DataFim.ToString("dd/MM/yyyy") + " - " + item.DataFim.Hour + ":" + item.DataFim.Minute);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1615, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a5174215bce454cb62af2038989ce97", async() => {
                BeginContext(1660, 53, true);
                WriteLiteral("<i class=\"fas fa-edit\" title=\"Editar Publicação\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1717, 76, true);
            WriteLiteral("&nbsp;\r\n                <!--\r\n        <a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(1794, 7, false);
#line 61 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
                                         Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1801, 101, true);
            WriteLiteral("\"><i class=\"fas fa-tools\" title=\"Visualizar Publicação\"></i></a>&nbsp;\r\n        -->\r\n                ");
            EndContext();
            BeginContext(1902, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a52cf118157f47aca6db3667e6222abb", async() => {
                BeginContext(1949, 59, true);
                WriteLiteral("<i class=\"far fa-trash-alt\" title=\"Excluir Publicação\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2012, 41, true);
            WriteLiteral("&nbsp;\r\n            </td>\r\n        </tr>\n");
            EndContext();
#line 66 "C:\Users\Tiago\OneDrive\Área de Trabalho\porultimo\Quase\quase\entrega_3\TrabalhoPSI\PUC.LDSI.ModuloProfessor\Views\Publicacao\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2055, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PUC.LDSI.Domain.Entities.Publicacao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
