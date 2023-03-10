using EmployeesMvc.Views.Home;
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

        public async Task AddEmployee(CreateEmployeeVM employee)
        {
            context.Employees
                .Add(new Employee
                {
                    Name = employee.Name,
                    Email = employee.Email,
                });
            await context.SaveChangesAsync();
        }

        public async Task<IndexVM[]> GetAll()
        {
            return await context.Employees.Select(e => new IndexVM
            {
                Name = e.Name,
                Email = e.Email,
            }).ToArrayAsync();
        }

        public async Task<Employee> GetByid(int id)
        {
            return await context.Employees.SingleOrDefaultAsync(x => x.Id == id);
        }

    }
}
