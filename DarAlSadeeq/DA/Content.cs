using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DarAlSadeeq.DA
{
    public class Content
    {
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
        public static bool InsertContent(string ContentTitleAR, string ContentTitleEN, string ContentType,
                                         string ContentPath, int LevelID, int CategoryID,
                                         int PartID, int SectionID, string Description, string CoverPic)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_InsertContent";
            oSqlCommand.Parameters.Add("@ContentID", SqlDbType.Int).Direction = ParameterDirection.Output;
            oSqlCommand.Parameters.Add("@ContentTitleAR", SqlDbType.NVarChar).Value = ContentTitleAR;
            oSqlCommand.Parameters.Add("@ContentTitleEN", SqlDbType.NVarChar).Value = ContentTitleEN;
            oSqlCommand.Parameters.Add("@ContentType", SqlDbType.NVarChar).Value = ContentType;
            oSqlCommand.Parameters.Add("@ContentPath", SqlDbType.NVarChar).Value = ContentPath;
            oSqlCommand.Parameters.Add("@LevelID", SqlDbType.Int).Value = LevelID;
            oSqlCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            oSqlCommand.Parameters.Add("@PartID", SqlDbType.Int).Value = PartID;
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Value = SectionID;
            oSqlCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = Description;
            oSqlCommand.Parameters.Add("@CoverPic", SqlDbType.NVarChar).Value = CoverPic;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;

        }
       
        public static DataTable GetLevels(int SectionID = -1)
        {
            oSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_GetLevels";
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Value = SectionID;
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
        public static bool InsertLevel(string LevelTitleAR, string LevelTitleEN)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_InsertLevel";
            oSqlCommand.Parameters.Add("@LevelID", SqlDbType.Int).Direction = ParameterDirection.Output;
            oSqlCommand.Parameters.Add("@LevelTitleAR", SqlDbType.NVarChar).Value = LevelTitleAR;
            oSqlCommand.Parameters.Add("@LevelTitleEN", SqlDbType.NVarChar).Value = LevelTitleEN;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;

        }
        public static bool UpdateLevel(int LevelID, string LevelTitleAR, string LevelTitleEN)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_UpdateLevels";
            oSqlCommand.Parameters.Add("@LevelID", SqlDbType.Int).Value = LevelID;
            oSqlCommand.Parameters.Add("@LevelTitleAR", SqlDbType.NVarChar).Value = LevelTitleAR;
            oSqlCommand.Parameters.Add("@LevelTitleEN", SqlDbType.NVarChar).Value = LevelTitleEN;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;
        }
        public static bool DeleteLevel(int LevelID)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_DeleteLevels";
            oSqlCommand.Parameters.Add("@LevelID", SqlDbType.Int).Value = LevelID;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;
        }
        public static DataTable GetSections(int SectionID = -1)
        {
            oSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_GetSections";
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Value = SectionID;
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
        public static bool InsertSection(string SectionTitleAR, string SectionTitleEN)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_InsertSection";
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Direction = ParameterDirection.Output;
            oSqlCommand.Parameters.Add("@SectionTitleAR", SqlDbType.NVarChar).Value = SectionTitleAR;
            oSqlCommand.Parameters.Add("@SectionTitleEN", SqlDbType.NVarChar).Value = SectionTitleEN;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;

        }
        public static bool UpdateSection(int SectionID, string SectionTitleAR, string SectionTitleEN)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_UpdateSections";
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Value = SectionID;
            oSqlCommand.Parameters.Add("@SectionTitleAR", SqlDbType.NVarChar).Value = SectionTitleAR;
            oSqlCommand.Parameters.Add("@SectionTitleEN", SqlDbType.NVarChar).Value = SectionTitleEN;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;
        }
        public static bool DeleteSection(int SectionID)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_DeleteSections";
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Value = SectionID;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;
        }
        public static bool InsertCategory(string CategoryTitleAR, string CategoryTitleEN)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_InsertCategory";
            oSqlCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Direction = ParameterDirection.Output;
            oSqlCommand.Parameters.Add("@CategoryTitleAR", SqlDbType.NVarChar).Value = CategoryTitleAR;
            oSqlCommand.Parameters.Add("@CategoryTitleEN", SqlDbType.NVarChar).Value = CategoryTitleEN;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;

        }
        public static bool UpdateCategory(int CategoryID, string CategoryTitleAR, string CategoryTitleEN)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_UpdateCategories";
            oSqlCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            oSqlCommand.Parameters.Add("@CategoryTitleAR", SqlDbType.NVarChar).Value = CategoryTitleAR;
            oSqlCommand.Parameters.Add("@CategoryTitleEN", SqlDbType.NVarChar).Value = CategoryTitleEN;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;
        }
        public static bool DeleteCategory(int CategoryID)
        {
            bool check;
            oSqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_DeleteCategories";
            oSqlCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            try
            {
                if (oSqlConnection.State == ConnectionState.Closed)
                {
                    oSqlConnection.Open();
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
                else
                {
                    oSqlCommand.ExecuteNonQuery();
                    check = true;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            finally
            {
                if (oSqlConnection.State == ConnectionState.Open)
                    oSqlConnection.Close();
            }
            return check;
        }
        public static DataTable GetContents(int SectionID = -1, int LevelID = -1, int CategoryID = -1, int PartID = -1)
        {
            oSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dar_AlsadiqConnectionString"].ConnectionString);
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.CommandText = "sp_GetContents";
            oSqlCommand.Parameters.Add("@SectionID", SqlDbType.Int).Value = SectionID;
            oSqlCommand.Parameters.Add("@LevelID", SqlDbType.Int).Value = LevelID;
            oSqlCommand.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            oSqlCommand.Parameters.Add("@PartID", SqlDbType.Int).Value = PartID;
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