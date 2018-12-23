using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DarAlSadeeq.DA
{
    public class Users
    {
        public partial class User
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string UserEmail { get; set; }
            public string UserType { get; set; }
            public string FullName { get; set; }
        }
        public static SqlConnection oSqlConnection;
        public static SqlCommand oSqlCommand;
        private static void OpenConnection()
        {
            if (oSqlConnection.State == ConnectionState.Closed)
                oSqlConnection.Open();
        }
        private static void CloseConnection()
        {
            if (oSqlConnection.State == ConnectionState.Open)
                oSqlConnection.Close();
        }
        public static DataTable Login(string UserName,string UserPassword)
        {
            oSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "ES_Login";
            oSqlCommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
            oSqlCommand.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = UserPassword;
            SqlDataAdapter oDataAdapter = new SqlDataAdapter(oSqlCommand);
            DataTable dt = new DataTable();
            try
            {
                oDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
    }
}