using Dapper;
using Sqlite.Database.Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Database.Connection.Repositories
{
    internal class EmployeeRepository:BaseRepository
    {
        public EmployeeRepository()
        {
            
        }
        public List<Employee> GetAll()
        {
            List<Employee> dataItemList = new List<Employee>();
            dataItemList = connection.Query<Employee>("select * from employees").ToList();
            return dataItemList;
        }
        public Employee GetDataById(int id)
        {
            Employee employee = new Employee();
            var parameters = new { employeeId = id };
            employee = connection.QueryFirstOrDefault<Employee>("select * from employees where EmployeeId = @employeeId", parameters);
            return employee;
        }

        public void UpdateEmployee(string postalcode, string phone, string fax , string email, int employeeId)
        {
            var parameters = new { postalcode = postalcode, phone = phone, fax = fax ,email = email, employeeId = employeeId };
            connection.Execute("update employees set PostalCode = @postalcode, Phone = @phone, Fax = @fax, Email= @email where EmployeeId = @employeeId", parameters);

        }
    }
}
