using BusinessLogic.Dtos;
using BusinessLogic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        public DoctorsController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var doctor = doctorService.GetById(id);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {id}" });

            return Ok(doctor);
        }

        [HttpGet]
        public IActionResult GetBySpecialization(string specialization)
        {
            var doctor = doctorService.GetBySpecialization(specialization);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {specialization}" });

            return Ok(doctor);
        }

        [HttpGet]
        public IActionResult GetByMobilePhone(int number)
        {
            var doctor = doctorService.GetByMobilePhone(number);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {number}" });

            return Ok(doctor);
        }

        [HttpGet]
        public IActionResult GetByFirstName(string firstname)
        {
            var doctor = doctorService.GetByFirstName(firstname);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {firstname}" });

            return Ok(doctor);
        }

        [HttpGet]
        public IActionResult GetByLastName(string lastname)
        {
            var doctor = doctorService.GetByLastName(lastname);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {lastname}" });

            return Ok(doctor);
        }

        [HttpGet]
        public IActionResult GetByEmail(string email)
        {
            var doctor = doctorService.GetByEmail(email);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {email}" });

            return Ok(doctor);
        }

        [HttpPost]
        public IActionResult Create(DoctorDto doctor)
        {
            doctor = doctorService.Create(doctor);
            return Ok(doctor);
        }

        [HttpPut]
        public IActionResult Update(DoctorDto doctor)
        {
            doctor = doctorService.Update(doctor);
            return Ok(doctor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            doctorService.Delete(id);
            return Ok();
        }

        //[Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var doctors = doctorService.GetAll();
            return Ok(doctors);
        }
    }
}
