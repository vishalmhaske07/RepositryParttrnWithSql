using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositryParttrnWithSql.Models;
using RepositryParttrnWithSql.Repiostery.Interfaces;

namespace RepositryParttrnWithSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var GetAll =_student.GetAllStudents();
            if (GetAll==null)
                
            {
                return NotFound();

            }
            return Ok(GetAll);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id) { 
           StdentModel GetId = _student.GetStudentById(id);
            if (GetId == null) { 
            
            return NotFound();
            }
            return Ok(GetId);
 
        }
        [HttpPost]
        [Route("Creates")]
        public IActionResult Creates(StdentModel model) { 
        int Create =_student.CreateStudent(model);

            if (Create <=0)
            {
                return BadRequest("FAiled");
            }
            else
            {
                return Ok("Added" + Create);
            }


        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Updates(StdentModel model) {
            
            
                int Update = _student.UpdateStudent(model);

                if (Update <= 0)
                {
                    return BadRequest("FAiled");
                }
                else
                {
                    return Ok("Updated" + Update);
                }


            }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id) {

            int Delete = _student.DeleteStudent(id);

            if (Delete <= 0)
            {
                return BadRequest("FAiled");
            }
            else
            {
                return Ok("Deleted" + Delete);
            }


        }


    }
}
