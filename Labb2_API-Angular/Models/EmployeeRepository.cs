using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Labb2_API_Angular.Models
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Get All Employees
        public ICollection GetAll()
        {
            var list = (from emp in _appDbContext.Employees
                        join dep in _appDbContext.Departments
                        on emp.DepartmentId equals dep.DepartmentId
                        select new
                        {
                            employeeId = emp.EmployeeId,
                            firstName = emp.FirstName,
                            lastName = emp.LastName,
                            personalnumber = emp.PersonalNumber,
                            email = emp.Email,
                            phone = emp.PhoneNumber,
                            address = emp.Address,
                            gender = emp.Gender,
                            salary = emp.Salary,
                            departmentId = emp.DepartmentId,
                            department = dep.DepartmentName
                        }).ToList();

            return list;
        }

        //Get Single Employee By Id
        public Employee GetOne(Guid id)
        {
            return _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        //Create Employee
        public async Task<Employee> Create(Employee newEntity)
        {
            newEntity.EmployeeId = Guid.NewGuid();
            var result = await _appDbContext.Employees.AddAsync(newEntity);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        //Delete Employee
        public async Task<Employee> Delete(Guid id)
        {
            var result = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
            if (result != null)
            {
                _appDbContext.Employees.Remove(result);
                await _appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        //Update Employees
        public async Task<Employee> Update(Employee employee)
        {
            var edit = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if (edit != null)
            {
                edit.FirstName = employee.FirstName;
                edit.LastName = employee.LastName;
                edit.PersonalNumber = employee.PersonalNumber;
                edit.Email = employee.Email;
                edit.PhoneNumber = employee.PhoneNumber;
                edit.Address = employee.Address;
                edit.Gender = employee.Gender;
                edit.Salary = employee.Salary;
                edit.DepartmentId = employee.DepartmentId;

                await _appDbContext.SaveChangesAsync();
                return employee;
            }
            return null;
        }
    }
}
