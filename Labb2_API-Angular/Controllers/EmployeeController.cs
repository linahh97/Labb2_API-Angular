using Labb2_API_Angular.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb2_API_Angular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> _employeeRepo;
        public EmployeeController(IRepository<Employee> repository)
        {
            this._employeeRepo = repository;
        }

        //Get All Employees
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                return Ok(_employeeRepo.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database...");
            }
        }

        //Get Single Employee
        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetSingleEmployee")]
        public ActionResult<Employee> GetSingleEmployee([FromRoute] Guid id)
        {
            try
            {
                var result = _employeeRepo.GetOne(id);
                if (result == null)
                {
                    return NotFound("Employee Not Found...");
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database...");
            }
        }

        //Add Employee
        [HttpPost]
        public async Task<ActionResult<Employee>> AddNewEmployee([FromBody] Employee employee)
        {
            try
            {
                var addNew = await _employeeRepo.Create(employee);
                CreatedAtAction(nameof(GetSingleEmployee), new { id = addNew.EmployeeId }, addNew);
                return Ok(addNew);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database...");
            }
        }

        //Update Employee
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<ActionResult<Employee>> UpdateEmployee([FromRoute] Guid id, [FromBody] Employee employee)
        {
            try
            {
                var update = _employeeRepo.GetOne(id);
                if (update == null)
                {
                    return NotFound("Employee Not Found...");
                }
                return await _employeeRepo.Update(employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database...");
            }
        }

        //Delete Employee
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<ActionResult<Employee>> DeleteAnEmployee([FromRoute] Guid id)
        {
            try
            {
                var delete = _employeeRepo.GetOne(id);
                if (delete == null)
                {
                    return NotFound("Employee Not Found...");
                }
                return await _employeeRepo.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database...");
            }
        }
    }
}
