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
namespace MinutosProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ApplicationDbContext _context;

        public LoginController(ILogger<LoginController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logueo(Usuario usuario)
        {
            var userLogged= new Usuario();
            var listUsuarios=_context.Usuarios.ToList();
            for(int i=0; i<listUsuarios.Count; i++){
                Usuario user = listUsuarios[i];
                if(user.email==usuario.email && user.password==usuario.password){
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
