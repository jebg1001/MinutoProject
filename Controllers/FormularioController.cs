using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinutosProject.Models;
using MinutosProject.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Dynamic;

namespace MinutosProject.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;
        private readonly ApplicationDbContext _context;

        public FormularioController(ILogger<FormularioController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {   
            var envio = new List<Envio>();
            envio.Add(new Envio());
            dynamic modelo = new ExpandoObject();
            modelo.Auxiliar = _context.Auxiliares.ToList();
            modelo.Courier = _context.Couriers.ToList();
            modelo.Empresa = _context.Empresas.ToList();
            modelo.TipoServicio = _context.Servicios.ToList();
            modelo.TipoMercaderia = _context.Mercaderias.ToList();
            modelo.Envio = envio;
            return View(modelo);
        }

        public IActionResult Enviar(Envio req){
            if(ModelState.IsValid){
                _context.Envios.Add(req);
                _context.SaveChanges();
                return RedirectToAction("Listado","Index");

            }else{
                return RedirectToAction("Index");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
