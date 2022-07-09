namespace WebAPISample1.Models
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee item);
        void Remove(int id);
        bool Update(Employee item);
    }
}