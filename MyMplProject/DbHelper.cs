using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyMplProject
{
    public class DbHelper
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RoomCalculation;Integrated Security=True";
        public DataTable dbExecute(string p_sql)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(p_sql, sqlConnection);
            var reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            cmd.Dispose();
            reader.Close();
            sqlConnection.Close();
            return dataTable;
        }

        public float dbGetSingleValue(string p_sql) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(p_sql, sqlConnection);
            var returnValue = cmd.ExecuteScalar();
            cmd.Dispose();
            sqlConnection.Close();
            return float.Parse(returnValue.ToString());
        }
    }
}