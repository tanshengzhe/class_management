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
    public partial class GmSelection : Form
    {
        public static int order_flag = 0;
        public static int class_flag = 0;
        public static int teacher_flag = 0;

        public GmSelection()
        {
            InitializeComponent();
        }

        private void bnt_OrdMng_Click(object sender, EventArgs e)
        {
            order_flag = 1;
           GmInfoMng Frm_gmInfo = new GmInfoMng();
            Frm_gmInfo.Show();
            this.Hide();
        }

        private void bnt_TechrInfoMng_Click(object sender, EventArgs e)
        {
            teacher_flag = 1;
            GmInfoMng Frm_gmInfo = new GmInfoMng();
            Frm_gmInfo.Show();
            this.Hide();
        }

        private void bnt_lsnMng_Click(object sender, EventArgs e)
        {
            class_flag = 1;
            GmInfoMng Frm_gmInfo = new GmInfoMng();
            Frm_gmInfo.Show();
            this.Hide();
        }
    }
}
