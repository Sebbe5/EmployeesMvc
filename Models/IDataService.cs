namespace EmployeesMvc.Models
{
    public interface IDataService
    {
        Task AddEmployee(Employee employee);
        Task<Employee[]> GetAll();

        Task<Employee> GetByid(int id);
    }
}
