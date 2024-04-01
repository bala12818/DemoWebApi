using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            string[] EmployeeNames = new string[] { "Bala", "Ranga", "sai" };
            return Ok(EmployeeNames);
        }
    }
}
