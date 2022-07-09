using system.collewction.Generic
using firstWeb.Api,Models:

namespace firstWeb.Api. Services.Interfaces
{ 
       public interface IEmployeeService { }
{
            // create
            void CreateEmployee(Employee employee);
        static readonly IEmployeeRepository repository = new EmployeeRepository();
           // Read 
           IEnumerable<Employee> GetEmployees()

           // Update
           void UpdateEmployee(IEmployeeService employee);

    //Delete
    bool DeleteEmployee(IEmployeeService employee);
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return item;
        }
        public IEnumerable Employee GetEmployeeByName(string name)
        {
            return repository.GetAll().Where(
                p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
        }
        public HttpResponseMessage PostEmployee(Employee item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse Employee (HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }
        public void PutEmployee(int id, Employee employee)
        {  
            employee.Id = id;
            if (!repository.Update(employee))
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
        }
        public HttpResponseMessage DeleteEmployee(int id)
        {
            repository.Remove(id);
            return new HttpResponseMessage(HttpStatusCode.
