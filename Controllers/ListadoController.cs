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
using System.Dynamic;
using Microsoft.AspNetCore.Http;

namespace MinutosProject.Controllers
{
    public class ListadoController : Controller
    {
        private readonly ILogger<ListadoController> _logger;
        private readonly ApplicationDbContext _context;
        private List<Auxiliar> listAuxiliar= new List<Auxiliar>();
        private List<Courier> listCourier= new List<Courier>();
        private List<Empresa> listEmpresa = new List<Empresa>();
        private List<Envio> listEnvios = new List<Envio>();
        private List<TipoMercaderia> listMercaderia = new List<TipoMercaderia>();
        private List<TipoServicio> listServicio = new List<TipoServicio>();

        public ListadoController(ILogger<ListadoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            listAuxiliar=_context.Auxiliares.ToList();
            listCourier=_context.Couriers.ToList();
            listEmpresa=_context.Empresas.ToList();
            listMercaderia=_context.Mercaderias.ToList();
            listServicio=_context.Servicios.ToList();
            listEnvios=_context.Envios.ToList();
        }

        public IActionResult Index()
        {
            dynamic modelo= new ExpandoObject();
            modelo.Auxiliares=listAuxiliar;
            modelo.Couriers=listCourier;
            modelo.Empresas=listEmpresa;
            modelo.Mercaderias=listMercaderia;
            modelo.Servicios=listServicio;
            modelo.Envios=listEnvios;
            return View("Index",modelo); 
        }
        
        public IActionResult Eliminar(Envio req)
        {
            Envio envio= _context.Envios.Where(r => r.ID == req.ID).FirstOrDefault();
            _context.Remove(envio);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
