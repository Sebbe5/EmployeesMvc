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

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public Employee[] GetAll()
        {
            return context.Employees.ToArray();
        }

        public Employee GetByid(int id)
        {
            return context.Employees.SingleOrDefault(x => x.Id == id);
        }

    }
}
