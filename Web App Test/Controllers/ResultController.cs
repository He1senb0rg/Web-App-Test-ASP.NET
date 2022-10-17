using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_App_Test.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult ContentResult()
        {
            return Content("Exemplo Conteudo");
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        public IActionResult JsonResult()
        {
            return Json(new
            {
                marca = "teu",
                modelo = "pai"
            }
                );
        }

        public IActionResult FileResult()
        {
            return File("~/TextFile.txt", "text/plain");
        }

        public RedirectResult EpgeResult()
        {
            return Redirect("https://www.gustaveeiffel.pt");
        }

        public RedirectToRouteResult PrivacyResult()
        {
            return RedirectToRoute(
                new
                {
                    controller = "Home",
                    action = "Privacy"
                }
            );
        }

        public IActionResult StatusResult()
        {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            //return new StatusCodeResult(StatusCodes.Status200OK);
            //return new StatusCodeResult(StatusCodes.Status401Unauthorized);
        }
    }
}
