
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace class_management
{
    class Function
    {
        // Data Source = Server name; Database = database name; SSPI is for Windows Authentication
        public string connString = "Data Source={0};Initial Catalog=classmanage_Library;Integrated Security=True";
        

        public SqlConnection conn;

        /// <summary>
        /// 执行对数据表中数据的增加、删除、修改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int NonQuery(string sql)
        {
            connString = string.Format(connString, Environment.MachineName);//改成当前机器名
            conn = new SqlConnection(connString);
            int connState = -1;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                connState = cmd.ExecuteNonQuery();//返回受影响行数
            }
            catch (System.Data.SqlClient.SqlException ex) // When false to establish
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return connState;

        }
        /// <summary>
        /// 执行对数据表中数据的查询操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet Query(string sql)
        {
            connString = string.Format(connString, Environment.MachineName);//改成当前机器名
            conn = new SqlConnection(connString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (System.Data.SqlClient.SqlException ex) // When false to establish
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return ds;
        }
        /// <summary>
        /// 随机生成class_id
        /// </summary>
        /// <returns></returns>
        public int Getclass_id()
        {
            Random rd = new Random();
            int i = rd.Next(10000, 99999);
            return i;
        }
        /// <summary>
        /// 随机生成teacher_id
        /// </summary>
        /// <returns></returns>
        public int Getteacher()
        {
            Random rd = new Random();
            int i = rd.Next(10000, 99999);
            return i;
        }
    }
}
