using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return RedirectToAction("GetAllCustomer", "Customer");
        }

        [ActionName("CurrentTime")]
        public string GetCurrentTume()
        {
            return TimeString();
        }
        [NonAction]
        public string TimeString()
        {
            return DateTime.Now.ToString();
        }
    }
}

/*
 HttpGet
HttpPost
HttpPut
HttpDelete
HttpOptions
HttpPatch
 */

/*
    ContentResult - возвращает строку
    FileContentResult - возвращает соднржимое файла
    FilePathResult - возвращает соднржимое файла
    FileStreamResult - возвращает соднржимое файла
    EmptyResult - ничего не возвращает
    JavaScriptResult - возвращает скрипт для выполнения
    JsonResult - возвращает данные в формате JSON
    RedirectToresult - перенаправляет на указанный URL
    HttpUnauthorizedResult - возвращает 403 код состояния HTTP
    RedirectToRouteResult - перенаправляет на другое действие/другое действие контроллера
    ViewResult - получено в качестве ответа для механизма просмотра
    PartialViewResult - получен в качестве ответа для механизма просмотра
 */