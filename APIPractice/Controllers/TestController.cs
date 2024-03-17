using APIPractice.Data;
using APIPractice.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace APIPractice.Controllers
{
    [Route("api/Test")]
    //[ApiController]
    public class TestController : Controller
    {

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudent()
        {
            return Ok(StudentDb.result);
        }
        [HttpGet("id:int",Name ="GetStudent")]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Student> GetStudent(int Id)
        {
            if(Id == 0) { 
            return BadRequest();
            }
            var studentById = StudentDb.result.FirstOrDefault(s => s.id == Id);
            if(studentById == null)
            {
                return NotFound();
            }
            return Ok(studentById);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<Student> createStudent([FromBody]Student student)
        {
            //if(!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if(StudentDb.result.FirstOrDefault(s=>s.studentName.ToLower()==student.studentName.ToLower())!=null)
            {
                ModelState.AddModelError("", "student name is already exist");
                return BadRequest(ModelState);

            }
            if (student == null)
            {
                return BadRequest();
            }
            if(student.id>0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
            student.id=StudentDb.result.OrderByDescending(s => s.id).FirstOrDefault().id+1;
            StudentDb.result.Add(student);
            return CreatedAtRoute("GetStudent", new { Id = student.id },student);
        }
        //[HttpDelete("id:int")]
        //public ActionResult<Student> DeleteStudent(int Id, Student student)
        //{
        //    if (Id == student.id) { }

        //}
    }
}
