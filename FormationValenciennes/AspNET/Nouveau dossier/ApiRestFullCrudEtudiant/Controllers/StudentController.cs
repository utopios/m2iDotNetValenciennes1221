 using ApiRestFullCrudEtudiant.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ApiRestFullCrudEtudiant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }
        

        [HttpGet]       
        public ActionResult<List<Student>> Get()
        {
            return Student.Get();
        }

        
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return Student.Get(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student s)
        {
            if(s.Gender != "" && s.FirstName != "" &&s.LastName != "" && s.Email != "" && s.StudentNumber != 0)
            {
                s.Id = s.Add();
                if (s.Id > 0)                
                    return Ok(new { message = " Student added ", s.Id, error = false });
                else
                    return Ok(new { message = "Erreur server", error = true });
            }
            else
                return Ok(new { message = "Erreur Server", error = true });

        }



        [HttpPut]
        public ActionResult Update([FromBody] Student s)
        {
            if (s.Id != 0 && s.Gender != "" && s.FirstName != "" && s.LastName != "" && s.Email != "" && s.StudentNumber != 0)
            {
                if (s.Update())
                    return Ok(new { message = "Student Updated", error = false, s.Id });
                else
                    return Ok(new { message = "error server", error = true });
            }
            else
                return Ok(new { message = "error server", error = true });
        }



        // GET: StudentController/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (Student.Delete(id))
                return Ok(new { message = "Student Deleted", error = false, id });
            else
                return Ok(new { message = "error server", error = true });
        }


     }
}
