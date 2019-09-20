using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THNN
{
    public static class Lopketnoi
    {
        public static string chuoikn = @"Data Source=GMC-DUNGVTT\THUYDUNG;Initial Catalog=THNN;Persist Security Info=True;User ID=thuydung;Password=thuydung";
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static string manv;
        public static string hotennv;

        public static void moketnoi()
        {
            con = new SqlConnection(chuoikn);
            con.Open();
        }

        public static void dongketnoi()
        {
            con.Close();
        }

        public static void giaiphongketnoi()
        {
            con.Dispose();
        }

        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public static string executeScalar(string sql)
        {
            string chuoi;
            cmd = new SqlCommand(sql, con);
            chuoi = (string)cmd.ExecuteScalar();
            return chuoi;
        }
    }
}
