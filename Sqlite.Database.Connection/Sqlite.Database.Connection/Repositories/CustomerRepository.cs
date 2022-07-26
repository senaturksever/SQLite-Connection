using Dapper;
using Sqlite.Database.Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Database.Connection.Repositories
{
    internal class CustomerRepository: BaseRepository
    {
        public List<Customer> GetAllByEmployeeId(int employeeId)
        {
            List<Customer> dataItemList = new List<Customer>();
            var parameters = new { EmployeeId = employeeId };
            dataItemList = connection.Query<Customer>("select * from customers where SupportRepId = @EmployeeId", parameters).ToList();
            return dataItemList;
        }
    }
}
