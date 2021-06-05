using EmployeeSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.API.Repositories
{
    public class EmployeeSqlRepository : IEmployeeRepository
    {
        private readonly AppDbContext _db = null;

        public EmployeeSqlRepository(AppDbContext db)
        {
            this._db = db;
        }

        public void Delete(int id)
        {
            _db.Database.ExecuteSqlRaw("DELETE FROM Employees WHERE EmployeeID = {0}", id);
        }

        public void Insert(Employee employee)
        {
            _db.Database.ExecuteSqlRaw("INSERT INTO Employees(FirstName, LastName, Title, BirthDate, HireDate, Country, Notes) VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6})", employee.FirstName, employee.LastName, employee.Title, employee.BirthDate, employee.HireDate, employee.Country, employee.Notes);
        }

        public List<Employee> SelectAll()
        {
            List<Employee> data = _db.Employees.FromSqlRaw("SELECT EmployeeID, FirstName, LastName, Title, BirthDate, HireDate, Country, Notes FROM Employees ORDER BY EmployeeID ASC").ToList();

            return data;
        }

        public Employee SelectByID(int id)
        {
            Employee emp = _db.Employees.FromSqlRaw("SELECT EmployeeID, FirstName, LastName, Title, BirthDate, HireDate, Country, Notes FROM Employees WHERE EmployeeID = {0}", id).SingleOrDefault();
            return emp;
        }

        public void Update(Employee employee)
        {
            _db.Database.ExecuteSqlRaw("UPDATE Employees SET FirstName = {0}, LastName = {1}, Title = {2}, BirthDate = {3}, HireDate = {4}, Country = {5}, Notes = {6} WHERE EmployeeID = {7}", employee.FirstName, employee.LastName, employee.Title, employee.BirthDate, employee.HireDate, employee.Country, employee.Notes, employee.EmployeeID);
        }
    }
}
