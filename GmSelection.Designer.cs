namespace class_management
{
    partial class GmSelection
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
            this.bnt_OrdMng = new System.Windows.Forms.Button();
            this.bnt_TechrInfoMng = new System.Windows.Forms.Button();
            this.bnt_lsnMng = new System.Windows.Forms.Button();
            this.bnt_GmBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_OrdMng
            // 
            this.bnt_OrdMng.Location = new System.Drawing.Point(47, 170);
            this.bnt_OrdMng.Name = "bnt_OrdMng";
            this.bnt_OrdMng.Size = new System.Drawing.Size(179, 81);
            this.bnt_OrdMng.TabIndex = 0;
            this.bnt_OrdMng.Text = "预约管理";
            this.bnt_OrdMng.UseVisualStyleBackColor = true;
            this.bnt_OrdMng.Click += new System.EventHandler(this.bnt_OrdMng_Click);
            // 
            // bnt_TechrInfoMng
            // 
            this.bnt_TechrInfoMng.Location = new System.Drawing.Point(295, 170);
            this.bnt_TechrInfoMng.Name = "bnt_TechrInfoMng";
            this.bnt_TechrInfoMng.Size = new System.Drawing.Size(179, 81);
            this.bnt_TechrInfoMng.TabIndex = 1;
            this.bnt_TechrInfoMng.Text = "教师信息管理";
            this.bnt_TechrInfoMng.UseVisualStyleBackColor = true;
            this.bnt_TechrInfoMng.Click += new System.EventHandler(this.bnt_TechrInfoMng_Click);
            // 
            // bnt_lsnMng
            // 
            this.bnt_lsnMng.Location = new System.Drawing.Point(543, 170);
            this.bnt_lsnMng.Name = "bnt_lsnMng";
            this.bnt_lsnMng.Size = new System.Drawing.Size(179, 81);
            this.bnt_lsnMng.TabIndex = 2;
            this.bnt_lsnMng.Text = "课程管理";
            this.bnt_lsnMng.UseVisualStyleBackColor = true;
            this.bnt_lsnMng.Click += new System.EventHandler(this.bnt_lsnMng_Click);
            // 
            // bnt_GmBack
            // 
            this.bnt_GmBack.Location = new System.Drawing.Point(346, 333);
            this.bnt_GmBack.Name = "bnt_GmBack";
            this.bnt_GmBack.Size = new System.Drawing.Size(75, 23);
            this.bnt_GmBack.TabIndex = 3;
            this.bnt_GmBack.Text = "button4";
            this.bnt_GmBack.UseVisualStyleBackColor = true;
            // 
            // GmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_GmBack);
            this.Controls.Add(this.bnt_lsnMng);
            this.Controls.Add(this.bnt_TechrInfoMng);
            this.Controls.Add(this.bnt_OrdMng);
            this.Name = "GmSelection";
            this.Text = "GmSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_OrdMng;
        private System.Windows.Forms.Button bnt_TechrInfoMng;
        private System.Windows.Forms.Button bnt_lsnMng;
        private System.Windows.Forms.Button bnt_GmBack;
    }
}