﻿using BusinessLogic.Dtos;
using BusinessLogic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabinetsController : ControllerBase
    {
        private readonly ICabinetService cabinetService;
        public CabinetsController(ICabinetService cabinetService)
        {
            this.cabinetService = cabinetService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var cabinet = cabinetService.GetById(id);
            if (cabinet == null)
                return BadRequest(new { message = $"Nu exista niciun cabinet cu id-ul {id}" });

            return Ok(cabinet);
        }

        [HttpGet]
        public IActionResult GetByName(string name)
        {
            var cabinet = cabinetService.GetByName(name);
            if (cabinet == null)
                return BadRequest(new { message = $"Nu exista niciun cabinet cu id-ul {name}" });

            return Ok(cabinet);
        }

        [HttpPost]
        public IActionResult Create(CabinetDto cabinet)
        {
            cabinet = cabinetService.Create(cabinet);
            return Ok(cabinet);
        }

        [HttpPut]
        public IActionResult Update(CabinetDto cabinet)
        {
            cabinet = cabinetService.Update(cabinet);
            return Ok(cabinet);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            cabinetService.Delete(id);
            return Ok();
        }

        //[Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var cabinets = cabinetService.GetAll();
            return Ok(cabinets);
        }
    }
}