using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Q2.DAL
{

    //de su dung lai code
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PRN292_20_FallB5"].ConnectionString);
            if(sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }

    }
}
