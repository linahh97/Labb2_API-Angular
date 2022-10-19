using Labb2_API_Angular.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Labb2_API_Angular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IRepository<Department> _departmentRepo;
        public DepartmentController(IRepository<Department> repository)
        {
            this._departmentRepo = repository;
        }

        //Get All Departments
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            try
            {
                return Ok(_departmentRepo.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database...");
            }
        }
    }
}
