using MVC_LoggingExceptionWebApp.CustomFilter;
using MVC_LoggingExceptionWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_LoggingExceptionWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        //// GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}

        ApplicationModel ctx = new ApplicationModel();
        // GET: Employee
        public ActionResult Index()
        {
            var Emps = ctx.Employees.ToList();
            return View(Emps);
        }

        public ActionResult Create()
        {
            return View(new EmployeeInfo());
        }

        [ExceptionHandler]
        [HttpPost]
        public ActionResult Create(EmployeeInfo Emp)
        {

            if (Emp.Designation == "Manager" && (Emp.Salary < 40000 || Emp.Salary > 80000))
            {
                throw new Exception("Salary is not Matching with Manager Designatgion");
            }
            else
            if (Emp.Designation == "Operator" && (Emp.Salary < 10000 || Emp.Salary > 20000))
            {
                throw new Exception("Salary is not Matching with Operator Designatgion");
            }
            else
            {
                ctx.Employees.Add(Emp);
                ctx.SaveChanges();

            }


            return View(Emp);
        }
    }
}