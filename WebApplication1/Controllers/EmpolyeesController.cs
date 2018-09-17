using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpolyeesController : Controller
    {
        EmployeeModel context = new EmployeeModel();
        // GET: Empolyees
        public ActionResult Index()
        {
            IEnumerable<Employee> emps =  context.Employees;
            ViewData.Add("Mustafa", emps);
            return View();
        }
    }
}