using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_management
{
    public partial class logon : Form
    {
        public static String idnum;
        public static Boolean admin_flag = false;//设置管理员管理权限变量
        public logon()
        {
            InitializeComponent();
        }

        private void btnLogin_in_Click(object sender, EventArgs e)
        {
            String number, password;
            number = txtusername.Text;
            password = txtPassword.Text;

            if (number == "admin" && password == "admin")
            {

                GmSelection GmSlct = new GmSelection();
                GmSlct.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    if (txtusername.Text.Trim() == "")
                    {
                        MessageBox.Show("用户名不能为空!");
                        txtusername.Focus();//获取焦点
                        return;
                    }
                    else if (txtPassword.Text.Trim() == "")
                    {
                        MessageBox.Show("密码不能为空!");
                        txtPassword.Focus();//获取焦点
                        return;
                    }
                    string sql = "select teacher_password from teacher where teacher_id='{0}'";//从sql数据库中读取账号密码信息
                    sql = string.Format(sql, txtusername.Text.Trim());
                    Function fun = new Function();
                    DataSet ds = fun.Query(sql);
                    DataTable dt = ds.Tables[0];
                    DataRow dr = dt.Rows[0];
                    string pwd = dr[0].ToString();


                    if (pwd == txtPassword.Text.Trim())
                    {
                        idnum = number;
                        PersonalInfoManagment Frm_personalInfoManagment = new PersonalInfoManagment();
                        Frm_personalInfoManagment.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！请重新输入");

                    }
                }
                catch
                {
                    MessageBox.Show("用户名无效");
                }
                finally
                {

                }
            }
        }

        private void logon_Load(object sender, EventArgs e)
        {

        }

        private void bnt_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GmSelection GmSlct = new GmSelection();
            GmSlct.Show();
            this.Hide();
        }
    }
}

