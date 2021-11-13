using Alexis.CORE.Connection.Connections;
using Alexis.CORE.Connection.Interfaces;
using Alexis.CORE.Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexis.CORE.Connection
{
    public class Factorizer<T>
    {
        public static IConnectionDB<T> Create(string ConnectionString, DbEnum DB)
        {
            return DB switch
            {
                DbEnum.Sql => SqlServer<T>.Conectar(ConnectionString),
                DbEnum.MySql => MySql<T>.Conectar(ConnectionString),
                _ => SqlServer<T>.Conectar(ConnectionString),
            };
        }
    }
}