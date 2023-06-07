using BusinessLogic.Dtos;
using BusinessLogic.Services.Abstract;
using BusinessLogic.Services.Interfaces;
using Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService doctorService;
        private readonly IUserService userService;
        public DoctorsController(IDoctorService doctorService, IUserService userService)
        {
            this.doctorService = doctorService;
            this.userService = userService;
        }

        [HttpGet("id/{id}")]
        public IActionResult GetById(int id)
        {
            var doctor = doctorService.GetById(id);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {id}" });

            return Ok(doctor);
        }

        [HttpGet("specialization/{specialization}")]
        public IActionResult GetBySpecialization(string specialization)
        {
            var doctor = doctorService.GetBySpecialization(specialization);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {specialization}" });

            return Ok(doctor);
        }

        [HttpGet("number/{number}")]
        public IActionResult GetByMobilePhone(string number)
        {
            var doctor = doctorService.GetByMobilePhone(number);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {number}" });

            return Ok(doctor);
        }

        [HttpGet("firstname/{firstname}")]
        public IActionResult GetByFirstName(string firstname)
        {
            var doctor = doctorService.GetByFirstName(firstname);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {firstname}" });

            return Ok(doctor);
        }

        [HttpGet("lastname/{lastname}")]
        public IActionResult GetByLastName(string lastname)
        {
            var doctor = doctorService.GetByLastName(lastname);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {lastname}" });

            return Ok(doctor);
        }

        [Authorize(RoleCodes.Patient)]
        [HttpGet("cabinet/{cabinet}")]
        public IActionResult GetByCabinetId(int cabinet)
        {
            var doctor = doctorService.GetByCabinetId(cabinet);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul de cabinet {cabinet}" });

            return Ok(doctor);
        }

        [HttpGet("email/{email}")]
        public IActionResult GetByEmail(string email)
        {
            var doctor = doctorService.GetByEmail(email);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul {email}" });

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


        
        [HttpGet("userId/{userId}")]
        public IActionResult GetDoctorByUserId(int userId)
        {
            var doctor = doctorService.GetDoctorByUserId(userId);
            if (doctor == null)
                return BadRequest(new { message = $"Nu exista niciun doctor cu id-ul de user {userId}" });

            return Ok(doctor);
        }
    }
}
