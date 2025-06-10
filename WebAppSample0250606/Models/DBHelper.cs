using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAppSample0250606.Models
{
    public class DBHelper
    {
        SqlConnection conn = null;

        public DBHelper() {
            string conStr = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);

        }

        public int ExecuteNonQuery(string sql)
        {
            // 打開資料庫連接
            conn.Open();
            // 實例化 SqlCommand 物件，並將 SQL 語句和 SqlConnection 參數傳入
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            // 執行 SQL 語句，並返回增/刪/修改後的記錄行數
            int count = sqlCommand.ExecuteNonQuery();
            // 關閉資料庫連接
            conn.Close();
            // 返回增/刪/修改後的記錄行數給使用者
            return count;
        }

        public SqlDataReader GetSqlDataReader(string sql)
        {
            SqlDataReader dataReader = null;

            // 打開資料庫連接
            conn.Open();

            // 創建命令物件
            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            // 獲取唯讀資料流
            dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);

            return dataReader;
        }

        public object GetExecuteScalar(string sql)
        {
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            object result = sqlCommand.ExecuteScalar();

            conn.Close();

            return result;
        }
    }
}