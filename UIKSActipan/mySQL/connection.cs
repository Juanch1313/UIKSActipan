using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UIKSActipan.mySQL
{
    public class connection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;database=ksactipan;Uid=root;pwd=Ju@nch1312;");
            connection.Open();
            return connection;
        }
    }
}
