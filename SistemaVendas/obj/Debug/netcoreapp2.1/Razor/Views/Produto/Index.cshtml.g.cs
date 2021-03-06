#pragma checksum "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59ac9ec5d7772150c8fb6d3e285bed4d9ddcb50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas;

#line default
#line hidden
#line 2 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\_ViewImports.cshtml"
using SistemaVendas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59ac9ec5d7772150c8fb6d3e285bed4d9ddcb50", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 422, true);
            WriteLiteral(@"
    <h3>Lista de Produtos</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Nome</th>
            <th>Descricao</th>
            <th>Preço Unitário</th>
            <th>Quantidade Estoque</th>
            <th>Unidade de Medida</th>
            <th>Foto</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 20 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
          
            foreach (var item in (List<ProdutoModel>)ViewBag.ListaProdutos)
            {

#line default
#line hidden
            BeginContext(526, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 617, "\"", 643, 3);
            WriteAttributeValue("", 627, "Editar(", 627, 7, true);
#line 24 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
WriteAttributeValue("", 634, item.Id, 634, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 642, ")", 642, 1, true);
            EndWriteAttribute();
            BeginContext(644, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 735, "\"", 762, 3);
            WriteAttributeValue("", 745, "Excluir(", 745, 8, true);
#line 25 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
WriteAttributeValue("", 753, item.Id, 753, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 761, ")", 761, 1, true);
            EndWriteAttribute();
            BeginContext(763, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(812, 7, false);
#line 26 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(819, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(851, 9, false);
#line 27 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(860, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(892, 14, false);
#line 28 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
                   Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(906, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(938, 19, false);
#line 29 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
                   Write(item.Preco_Unitario);

#line default
#line hidden
            EndContext();
            BeginContext(957, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(989, 23, false);
#line 30 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
                   Write(item.Quantidade_Estoque);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1044, 19, false);
#line 31 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
                   Write(item.Unidade_Medida);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 35, true);
            WriteLiteral("</td>\r\n                    <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1098, "\"", 1119, 1);
#line 32 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1104, item.Link_Foto, 1104, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1120, 58, true);
            WriteLiteral(" width=\"150\" height=\"150\"/> </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Produto\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1204, 468, true);
            WriteLiteral(@"    </tbody>
</table>

<br />

<button class=""btn btn-block btn-primary"" type=""button"" style=""height:50px"" onclick=""Cadastrar()"">Cadastrar Produto</button>

<script>

    function Cadastrar() {
        window.location.href = ""../Produto/Cadastro""
    }
    function Editar(id) {
        window.location.href = ""../Produto/Cadastro/"" + id;
    }
    function Excluir(id) {
        window.location.href = ""../Produto/Excluir/"" + id;
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
