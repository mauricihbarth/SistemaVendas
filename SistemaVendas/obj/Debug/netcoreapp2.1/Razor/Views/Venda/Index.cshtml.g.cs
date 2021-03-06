#pragma checksum "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e23d2eac71b7fbb125e8e8d68689551d6fc6b3d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Index), @"mvc.1.0.view", @"/Views/Venda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venda/Index.cshtml", typeof(AspNetCore.Views_Venda_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e23d2eac71b7fbb125e8e8d68689551d6fc6b3d9", @"/Views/Venda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b8143e28e2ecf99681febd0458bd3a62631f08", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 268, true);
            WriteLiteral(@"<h2>Index</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Data</th>
            <th>Vendedor</th>
            <th>Cliente</th>
            <th>Total</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 15 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
          
            foreach (var item in (List<VendaModel>)ViewBag.ListaVendas)
            {

#line default
#line hidden
            BeginContext(368, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(415, 7, false);
#line 19 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(422, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(454, 9, false);
#line 20 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(463, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(495, 16, false);
#line 21 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.Vendedor_Id);

#line default
#line hidden
            EndContext();
            BeginContext(511, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(543, 15, false);
#line 22 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                   Write(item.Cliente_Id);

#line default
#line hidden
            EndContext();
            BeginContext(558, 34, true);
            WriteLiteral("</td>\r\n                    <td>R$ ");
            EndContext();
            BeginContext(593, 10, false);
#line 23 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
                      Write(item.Total);

#line default
#line hidden
            EndContext();
            BeginContext(603, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 25 "C:\Users\mhbarth\source\repos\SistemaVendas\SistemaVendas\Views\Venda\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(659, 288, true);
            WriteLiteral(@"    </tbody>
</table>

<br />

<div class=""col-lg-2"">
    <button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Registrar </button>
</div>


<script>

    function Cadastrar() {
        window.location.href = ""../Venda/Registrar""
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
