using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {
        
        EmployeeModel context = new EmployeeModel();
        // GET: Empolyees
        public ActionResult Index(string textSearch)
        {
            IEnumerable<Employee> empsen = context.Employees.Where(a=>a.IsDeleted!=true);
            List<Employee> emps;
            if (textSearch==null)
            {
                emps = empsen.ToList();
            }
            else
            {
                ViewBag.SearchValue = textSearch;
                emps = empsen.Where(a=>a.Salary.ToString()==textSearch||a.UserName.ToLower().Contains(textSearch.ToLower())||a.EmployeeLangs.FirstOrDefault(b=>b.Name.ToLower().Contains(textSearch.ToLower()))!=null).ToList();
            }

            
            List<EmployeeIndexViewModel> empsVM = new List<EmployeeIndexViewModel>();
            foreach (Employee employee in emps)
            {
                empsVM.Add(new EmployeeIndexViewModel
                {
                    Name = employee.EmployeeLangs.FirstOrDefault(a => a.EnumLang.Code == "En-US").Name,
                    Description= employee.EmployeeLangs.FirstOrDefault(a => a.EnumLang.Code == "En-US").Description,
                    ImgURL= employee.ImageLarge,
                    Salary = (int)employee.Salary,
                    Employee = employee
                });
            }
            return View(empsVM);
        }
        public ActionResult Delete(int id)
        {
            context.Employees.Find(id).IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Details(int? id)
        {
            return View();
        }

    }
}