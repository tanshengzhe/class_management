namespace class_management
{
    partial class GmChangeTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_teachername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_teacherid = new System.Windows.Forms.TextBox();
            this.lbl_teacherid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tchrpassword = new System.Windows.Forms.TextBox();
            this.lbl_teacherpaddword = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_teachername
            // 
            this.txt_teachername.Location = new System.Drawing.Point(158, 165);
            this.txt_teachername.Name = "txt_teachername";
            this.txt_teachername.Size = new System.Drawing.Size(100, 21);
            this.txt_teachername.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "教师姓名";
            // 
            // txt_teacherid
            // 
            this.txt_teacherid.Location = new System.Drawing.Point(158, 115);
            this.txt_teacherid.Name = "txt_teacherid";
            this.txt_teacherid.Size = new System.Drawing.Size(100, 21);
            this.txt_teacherid.TabIndex = 15;
            // 
            // lbl_teacherid
            // 
            this.lbl_teacherid.AutoSize = true;
            this.lbl_teacherid.Location = new System.Drawing.Point(76, 118);
            this.lbl_teacherid.Name = "lbl_teacherid";
            this.lbl_teacherid.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherid.TabIndex = 14;
            this.lbl_teacherid.Text = "教师工号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "输入修改信息";
            // 
            // txt_tchrpassword
            // 
            this.txt_tchrpassword.Location = new System.Drawing.Point(158, 216);
            this.txt_tchrpassword.Name = "txt_tchrpassword";
            this.txt_tchrpassword.Size = new System.Drawing.Size(100, 21);
            this.txt_tchrpassword.TabIndex = 12;
            // 
            // lbl_teacherpaddword
            // 
            this.lbl_teacherpaddword.AutoSize = true;
            this.lbl_teacherpaddword.Location = new System.Drawing.Point(76, 219);
            this.lbl_teacherpaddword.Name = "lbl_teacherpaddword";
            this.lbl_teacherpaddword.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherpaddword.TabIndex = 11;
            this.lbl_teacherpaddword.Text = "教师密码";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(224, 291);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(71, 291);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 9;
            this.btn_change.Text = "添加";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // GmChangeTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 376);
            this.Controls.Add(this.txt_teachername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teacherid);
            this.Controls.Add(this.lbl_teacherid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tchrpassword);
            this.Controls.Add(this.lbl_teacherpaddword);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_change);
            this.Name = "GmChangeTeacher";
            this.Text = "GmChangeTeacher";
            this.Load += new System.EventHandler(this.GmChangeTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_teachername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_teacherid;
        private System.Windows.Forms.Label lbl_teacherid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tchrpassword;
        private System.Windows.Forms.Label lbl_teacherpaddword;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_change;
    }
}