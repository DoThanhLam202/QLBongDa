using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FormQLBongDa
{
    class TruyxuatCSDL
    {
        private static string url = @"Data Source=Do-Lam\SQLEXPRESS;Initial Catalog=dbQLCT;Integrated Security=True";
        private static SqlConnection Taoketnoi()
        {
            return new SqlConnection(url);
        }
        public static DataTable getBang(string sql)
        {
            SqlConnection conn = Taoketnoi();
            conn.Open();
            DataTable tb = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, conn);
            sqlData.Fill(tb);
            conn.Close();
            sqlData.Dispose();
            return tb;
        }

        public static void Chucnang(string sql)
        {
            SqlConnection conn = Taoketnoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
    }
}
