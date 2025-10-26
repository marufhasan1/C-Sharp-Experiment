using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployeeAsync(request.Employee);
            //throw new NotImplementedException();
        }
    }
}
