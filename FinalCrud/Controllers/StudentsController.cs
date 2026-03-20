using Microsoft.AspNetCore.Mvc;
using FinalCrud.Data;
using FinalCrud.Models;


namespace FinalCrud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Students.ToList());
        }

        [HttpPost]
        public IActionResult Post(Student customer)
        {
            _context.Students.Add(customer);
            _context.SaveChanges();
            return Ok(customer);
        }
    }
}