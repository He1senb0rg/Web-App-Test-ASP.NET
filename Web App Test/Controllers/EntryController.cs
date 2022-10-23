using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web_App_Test.Controllers
{
    public class EntryController : Controller
    {
        public IActionResult InputRouter(int id)
        {
            return Content(id.ToString());
        }

        public IActionResult InputQuery(int a, int b)
        {
            return Content(a.ToString() + " " + b.ToString());
        }

        [HttpGet]
        public IActionResult InputForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InputForm(int a, int b)
        {
            return Content((a + b).ToString());
        }

        [HttpGet]
        public IActionResult InputFormFixe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InputFormFixe(int a, int b, string op)
        {
            int res = 0;
            switch (op){
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break ;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    res = a / b;
                    break;
                default:
                    return Content("erro :(");
                    break;
            }
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.res = res;

            return View();
        }

        [HttpGet]
        public IActionResult BomForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BomForm(string name)
        {
            int hora = DateTime.Now.Hour;
            string dia = "";
            if(hora > 0 && hora < 12)
            {
                dia = "Bom dia, ";
            }
            else if(hora > 12 && hora < 20)
            {
                dia = "Bom tarde, ";
            }
            else if (hora > 20 && hora < 0)
            {
                dia = "Bom noite, ";
            }

            ViewData["dia"] = dia;
            ViewData["name"] = name;

            return View();
        }

        public IActionResult CalculadoraFixe()
        {
            return View();
        }
        
        public IActionResult numero(int num)
        {
            string op = HttpContext.Session.GetString("op") ?? "";

            op += num;

            HttpContext.Session.SetString("op", op);

            return View("CalculadoraFixe");
        }

        public IActionResult add()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");

            return View("CalculadoraFixe");
        }

        public IActionResult result()
        {
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            int res = (HttpContext.Session.GetInt32("res") ?? 0) + op;

            HttpContext.Session.SetString("op", res.ToString());

            return View("CalculadoraFixe");
        }
    }
}
