using Microsoft.EntityFrameworkCore;

namespace EmployeesMvc.Models
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }
        //List<Employee> _employees = new()
        //{
        //    new Employee { Id = 1, Name = "Bengt", Email = "Bengtsemail@email.com"},
        //    new Employee { Id = 2, Name = "Bosse", Email = "Bossesemail@email.com"},
        //    new Employee { Id = 3, Name = "Berra", Email = "Berrasemail@email.com"}
        //};

        public async Task AddEmployee(Employee employee)
        {
            await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
        }

        public async Task<Employee[]> GetAll()
        {
            return await context.Employees.Include(e => e.Company).ToArrayAsync();
        }

        public async Task<Employee> GetByid(int id)
        {
            return await context.Employees.SingleOrDefaultAsync(x => x.Id == id);
        }

    }
}
