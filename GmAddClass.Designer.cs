namespace class_management
{
    partial class GmAddClass
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
            this.txt_stdQuatuty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_teachername
            // 
            this.txt_teachername.Location = new System.Drawing.Point(154, 157);
            this.txt_teachername.Name = "txt_teachername";
            this.txt_teachername.Size = new System.Drawing.Size(100, 21);
            this.txt_teachername.TabIndex = 17;
            this.txt_teachername.TextChanged += new System.EventHandler(this.txt_teachername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "课程名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_teacherid
            // 
            this.txt_teacherid.Location = new System.Drawing.Point(154, 107);
            this.txt_teacherid.Name = "txt_teacherid";
            this.txt_teacherid.Size = new System.Drawing.Size(100, 21);
            this.txt_teacherid.TabIndex = 15;
            this.txt_teacherid.TextChanged += new System.EventHandler(this.txt_teacherid_TextChanged);
            // 
            // lbl_teacherid
            // 
            this.lbl_teacherid.AutoSize = true;
            this.lbl_teacherid.Location = new System.Drawing.Point(72, 110);
            this.lbl_teacherid.Name = "lbl_teacherid";
            this.lbl_teacherid.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherid.TabIndex = 14;
            this.lbl_teacherid.Text = "课程编号";
            this.lbl_teacherid.Click += new System.EventHandler(this.lbl_teacherid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "输入添加信息";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_tchrpassword
            // 
            this.txt_tchrpassword.Location = new System.Drawing.Point(154, 208);
            this.txt_tchrpassword.Name = "txt_tchrpassword";
            this.txt_tchrpassword.Size = new System.Drawing.Size(100, 21);
            this.txt_tchrpassword.TabIndex = 12;
            this.txt_tchrpassword.TextChanged += new System.EventHandler(this.txt_tchrpassword_TextChanged);
            // 
            // lbl_teacherpaddword
            // 
            this.lbl_teacherpaddword.AutoSize = true;
            this.lbl_teacherpaddword.Location = new System.Drawing.Point(72, 211);
            this.lbl_teacherpaddword.Name = "lbl_teacherpaddword";
            this.lbl_teacherpaddword.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherpaddword.TabIndex = 11;
            this.lbl_teacherpaddword.Text = "任课教师";
            this.lbl_teacherpaddword.Click += new System.EventHandler(this.lbl_teacherpaddword_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(217, 302);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(64, 302);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 9;
            this.btn_change.Text = "添加";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // txt_stdQuatuty
            // 
            this.txt_stdQuatuty.Location = new System.Drawing.Point(154, 256);
            this.txt_stdQuatuty.Name = "txt_stdQuatuty";
            this.txt_stdQuatuty.Size = new System.Drawing.Size(100, 21);
            this.txt_stdQuatuty.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "上课人数";
            // 
            // GmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 368);
            this.Controls.Add(this.txt_stdQuatuty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teachername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_teacherid);
            this.Controls.Add(this.lbl_teacherid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tchrpassword);
            this.Controls.Add(this.lbl_teacherpaddword);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_change);
            this.Name = "GmAddClass";
            this.Text = "GmAddClass";
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
        private System.Windows.Forms.TextBox txt_stdQuatuty;
        private System.Windows.Forms.Label label3;
    }
}