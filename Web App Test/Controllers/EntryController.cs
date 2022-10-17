using Microsoft.AspNetCore.Mvc;

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
            switch (op){
                case "+":
                    return Content((a + b).ToString());
                    break;
                case "-":
                    return Content((a - b).ToString());
                    break ;
                case "*":
                    return Content((a * b).ToString());
                    break;
                case "/":
                    return Content((a / b).ToString());
                    break;
                default:
                    return Content("erro :(");
                    break;
            }
              
        }
    }
}
