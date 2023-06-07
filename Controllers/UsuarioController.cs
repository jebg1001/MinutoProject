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
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly ApplicationDbContext _context;
        private List<Usuario> listUsuarios= new List<Usuario>();
        private List<Usuario> listUserNew= new List<Usuario>();
        public UsuarioController(ILogger<UsuarioController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            listUsuarios=_context.Usuarios.ToList();
        }

        public IActionResult Index()
        {
            dynamic modelo= new ExpandoObject();
            modelo.Usuarios=listUsuarios;
            listUserNew.Add(new Usuario());
            modelo.UsuarioNew = listUserNew;
            return View("Index",modelo); 
        }

        public IActionResult Enviar(Usuario req){
            if(ModelState.IsValid){
                _context.Usuarios.Add(req);
                _context.SaveChanges();
                return RedirectToAction("Index","Usuario");
            }else{
                return RedirectToAction("Index");
            }
        }
        
        public IActionResult Eliminar(Usuario req)
        {
            Usuario envio= _context.Usuarios.Where(r => r.email == req.email).FirstOrDefault();
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
