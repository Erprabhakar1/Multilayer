using BusinessLayer_BAL;
using CommanLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLayer_architecture.Controllers
{
    public class EmployeeController_cs : Controller
    {
        EmployeeBusiness business = new EmployeeBusiness(); 
        public IActionResult Index()
        {
            var employee = new List<Employee>();
            try
            {
                employee = business.GetEmployee();
                return View(employee);
            }
            catch (Exception)
            {

                throw;
            }
   
        }
    }
}
