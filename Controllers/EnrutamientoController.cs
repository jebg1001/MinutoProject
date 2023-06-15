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
    public class EnrutamientoController : Controller
    {
        private readonly ILogger<EnrutamientoController> _logger;
        private readonly ApplicationDbContext _context;
        private List<Enrutamiento> listEnrutamientos = new List<Enrutamiento>();

        public EnrutamientoController(ILogger<EnrutamientoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            listEnrutamientos=_context.Enrutamientos.ToList();
        }

        public IActionResult Index()
        {
            dynamic modelo= new ExpandoObject();
            modelo.Enrutamiento= new List<Enrutamiento>();
            return View("Index",modelo); 
        }

        public IActionResult GetRuta()
        {
            dynamic modelo= new ExpandoObject();
            modelo.Enrutamiento= listEnrutamientos;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
            return View("Index",modelo); 
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
