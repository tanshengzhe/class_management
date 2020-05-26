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
    public partial class PimAdd : Form
    {
        public static int weeknum=2;//下拉flag变量
        public static int daynum=1;
        public static string teachername;//当前用户名
        /// <summary>
        /// 获得当前用户名
        /// </summary>
        public  void Getteachername()
        {
            string sql = "select teacher_name from teacher where teacher_id='{0}'";//从sql数据库中读取账号密码信息
            sql = string.Format(sql, logon.idnum);
            Function fun = new Function();
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            teachername= dr[0].ToString();
        }
        /// <summary>
        /// 生成课程id
        /// </summary>
        /// <returns></returns>


        /// <summary>
        /// 写入教学周下拉菜单
        /// </summary>
        public void My_Conbobox_write_week()
        {
            if(GmSelection.order_flag==1)
            {
                cmb_PimAddWeek.Items.Add("第一周");
            }
            //选择项1
            cmb_PimAddWeek.Items.Add("第二周");
            cmb_PimAddWeek.Items.Add("第三周");
            cmb_PimAddWeek.Items.Add("第四周");
            cmb_PimAddWeek.Items.Add("第五周");
            
            
        }
        /// <summary>
        /// 写入星期下拉菜单
        /// </summary>
        public void My_Conbobox_write_day()
        {
            cmb_PimAddday.Items.Add("星期一");//选择项1
            cmb_PimAddday.Items.Add("星期二");
            cmb_PimAddday.Items.Add("星期三");
            cmb_PimAddday.Items.Add("星期四");
            cmb_PimAddday.Items.Add("星期五");
            
        }
        /// <summary>
        /// 显示datagridview
        /// </summary>
        private void displayadd()
        {
            string sql;
            if (GmSelection.order_flag == 1)
            {
                sql = "select week,day , classtime,class_name from appointment where  week='{0}'and day='{1}'";//管理员模式全部显示
            }
            else
            {
                sql = "select week,day , classtime from appointment where enable='0'and week='{0}'and day='{1}'";//非管理员模式只显示可用项
            }
            sql = string.Format(sql, weeknum.ToString(),daynum.ToString());
            //创建数据库操作类的对象
            Function fun = new Function();
            //执行对数据库表的查询操作
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];

            Dgv_PA.DataSource = dt;
            Dgv_PA.Refresh();
        }
        public PimAdd()
        {
            InitializeComponent();
        }

        private void lbl_PaTitle2_Click(object sender, EventArgs e)
        {

        }

        private void PimAdd_Load(object sender, EventArgs e)
        {
            displayadd();//更新显示
            My_Conbobox_write_week();//下拉菜单写入
            My_Conbobox_write_day();
        }

        private void cmb_PimAddWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_PimAddWeek.SelectedItem.ToString()) //获取选择的内容
            {



                case "第一周": weeknum = 1; ; break;
                case "第二周": weeknum = 2; ; break;
                case "第三周": weeknum = 3; ; break;
                case "第四周": weeknum = 4; ; break;
                case "第五周": weeknum = 5; ; break;

            }
            displayadd();

        }

        private void cmb_PimAddday_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_PimAddday.SelectedItem.ToString()) //获取选择的内容
            {

                case "星期一": daynum = 1; ; break;

                case "星期二": daynum = 2; ; break;
                case "星期三": daynum = 3; ; break;
                case "星期四": daynum = 4; ; break;
                case "星期五": daynum = 5; ; break;

            }
            displayadd();
        }
        /// <summary>
        /// 单击添加按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnt_PaAdd_Click(object sender, EventArgs e)
        {
            int a = Dgv_PA.CurrentRow.Index;
            string week = Dgv_PA.Rows[a].Cells[0].Value.ToString();
            string day = Dgv_PA.Rows[a].Cells[1].Value.ToString();
            string classtime = Dgv_PA.Rows[a].Cells[2].Value.ToString();
            Getteachername();//获取教师名
            if (txt_classname.Text.Trim() == "" || txt_stdquatity.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空,添加失败！");
            }
            try
            {
                Function fun = new Function();
                string sql = "update appointment set class_id='{0}',class_name='{1}',teacher_id='{2}',teacher_name='{3}',enable='1' where week='{4} 'and day='{5}'and classtime='{6}'";//向appointment中添加
                sql = string.Format(sql, fun.Getclass_id().ToString(), txt_classname.Text, logon.idnum, teachername, week, day, classtime);
                
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

        }

        private void bnt_PaBack_Click(object sender, EventArgs e)
        {
            PersonalInfoManagment Frm_personalInfoManagment = new PersonalInfoManagment();
            Frm_personalInfoManagment.Show();
            this.Hide();
        }
    }
}
