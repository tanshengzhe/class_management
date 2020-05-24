namespace class_management
{
    partial class logon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.bnt_Quit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(95, 138);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(29, 12);
            this.lblpassword.TabIndex = 17;
            this.lblpassword.Text = "密码";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(95, 104);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(29, 12);
            this.lblusername.TabIndex = 16;
            this.lblusername.Text = "学号";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(165, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 21);
            this.txtPassword.TabIndex = 15;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(165, 98);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(184, 21);
            this.txtusername.TabIndex = 14;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(-3, 35);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(504, 26);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "图书管理系统";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnt_Quit
            // 
            this.bnt_Quit.Location = new System.Drawing.Point(295, 170);
            this.bnt_Quit.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_Quit.Name = "bnt_Quit";
            this.bnt_Quit.Size = new System.Drawing.Size(66, 30);
            this.bnt_Quit.TabIndex = 12;
            this.bnt_Quit.Text = "退出";
            this.bnt_Quit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 169);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogin_in
            // 
            this.btnLogin_in.Location = new System.Drawing.Point(141, 169);
            this.btnLogin_in.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin_in.Name = "btnLogin_in";
            this.btnLogin_in.Size = new System.Drawing.Size(60, 32);
            this.btnLogin_in.TabIndex = 10;
            this.btnLogin_in.Text = "登陆";
            this.btnLogin_in.UseVisualStyleBackColor = true;
            // 
            // logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.bnt_Quit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogin_in);
            this.Name = "logon";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button bnt_Quit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogin_in;
    }
}

