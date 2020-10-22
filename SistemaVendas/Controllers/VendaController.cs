using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class VendaController : Controller
    {

        private IHttpContextAccessor httpContextAccessor;
        //Recebe o contexto Http via injeção de dependência

        public VendaController(IHttpContextAccessor HttpContextAcessor)
        {
            this.httpContextAccessor = HttpContextAcessor;
        } 

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ListaVendas = new VendaModel().ListagemVendas();
            return View();
        }


        [HttpGet]
        public IActionResult Registrar()
        {
            CarregarDados();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(VendaModel venda)
        {
            venda.Vendedor_Id = httpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

                //HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);

            venda.Inserir();
            CarregarDados();
            return View();
        }

        private void CarregarDados()
        {

            ViewBag.ListaClientes = new VendaModel().RetornarListaClientes();
            ViewBag.ListaVendedores = new VendaModel().RetornarListaVendedores();
            ViewBag.ListaProdutos = new VendaModel().RetornarListaProdutos();
        }


    }
}