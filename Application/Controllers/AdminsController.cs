using BusinessLogic.Dtos;
using BusinessLogic.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminsController : ControllerBase
    {
        private readonly IAdminService adminService;
        public AdminsController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var admin = adminService.GetById(id);
            if (admin == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {id}" });

            return Ok(admin);
        }

        [HttpGet]
        public IActionResult GetByMobilePhone(int number)
        {
            var admin = adminService.GetByMobilePhone(number);
            if (admin == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {number}" });

            return Ok(admin);
        }

        [HttpGet]
        public IActionResult GetByFirstName(string firstname)
        {
            var admin = adminService.GetByFirstName(firstname);
            if (admin == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {firstname}" });

            return Ok(admin);
        }

        [HttpGet]
        public IActionResult GetByLastName(string lastname)
        {
            var admin = adminService.GetByLastName(lastname);
            if (admin == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {lastname}" });

            return Ok(admin);
        }

        [HttpGet]
        public IActionResult GetByEmail(string email)
        {
            var admin = adminService.GetByEmail(email);
            if (admin == null)
                return BadRequest(new { message = $"Nu exista niciun admin cu id-ul {email}" });

            return Ok(admin);
        }

        [HttpPost]
        public IActionResult Create(AdminDto admin)
        {
            admin = adminService.Create(admin);
            return Ok(admin);
        }

        [HttpPut]
        public IActionResult Update(AdminDto admin)
        {
            admin = adminService.Update(admin);
            return Ok(admin);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            adminService.Delete(id);
            return Ok();
        }

        //[Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var admins = adminService.GetAll();
            return Ok(admins);
        }
    }
}
