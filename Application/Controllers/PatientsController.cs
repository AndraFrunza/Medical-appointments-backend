using BusinessLogic.Dtos;
using BusinessLogic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientsController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpGet("id/{id}")]
        public IActionResult GetById(int id)
        {
            var patient = patientService.GetById(id);
            if (patient == null)
                return BadRequest(new { message = $"Nu exista niciun pacient cu id-ul {id}" });

            return Ok(patient);
        }

        [HttpGet("number/{number}")]
        public IActionResult GetByMobilePhone(int number)
        {
            var patient = patientService.GetByMobilePhone(number);
            if (patient == null)
                return BadRequest(new { message = $"Nu exista niciun pacient cu numarul de telefon {number}" });

            return Ok(patient);
        }

        [HttpPost]
        public IActionResult Create(PatientDto patient)
        {
            patient = patientService.Create(patient);
            return Ok(patient);
        }

        [HttpPut]
        public IActionResult Update(PatientDto patient)
        {
            patient = patientService.Update(patient);
            return Ok(patient);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            patientService.Delete(id);
            return Ok();
        }

        //[Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var patients = patientService.GetAll();
            return Ok(patients);
        }
    }
}
