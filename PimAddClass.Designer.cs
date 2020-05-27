namespace class_management
{
    partial class PimAddClass
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
            this.txt_stdQuatuty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_teachername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_stdQuatuty
            // 
            this.txt_stdQuatuty.Location = new System.Drawing.Point(146, 157);
            this.txt_stdQuatuty.Name = "txt_stdQuatuty";
            this.txt_stdQuatuty.Size = new System.Drawing.Size(100, 21);
            this.txt_stdQuatuty.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "上课人数";
            // 
            // txt_teachername
            // 
            this.txt_teachername.Location = new System.Drawing.Point(146, 93);
            this.txt_teachername.Name = "txt_teachername";
            this.txt_teachername.Size = new System.Drawing.Size(100, 21);
            this.txt_teachername.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "课程名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "输入添加信息";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(198, 215);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(45, 215);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 22;
            this.btn_change.Text = "添加";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // PimAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 313);
            this.Controls.Add(this.txt_stdQuatuty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teachername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_change);
            this.Name = "PimAddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PimAddClass";
            this.Load += new System.EventHandler(this.PimAddClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stdQuatuty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_teachername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_change;
    }
}