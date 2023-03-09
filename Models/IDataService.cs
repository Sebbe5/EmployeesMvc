namespace EmployeesMvc.Models
{
    public interface IDataService
    {
        void AddEmployee(Employee employee);
        Employee[] GetAll();

        Employee GetByid(int id);
    }
}
