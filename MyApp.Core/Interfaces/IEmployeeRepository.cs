﻿using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id);
        Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity);
        Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity);
        Task<bool> DeleteEmployeeAsync(Guid employeeId);

    }
}
