using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajottalimCRM1.Entities.DTOs;
using NajottalimCRM1.MyPettern;

namespace NajottalimCRM1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _sttudentRepo;

        public StudentsController(IStudentRepository sttudentRepo)
        {
            _sttudentRepo = sttudentRepo;
        }

        [HttpPost]
        public IActionResult CreateStudsadadsdent(StudentDTO model)
        {
            try
            {
                var responnse = _sttudentRepo.CreateStudent(model);
                return Ok(responnse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GettAllStudentsFromDB()
        {
            try
            {
                var response = _sttudentRepo.GetAllStudents();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        
    }
}
