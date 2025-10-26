using CleanArchitecture.Application.Commands;
using CleanArchitecture.Application.Queries;
using CleanArchitecture.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllEmployeeAsync()
        {
            var result = await sender.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeByIdAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeId));
            return Ok(result);
        }

        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeByIdAsync([FromRoute] Guid employeeId, [FromBody] EmployeeEntity employeeEntity)
        {
            var result = await sender.Send(new UpdateEmployeeCommand(employeeId,employeeEntity));
            return Ok(result);
        }

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            return Ok(result);
        }
    }
}
