using EmployeeSystem.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.API.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> SelectAll();
        Employee SelectByID(int id);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
