using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class CustomerController : Controller
    {
        public string GetAllCustomer()
        {
            return "Возврат всех сотрудников";
        }
    }
}
