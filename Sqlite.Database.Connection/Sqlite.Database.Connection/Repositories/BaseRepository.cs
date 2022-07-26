using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Database.Connection.Repositories
{
    internal class BaseRepository : IDisposable
    {
        internal SQLiteConnection connection;

        public BaseRepository()
        {
            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
