using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Important Import
using MySql.Data.MySqlClient;
using System.Data;

namespace StudentProject
{
    class DbConnection
    {
        MySqlConnection conn = new MySqlConnection(
            "datasource=localhost;port=3306;username=root;password=Govind@123;database=projectDB");

        public MySqlConnection mySQLGetConnection()
        {
            return conn;
        }

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
