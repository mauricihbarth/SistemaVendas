#pragma checksum "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07e15efd43b5c8ac5d3d1d68731318c927c0d29f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07e15efd43b5c8ac5d3d1d68731318c927c0d29f", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 295, true);
            WriteLiteral(@"
<h3>Lista de Clientes</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Nome</th>
            <th>CPF</th>
            <th>Email</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 17 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
          
            foreach (var item in (List<ClienteModel>)ViewBag.ListaClientes)
            {

#line default
#line hidden
            BeginContext(399, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 490, "\"", 516, 3);
            WriteAttributeValue("", 500, "Editar(", 500, 7, true);
#line 21 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 507, item.Id, 507, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 515, ")", 515, 1, true);
            EndWriteAttribute();
            BeginContext(517, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 608, "\"", 635, 3);
            WriteAttributeValue("", 618, "Excluir(", 618, 8, true);
#line 22 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 626, item.Id, 626, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 634, ")", 634, 1, true);
            EndWriteAttribute();
            BeginContext(636, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(685, 7, false);
#line 23 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(692, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(724, 9, false);
#line 24 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(733, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(765, 12, false);
#line 25 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.CpfCnpj);

#line default
#line hidden
            EndContext();
            BeginContext(777, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(809, 10, false);
#line 26 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(819, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Cliente\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(875, 468, true);
            WriteLiteral(@"    </tbody>
</table>

<br />

<button class=""btn btn-block btn-primary"" type=""button"" style=""height:50px"" onclick=""Cadastrar()"">Cadastrar Cliente</button>

<script>

    function Cadastrar() {
        window.location.href = ""../Cliente/Cadastro""
    }
    function Editar(id) {
        window.location.href = ""../Cliente/Cadastro/"" + id;
    }
    function Excluir(id) {
        window.location.href = ""../Cliente/Excluir/"" + id;
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
