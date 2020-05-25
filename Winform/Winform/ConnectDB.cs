using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Winform
{
    class ConnectDB
    {
        public ConnectDB()
        {

        }
        public SqlConnection GetConnection()
        {
            String a = "Data Source=LAB6_PC11;Initial Catalog = QLBH;uid =sa;pwd = 123$";
            SqlConnection con = new SqlConnection(a);
            con.Open();
            return con;
        }

    }
}