using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Labb2_API_Angular.Models
{
    public class DepartmentRepository : IRepository<Department>
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Get All Departments
        public ICollection GetAll()
        {
            return _appDbContext.Departments.ToList();
        }

        //Do not need
        public Task<Department> Create(Department newEntity)
        {
            throw new NotImplementedException();
        }        

        public Task<Department> Update(Department Entity)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
