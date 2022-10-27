using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web_App_Test.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult CalculadoraFixe()
        {
            return View();
        }
        
        public IActionResult numero(string num)
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
            HttpContext.Session.SetString("operador", "+");

            return View("CalculadoraFixe");
        }

        public IActionResult sub()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");
            HttpContext.Session.SetString("operador", "-");

            return View("CalculadoraFixe");
        }

        public IActionResult mult()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");
            HttpContext.Session.SetString("operador", "*");

            return View("CalculadoraFixe");
        }

        public IActionResult div()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");
            HttpContext.Session.SetString("operador", "/");

            return View("CalculadoraFixe");
        }

        public IActionResult result()
        {
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");
            int res = Convert.ToInt32(HttpContext.Session.GetInt32("res") ?? 0);

            String operador = HttpContext.Session.GetString("operador") ?? "";

            HttpContext.Session.SetString("op", res.ToString());

            int resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = res + op;
                    break;
                case "-":
                    resultado = res - op;
                    break;
                case "*":
                    resultado = res * op;
                    break;
                case "/":
                    resultado = res / op;
                    break;
                case "^":
                    resultado = Convert.ToInt32(Math.Pow(res, op));
                    break;
            }

            HttpContext.Session.SetString("op", resultado.ToString());
            return View("CalculadoraFixe");
        }

        public IActionResult clear()
        {
            HttpContext.Session.SetString("op", "");

            return View("CalculadoraFixe");
        }

        public IActionResult sqrt()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");

            res = Convert.ToInt32(Math.Sqrt(op));

            HttpContext.Session.SetString("op", res.ToString());

            return View("CalculadoraFixe");
        }

        public IActionResult power()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");
            HttpContext.Session.SetString("operador", "^");

            return View("CalculadoraFixe");
        }

        public IActionResult fraction()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");

            res = Convert.ToInt32(1 / op);

            HttpContext.Session.SetString("op", res.ToString());

            return View("CalculadoraFixe");
        }

        public IActionResult inverse()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");

            res = Convert.ToInt32(-op);

            HttpContext.Session.SetString("op", res.ToString());

            return View("CalculadoraFixe");
        }

        public IActionResult factorial()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");

            int n = op;

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
                op--;
            }

            res = Convert.ToInt32(n);

            HttpContext.Session.SetString("op", res.ToString());

            return View("CalculadoraFixe");
        }

        public IActionResult module()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetInt32("res", res);

            HttpContext.Session.SetString("op", "");

            if(res < 0)
            {
                res = Convert.ToInt32(-op);
            }     

            HttpContext.Session.SetString("op", res.ToString());

            return View("CalculadoraFixe");
        }

        public IActionResult CalcAjax()
        {
            return View();
        }

        public IActionResult OperandAjax(string digit)
        {
            string op = HttpContext.Session.GetString("op") ?? "";

            op += digit;

            HttpContext.Session.SetString("op", op);

            return Ok(op);
        }

        public IActionResult ClearOperandAjax()
        {
            HttpContext.Session.SetString("op", "");

            return Ok("");
        }

        public IActionResult OperationAjax()
        {
            int res = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            HttpContext.Session.SetString("op", "");

            HttpContext.Session.SetInt32("res", res);

            return Ok("");
        }

        public IActionResult ResultAjax()
        {
            int op = Convert.ToInt32(HttpContext.Session.GetString("op") ?? "");

            int res = (HttpContext.Session.GetInt32("res") ?? 0) + op;

            HttpContext.Session.SetString("op", res.ToString());

            return Ok(res);
        }
    }
}
