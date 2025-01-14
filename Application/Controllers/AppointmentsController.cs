﻿using BusinessLogic.Dtos;
using BusinessLogic.Helpers;
using BusinessLogic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpGet("id/{id}")]
        public IActionResult GetById(int id)
        {
            var appointment = appointmentService.GetById(id);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {id}" });

            return Ok(appointment);
        }

        [HttpGet("hour/{hour}")]
        public IActionResult GetByHour(int hour)
        {
            var appointment = appointmentService.GetByHour(hour);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {hour}" });

            return Ok(appointment);
        }

        [HttpGet("symptom/{symptom}")]
        public IActionResult GetBySymptom(string symptom)
        {
            var appointment = appointmentService.GetBySymptom(symptom);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {symptom}" });

            return Ok(appointment);
        }

        [HttpGet("number/{number}")]
        public IActionResult GetByMobilePhone(string number)
        {
            var appointment = appointmentService.GetByMobilePhone(number);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {number}" });

            return Ok(appointment);
        }

        [HttpGet("email/{email}")]
        public IActionResult GetByEmailAdress(string email)
        {
            var appointment = appointmentService.GetByEmailAdress(email);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {email}" });

            return Ok(appointment);
        }

        [HttpGet("date/{date}")]
        public IActionResult GetByDateOfBirth(DateTime date)
        {
            var appointment = appointmentService.GetByDateOfBirth(date);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {date}" });

            return Ok(appointment);
        }

        //[Authorize(RoleCodes.Doctor)]
        [HttpGet("doctorId/{doctorId}")]
        public IActionResult GetByDoctorId(int doctorId)
        {
            var appointment = appointmentService.GetByDoctorId(doctorId);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nicio programare cu doctor cu id-ul {doctorId}" });

            return Ok(appointment);
        }

        [HttpGet("weight/{weight}")]
        public IActionResult GetByWeight(double weight)
        {
            var appointment = appointmentService.GetByWeight(weight);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {weight}" });

            return Ok(appointment);
        }

        [HttpGet("height/{height}")]
        public IActionResult GetByHeight(int height)
        {
            var appointment = appointmentService.GetByHeight(height);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare cu id-ul {height}" });

            return Ok(appointment);
        }

        [HttpGet("patientId/{patientId}")]
        public IActionResult GetAppointmentsByPatientId(int patientId)
        {
            var appointment = appointmentService.GetAppointmentsByPatientId(patientId);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare pentru pacientul {patientId}" });

            return Ok(appointment);
        }

        [HttpGet("medicId/{medicId}")]
        public IActionResult GetAppointmentsByDoctorId(int medicId)
        {
            var appointment = appointmentService.GetAppointmentsByDoctorId(medicId);
            if (appointment == null)
                return BadRequest(new { message = $"Nu exista nici o programare pentru pacientul {medicId}" });

            return Ok(appointment);
        }

        [HttpPost]
        public IActionResult Create(AppointmentDto appointment)
        {
            try
            {
               appointment = appointmentService.Create(appointment);
               return Ok(appointment);
            }
            catch(AppointmentException exception)
            {
                return BadRequest(new { message = exception.Message });
            }
            
            
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
