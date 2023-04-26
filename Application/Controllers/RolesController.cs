using BusinessLogic.Dtos;
using BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService roleService;

        public RolesController(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var role = roleService.GetById(id);
            if (role == null)
                return BadRequest(new { message = $"Nu exista niciun rol cu id-ul {id}" });

            return Ok(role);
        }

        [HttpGet]
        public IActionResult GetByName(string name)
        {
            var role = roleService.GetByName(name);
            if (role == null)
                return BadRequest(new { message = $"Nu exista niciun rol cu id-ul {name}" });

            return Ok(role);
        }

        [HttpPost]
        public IActionResult Create(RoleDto role)
        {
            role = roleService.Create(role);
            return Ok(role);
        }

        [HttpPut]
        public IActionResult Update(RoleDto role)
        {
            role = roleService.Update(role);
            return Ok(role);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            roleService.Delete(id);
            return Ok();
        }

        //[Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var roles = roleService.GetAll();
            return Ok(roles);
        }

    }
}
