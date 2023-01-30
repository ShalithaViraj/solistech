using employeeAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace employeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _context;

        public EmployeeController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Employee>>> GetEmployee()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpPost]

        public async Task<ActionResult<List<Employee>>> CreateEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
            await _context.SaveChangesAsync();

            return Ok(await _context.Employees.ToListAsync());

        }

        [HttpPut]

        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee emp)
        {
            var dbemp = await _context.Employees.FindAsync(emp.Id);

            if (dbemp == null)
                return BadRequest("Employee Not Found");

            dbemp.FName = emp.FName;
            dbemp.LName = emp.LName;
            dbemp.Bday = emp.Bday;
            dbemp.Email = emp.Email;
            dbemp.Phone = emp.Phone;
            dbemp.job = emp.job;

            await _context.SaveChangesAsync();

            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int id)
        {
            var dbemp = await _context.Employees.FindAsync(id);

            if (dbemp == null)
                return BadRequest("Employee Not Found");

            _context.Employees.Remove(dbemp);

            await _context.SaveChangesAsync();

            return Ok(await _context.Employees.ToListAsync());
        }
    }
}
