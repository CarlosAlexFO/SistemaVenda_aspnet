using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;


namespace SistemaVendas.Controllers
{
    public class VendaController : Controller
    {
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(VendaModel venda)
        {
            return View();
        }

        private void CarregarDados()
        {
            ViewBag.ListasClientes = new VendaModel().RetornarListaClientes();
            ViewBag.ListasVendedores = new VendaModel().RetornarListaVendedores();
        }
    }
}