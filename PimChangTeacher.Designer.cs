namespace class_management
{
    partial class PimChangTeacher
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
            this.txt_tchrpassword = new System.Windows.Forms.TextBox();
            this.lbl_teacherpaddword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tchrpassword
            // 
            this.txt_tchrpassword.Location = new System.Drawing.Point(124, 87);
            this.txt_tchrpassword.Name = "txt_tchrpassword";
            this.txt_tchrpassword.Size = new System.Drawing.Size(100, 21);
            this.txt_tchrpassword.TabIndex = 14;
            // 
            // lbl_teacherpaddword
            // 
            this.lbl_teacherpaddword.AutoSize = true;
            this.lbl_teacherpaddword.Location = new System.Drawing.Point(42, 90);
            this.lbl_teacherpaddword.Name = "lbl_teacherpaddword";
            this.lbl_teacherpaddword.Size = new System.Drawing.Size(53, 12);
            this.lbl_teacherpaddword.TabIndex = 13;
            this.lbl_teacherpaddword.Text = "教师密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "输入修改信息";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(84, 136);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 16;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // PimChangTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 206);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tchrpassword);
            this.Controls.Add(this.lbl_teacherpaddword);
            this.Name = "PimChangTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PimChangTeacher";
            this.Load += new System.EventHandler(this.PimChangTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tchrpassword;
        private System.Windows.Forms.Label lbl_teacherpaddword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_change;
    }
}