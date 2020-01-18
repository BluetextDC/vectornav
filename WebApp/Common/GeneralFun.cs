using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace SitefinityWebApp.Common
{
    public static class GeneralFun
    {
        private static string cnnStr = System.Configuration.ConfigurationManager.ConnectionStrings["Sitefinity"].ToString();
        public static void ExecQuery(string query)
        {
            SqlConnection cnn = new SqlConnection(cnnStr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable GetData(string query)
        {
            DataTable dt= new DataTable();
            SqlConnection cnn = new SqlConnection(cnnStr);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return dt;
        }
         

    }
}