using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UIKSActipan.mySQL
{
    class connectionuser
    {
        public static MySqlConnection getConnection(string user, string password)
        {
            MySqlConnection connection = new MySqlConnection("server=remotemysql.com;database=J654mkpu07;Uid="+ user +";pwd=" + password + ";");
            connection.Open();
            return connection;
        }
    }
}
