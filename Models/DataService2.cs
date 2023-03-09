namespace EmployeesMvc.Models
{
    public class DataService2 : IDataService
    {
        List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "Berit", Email = "Beritsemail@email.com"},
            new Employee { Id = 2, Name = "Britt-Marie", Email = "Brittssemail@email.com"},
            new Employee { Id = 3, Name = "Barbro", Email = "Babsansemail@email.com"}
        };

        public void AddEmployee(Employee employee)
        {
            employee.Id = _employees.Count() == 0 ? 1 : _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
        }

        public Employee[] GetAll()
        {
            return _employees.ToArray();
        }

        public Employee GetByid(int id)
        {
            return _employees.SingleOrDefault(x => x.Id == id);
        }
    }
}
