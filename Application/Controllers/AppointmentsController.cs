using BusinessLogic.Dtos;
using BusinessLogic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService appointmentService;
        public AppointmentsController(IAppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var appointment = appointmentService.GetById(id);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {id}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetByHour(int hour)
        {
            var appointment = appointmentService.GetByHour(hour);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {hour}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetBySymptom(string symptom)
        {
            var appointment = appointmentService.GetBySymptom(symptom);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {symptom}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetByMobilePhone(int number)
        {
            var appointment = appointmentService.GetByMobilePhone(number);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {number}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetByEmailAdress(string email)
        {
            var appointment = appointmentService.GetByEmailAdress(email);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {email}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetByDateOfBirth(int date)
        {
            var appointment = appointmentService.GetByDateOfBirth(date);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {date}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetByWeight(int weight)
        {
            var appointment = appointmentService.GetByWeight(weight);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {weight}" });

            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetByHeight(int height)
        {
            var appointment = appointmentService.GetByHeight(height);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {height}" });

            return Ok(appointment);
        }

        [HttpPost]
        public IActionResult Create(AppointmentDto appointment)
        {
            appointment = appointmentService.Create(appointment);
            return Ok(appointment);
        }

        [HttpPut]
        public IActionResult Update(AppointmentDto appointment)
        {
            appointment = appointmentService.Update(appointment);
            return Ok(appointment);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            appointmentService.Delete(id);
            return Ok();
        }

        //[Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var appointments = appointmentService.GetAll();
            return Ok(appointments);
        }
    }
}
