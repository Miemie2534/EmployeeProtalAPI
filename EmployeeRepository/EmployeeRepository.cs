using EmployeePortal.Models;
using EmployeeProtal.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.EmployeeRepository
{
    public class EmployeeRepository
    {
        private readonly AppDbContext db;
        public EmployeeRepository(AppDbContext dbContext)
        {
            this.db = dbContext;
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee emp)
        {
            await db.Employees.AddAsync(emp);
            await db.SaveChangesAsync();
        }
    }
}
