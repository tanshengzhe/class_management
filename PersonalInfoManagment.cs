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
    
    public partial class PersonalInfoManagment : Form
    {
        public static string prs_week;
        public static string prs_day;
        public static string prs_classtime;

    
        public static int weeknum;
        public static int daynum;
        /// <summary>
        /// 写入教学周下拉菜单
        /// </summary>
        public void My_Conbobox_write_week()
        {
            cmb_Pimweek.Items.Add("第一周");//选择项1
            cmb_Pimweek.Items.Add("第二周");
            cmb_Pimweek.Items.Add("第三周");
            cmb_Pimweek.Items.Add("第四周");
            cmb_Pimweek.Items.Add("第五周");
        }

        /// <summary>
        /// 在datagriyview中显示
        /// </summary>
        /// <param name="readeridd"></param>
        private void displayy(String readeridd)
        {

            if (readeridd == "admin")
            {
                string sql = "select * from  appointment where enable='禁用' or enable='占用' ";
                sql = string.Format(sql, readeridd);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Pim.DataSource = dt;
                Dgv_Pim.Refresh();
            }
            else
            {
                string sql = "select * from  appointment where teacher_id ='{0}' and  enable='占用'";
                sql = string.Format(sql, readeridd);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Pim.DataSource = dt;
                Dgv_Pim.Refresh();
            }
        }
        /// <summary>
        /// 筛选后显示
        /// </summary>
        /// <param name="readeridd"></param>
        private void displaysort(String readeridd,string name)
        {

            if (readeridd == "admin")
            {
                string sql = "select * from  appointment where enable='禁用' or enable='占用' ";
                sql = string.Format(sql, readeridd);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Pim.DataSource = dt;
                Dgv_Pim.Refresh();
            }
            else
            {
                string sql = "select * from  appointment where teacher_id ='{0}'and class_name='{1}' and  enable='占用'";
                sql = string.Format(sql, readeridd,name);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Pim.DataSource = dt;
                Dgv_Pim.Refresh();
            }
        }

        /// <summary>
        /// 在datagriyview中显示
        /// </summary>
        /// <param name="readeridd"></param>
        ///
        /// 
        private void displayweek(String readeridd,string week)
        {

            if (readeridd == "admin")
            {
                string sql = "select * from  appointment where enable='禁用' or enable='占用' ";
                sql = string.Format(sql, readeridd);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Pim.DataSource = dt;
                Dgv_Pim.Refresh();
            }
            else
            {
                string sql = "select * from  appointment where teacher_id ='{0}' and week='{1}' and  enable='占用'";
                sql = string.Format(sql, readeridd,week);
                //创建数据库操作类的对象
                Function fun = new Function();
                //执行对数据库表的查询操作
                DataSet ds = fun.Query(sql);
                DataTable dt = ds.Tables[0];

                Dgv_Pim.DataSource = dt;
                Dgv_Pim.Refresh();
            }
        }

        public PersonalInfoManagment()
        {
            InitializeComponent();
        }

        private void PersonalInfoManagment_Load(object sender, EventArgs e)
        {
            displayy(logon.idnum);
            My_Conbobox_write_week();//写入下拉菜单week
             weeknum = 1;
             daynum = 1;
        }

        /// <summary>
        /// 单击删除bnt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PimDelet_Click(object sender, EventArgs e)
        {
            int a = Dgv_Pim.CurrentRow.Index;
            string week = Dgv_Pim.Rows[a].Cells[0].Value.ToString();
            string day = Dgv_Pim.Rows[a].Cells[1].Value.ToString();
            string classtime = Dgv_Pim.Rows[a].Cells[2].Value.ToString();
            try
            {
                ////Add student information
                string sql = "update appointment set class_id='无',class_name='无',teacher_id='无',teacher_name='无',enable='可用' where week='{0}' and day='{1}' and classtime='{2}'";
                sql = string.Format(sql,week,day,classtime);

                // Create Database Object Class
                Function fun = new Function();
                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                displayy(logon.idnum);
            }
            catch
            {
                MessageBox.Show("用户名或书籍不存在，还书失败！");
            }
            finally
            {

            }
            

            
        }

        private void cmb_Pimweek_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Pimweek.SelectedItem.ToString()) //获取选择的内容
            {



                case "第一周": weeknum = 1; ; break;
                case "第二周": weeknum = 2; ; break;
                case "第三周": weeknum = 3; ; break;
                case "第四周": weeknum = 4; ; break;
                case "第五周": weeknum = 5; ; break;

            }
            displayweek(logon.idnum, weeknum.ToString());

        }

        private void btn_PimAdd_Click(object sender, EventArgs e)
        {
            PimAdd Frm_PimAdd = new PimAdd();
            Frm_PimAdd.Show();
        }

        private void btn_PimSort_Click(object sender, EventArgs e)
        {
            displayy(logon.idnum);
        }

        private void btn_PimChange_Click(object sender, EventArgs e)
        {
            int a = Dgv_Pim.CurrentRow.Index;
            prs_week = Dgv_Pim.Rows[a].Cells[0].Value.ToString();
            prs_day = Dgv_Pim.Rows[a].Cells[1].Value.ToString();
            prs_classtime = Dgv_Pim.Rows[a].Cells[2].Value.ToString();

            GmChangeAppcs Frm_pimChange = new GmChangeAppcs();
            Frm_pimChange.Show();
        }

        private void btn_PimBack_Click(object sender, EventArgs e)
        {
            logon Frm_logon = new logon();
            Frm_logon.Show();
            this.Hide();
        }

        private void btn_prsinfo_Click(object sender, EventArgs e)
        {
            PimChangTeacher Frm_pimChangTeacher = new PimChangTeacher();
            Frm_pimChangTeacher.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search f2 = new search();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                displaysort(logon.idnum, f2.classname);
                f2.Close();
                
            }
            

        }
    }
}
