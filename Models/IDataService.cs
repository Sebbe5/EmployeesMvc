using EmployeesMvc.Views.Home;

namespace EmployeesMvc.Models
{
    public interface IDataService
    {
        Task AddEmployee(CreateEmployeeVM employee);
        Task<IndexVM[]> GetAll();

        Task<Employee> GetByid(int id);
    }
}
