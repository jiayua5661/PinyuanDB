using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinyuanDB
{
    internal class DB_Helper
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;

        public DB_Helper(string conStr)
        {
            conn = new SqlConnection(conStr);
            adapter = new SqlDataAdapter();
        }

        public DataTable Select(string sql)
        {
            dt = new DataTable();
            adapter.SelectCommand = new SqlCommand(sql, conn);
            dt?.Clear();
            adapter.FillSchema(dt, SchemaType.Mapped);
            adapter.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Select 參數取代
        /// </summary>
        /// <param name="sql">selectcommand</param>
        /// <param name="dc">Dictionary<@變數名稱(要跟command裡面一樣，順序沒關係), 變數></param>
        /// <returns></returns>
        public DataTable Select(string sql, Dictionary<string, string> dc)
        {
            dt = new DataTable();
            adapter.SelectCommand = new SqlCommand(sql, conn);
            foreach (KeyValuePair<string, string> item in dc)
            {
                adapter.SelectCommand.Parameters.AddWithValue(item.Key, item.Value);
            }
            dt?.Clear();
            adapter.FillSchema(dt, SchemaType.Mapped);
            adapter.Fill(dt);
            return dt;
        }
        
        public object SelectExecuteScalar(string sql, Dictionary<string, string> dc)
        {
            adapter.SelectCommand = new SqlCommand(sql, conn);
            foreach (KeyValuePair<string, string> item in dc)
            {
                adapter.SelectCommand.Parameters.AddWithValue(item.Key, item.Value);
            }
            conn.Open();
            object result = adapter.SelectCommand.ExecuteScalar();
            conn.Close();
            return result;
        }

        public int Insert(string sql, params string[] myParameterList)
        {
            int result = 0;
            List<string> paramiterList = new List<string>();
            // 找出 SQL中@變數
            foreach (string i in sql.Split(' '))
            {
                if (i.Contains("@"))
                {
                    string a = i.Replace("(", "");
                    a = a.Replace(",", "");
                    a = a.Replace(")", "");
                    paramiterList.Add(a);
                }
            }

            // paramiterList.Count == myParameterList.Count() // 要放的變數 要跟 sqlamd的@一樣多

            // 塞變數到sql 中 用參數取代
            int n = 0;
            adapter.InsertCommand = new SqlCommand(sql, conn);
            foreach (string para in paramiterList)
            {
                adapter.InsertCommand.Parameters.AddWithValue(para, myParameterList[n]);
                n++;
            }
            // insert
            try
            {
                conn.Open();
                result += adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"插入資料時發生錯誤：{ex.Message}");
            }
            return result;
        }

        // insert 要拿 表格的identity來用
        public int InsertGetInsertedID(string sql, params string[] myParameterList)
        {
            object insertedId = 0;
            List<string> paramiterList = new List<string>();
            // 找出 SQL中@變數
            foreach (string i in sql.Split(' '))
            {
                if (i.Contains("@"))
                {
                    string a = i.Replace("(", "");
                    a = a.Replace(",", "");
                    a = a.Replace(")", "");
                    a = a.Contains(";") ? a.Remove(a.IndexOf(";")) : a;
                    paramiterList.Add(a);
                }
            }
            // 塞變數到sql 中 用參數取代
            int n = 0;
            adapter.InsertCommand = new SqlCommand(sql, conn);
            foreach (string para in paramiterList)
            {
                adapter.InsertCommand.Parameters.AddWithValue(para, myParameterList[n]);
                n++;
            }
            // insert
            try
            {
                conn.Open();
                insertedId = adapter.InsertCommand.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"插入資料時發生錯誤：{ex.Message}");
            }
            return Convert.ToInt32(insertedId);
        }

        public int Update(string sql, Dictionary<string, string> dc)
        {
            int result;
            adapter.UpdateCommand = new SqlCommand(sql, conn);
            foreach (KeyValuePair<string, string> item in dc)
            {
                adapter.UpdateCommand.Parameters.AddWithValue(item.Key, item.Value);
            }

            conn.Open();
            result = adapter.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            return result;
        }
    }
}
