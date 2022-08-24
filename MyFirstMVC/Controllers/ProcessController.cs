using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class ProcessController : Controller
    {
        public string List()
        {
            return "This is Process page";
        }
    }
}
