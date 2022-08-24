using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewDemoMVC.Models;

namespace ViewDemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            /*var employees = from e in GetEmployeeList()
                            orderby e.Id
                            select e;*/
            var employes = from e in employees
                            orderby e.Id
                            select e;
            return View(employes);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            List<Employee> emplList = employees;
            var employee = emplList.Single(m => m.Id == id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var employee = employees.Single(m => m.Id == id);
                TryUpdateModelAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 0,
                    Name = "Ivan",
                    CreateDate = DateTime.Parse("11-11-2001"),
                    Age = 21
                },
                new Employee
                {
                    Id = 1,
                    Name = "Vasya",
                    CreateDate = DateTime.Parse("12-12-2012"),
                    Age = 20
                },
                new Employee
                {
                    Id = 2,
                    Name = "Petya",
                    CreateDate = DateTime.Parse("13-12-2013"),
                    Age = 19
                }
            };
        }

        public static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 0,
                Name = "Ivan",
                CreateDate = DateTime.Parse("11-11-2001"),
                Age = 21
            },
            new Employee
            {
                Id = 1,
                Name = "Vasya",
                CreateDate = DateTime.Parse("12-12-2012"),
                Age = 20
            },
            new Employee
            {
                Id = 2,
                Name = "Petya",
                CreateDate = DateTime.Parse("13-12-2013"),
                Age = 19
            }
        };
    }
}
