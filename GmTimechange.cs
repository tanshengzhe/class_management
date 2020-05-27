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
    public partial class GmTimechange : Form
    {
        public static int weeknum = 1;//下拉flag变量
        public static int daynum = 1;
        public static string teachername;//当前用户名
        /// <summary>
        /// 写入教学周下拉菜单
        /// </summary>
        public void My_Conbobox_write_week()
        {
           cmb_PimAddWeek.Items.Add("第一周");

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
        /// 显示所有日期
        /// 
        /// </summary>
        private void displayadd()
        {
            string sql;
            sql = "select enable ,week,day , classtime,class_name from appointment where  week='{0}'and day='{1}' and enable='可用'";//管理员模式全部显示
            sql = string.Format(sql, weeknum.ToString(), daynum.ToString());
            //创建数据库操作类的对象
            Function fun = new Function();
            //执行对数据库表的查询操作
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];

            Dgv_PA.DataSource = dt;
            Dgv_PA.Refresh();
        }
        /// <summary>
        /// 显示所有日期
        /// 
        /// </summary>
        private void displayunable()
        {
            string sql;
            sql = "select enable ,week,day , classtime,class_name from appointment where  week='{0}'and day='{1}' and enable='禁用'";//管理员模式全部显示
            sql = string.Format(sql, weeknum.ToString(), daynum.ToString());
            //创建数据库操作类的对象
            Function fun = new Function();
            //执行对数据库表的查询操作
            DataSet ds = fun.Query(sql);
            DataTable dt = ds.Tables[0];

            Dgv_Unable.DataSource = dt;
            Dgv_Unable.Refresh();
        }
        public GmTimechange()
        {
            InitializeComponent();
        }

        private void GmTimechange_Load(object sender, EventArgs e)
        {
            displayadd();
            displayunable();
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

        private void bnt_no_Click(object sender, EventArgs e)
        {
            int a = Dgv_PA.CurrentRow.Index;
            string week = Dgv_PA.Rows[a].Cells[1].Value.ToString();
            string day = Dgv_PA.Rows[a].Cells[2].Value.ToString();
            string classtime = Dgv_PA.Rows[a].Cells[3].Value.ToString();

            try
            {
                Function fun = new Function();
                string sql = "update appointment set enable='禁用' where week='{0} 'and day='{1}'and classtime='{2}'";//向appointment中添加
                sql = string.Format(sql, week, day, classtime);

                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("禁用成功！");
                }
                else
                {
                    MessageBox.Show("禁用失败！");
                }

            }
            catch { }
            finally { }
            displayadd();
            displayunable();
        }

        private void bnt_enable_Click(object sender, EventArgs e)
        {
            int a = Dgv_Unable.CurrentRow.Index;
            string week = Dgv_Unable.Rows[a].Cells[1].Value.ToString();
            string day = Dgv_Unable.Rows[a].Cells[2].Value.ToString();
            string classtime = Dgv_Unable.Rows[a].Cells[3].Value.ToString();

            try
            {
                Function fun = new Function();
                string sql = "update appointment set enable='可用' where week='{0} 'and day='{1}'and classtime='{2}'";//向appointment中添加
                sql = string.Format(sql, week, day, classtime);

                //
                //
                if (fun.NonQuery(sql) == 1)
                {
                    MessageBox.Show("解禁成功！");
                }
                else
                {
                    MessageBox.Show("解禁失败！");
                }

            }
            catch { }
            finally { }
            displayadd();
            displayunable();
        }
    }
}
