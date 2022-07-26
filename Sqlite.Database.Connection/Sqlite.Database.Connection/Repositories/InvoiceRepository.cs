﻿using Dapper;
using Sqlite.Database.Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Database.Connection.Repositories
{
    internal class InvoiceRepository : BaseRepository 
    {

        public List<Invoice> GetAll(int customerId)
        {
            List<Invoice> dataItemList = new List<Invoice>();
            var parameters = new { CustomerId = customerId };
            dataItemList = connection.Query<Invoice>("select * from invoices where CustomerId = @CustomerId", parameters).ToList();
            return dataItemList;
        }
    }
}
