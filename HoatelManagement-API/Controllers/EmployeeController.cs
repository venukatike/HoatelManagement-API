using HostelManagement.Core.Entities;
using HostelManagement.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HoatelManagement_API.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class StudentsController : ControllerBase
        {
            private readonly IEmployeeRepository _employeeRepository;

            public StudentsController(IEmployeeRepository employeeRepository)
            {
                _employeeRepository = employeeRepository;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<EmployeeEntity>>> GetAllStudents()
            {
                var students = await _employeeRepository.GetEmployees();
                return Ok(students);
            }


        }
    }

