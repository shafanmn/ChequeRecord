using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ChequeRecord.Classes
{
    class Connections
    {
        private MySqlConnection conn;

        public MySqlConnection getConnection()
        {
            conn = new MySqlConnection("Server=localhost;Database=cheques;Uid=root;Password=;");
            return conn;
        }
    }
}
