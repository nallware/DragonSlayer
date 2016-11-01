using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DragonSlayer
{
    public static class DALHelper
    {
        public static DataTable Query2DataTable(string dataQuery, string sqlConString)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter sd = new SqlDataAdapter(dataQuery, sqlConString))
            {                
                sd.Fill(dt);
            }
            return dt;
        }


        public static List<string> Query2StringList(string listQuery, string sqlConString)
        {
            List<string> retlist = new List<string>();

            using (SqlConnection sqlCon = new SqlConnection(sqlConString))
            {
                using (SqlCommand cmd = new SqlCommand(listQuery, sqlCon))
                {
                    sqlCon.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retlist.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return retlist;
        }
        

    }

}
