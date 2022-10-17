using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_App_Test.Models;

namespace Web_App_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /* Tipos de resposta
         * 
            * Resposta de Resultado
            
                ViewResult | PartialViewResult
                ContentResult
                EmptyResult
                JsonResult
                FileResult
                JavaResult
            
            * Redirecionamento
                
                RedirectResult
                RedirectToRouteResult

            * Resposta de Estado
                
                HttpStatusCode
                HttpUnauthorizedResult
                HttNotFoundResult
         
         */

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult T605()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
