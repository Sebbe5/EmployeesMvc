namespace EmployeesMvc.Models
{
    public class DataService2 : IDataService
    {
        private readonly ApplicationContext context;

        public DataService2(ApplicationContext context)
        {
            this.context = context;
        }
        //List<Employee> _employees = new()
        //{
        //    new Employee { Id = 1, Name = "Berit", Email = "Beritsemail@email.com"},
        //    new Employee { Id = 2, Name = "Britt-Marie", Email = "Brittssemail@email.com"},
        //    new Employee { Id = 3, Name = "Barbro", Email = "Babsansemail@email.com"}
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
