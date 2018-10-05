using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class EmployeeIndexViewModel
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Description { get; set; }
        public Employee Employee { get; set; }
        public string ImgURL { get; set; }
    }
}