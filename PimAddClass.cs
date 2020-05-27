using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_management
{
    public partial class PimAddClass : Form
    {
        public static string teachername;//当前用户名
        /// <summary>
        /// 获得当前用户名
        /// </summary>
        public void Getteachername()
        {
            string sql = "select teacher_name from teacher where teacher_id='{0}'";//从sql数据库中读取账号密码信息
            sql = string.Format(sql, logon.idnum);
            Function fun = new Function();
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            teachername = dr[0].ToString();
        }
        public PimAddClass()
        {
            InitializeComponent();
        }

        private void PimAddClass_Load(object sender, EventArgs e)
        {
            Getteachername();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_teachername.Text.Trim() == "" || txt_stdQuatuty.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空,添加失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "insert into class values('{0}','{1}','{2}','{3}','{4}');";//向appointment中添加
                sql = string.Format(sql, fun.Getclass_id(),txt_teachername.Text, logon.idnum,teachername,txt_stdQuatuty.Text) ;

                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }

            }
            catch { }
            finally { }
            this.Hide();
        }
    }
}
