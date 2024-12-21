using EmployeePortal.EmployeeRepository;
using EmployeePortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePotal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository emp;
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this.emp = employeeRepository;       
        }
        [HttpGet]
        public async Task<ActionResult> EmployeeList()
        {
            var allEmployee = await emp.GetAllEmployee();
            return Ok(allEmployee);
        }
        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee vm)
        {
            await emp.SaveEmployee(vm);
            return Ok(vm);
        }
    }
}
