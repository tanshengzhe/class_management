namespace class_management
{
    partial class PimChange
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
            this.lbl_PcTitle = new System.Windows.Forms.Label();
            this.lbl_PcTeacher = new System.Windows.Forms.Label();
            this.txt_PcTeacher = new System.Windows.Forms.TextBox();
            this.btn_PcYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PcTitle
            // 
            this.lbl_PcTitle.AutoSize = true;
            this.lbl_PcTitle.Location = new System.Drawing.Point(107, 64);
            this.lbl_PcTitle.Name = "lbl_PcTitle";
            this.lbl_PcTitle.Size = new System.Drawing.Size(65, 12);
            this.lbl_PcTitle.TabIndex = 7;
            this.lbl_PcTitle.Text = "请输入信息";
            // 
            // lbl_PcTeacher
            // 
            this.lbl_PcTeacher.AutoSize = true;
            this.lbl_PcTeacher.Location = new System.Drawing.Point(61, 109);
            this.lbl_PcTeacher.Name = "lbl_PcTeacher";
            this.lbl_PcTeacher.Size = new System.Drawing.Size(41, 12);
            this.lbl_PcTeacher.TabIndex = 6;
            this.lbl_PcTeacher.Text = "label1";
            // 
            // txt_PcTeacher
            // 
            this.txt_PcTeacher.Location = new System.Drawing.Point(142, 106);
            this.txt_PcTeacher.Name = "txt_PcTeacher";
            this.txt_PcTeacher.Size = new System.Drawing.Size(100, 21);
            this.txt_PcTeacher.TabIndex = 5;
            // 
            // btn_PcYes
            // 
            this.btn_PcYes.Location = new System.Drawing.Point(96, 308);
            this.btn_PcYes.Name = "btn_PcYes";
            this.btn_PcYes.Size = new System.Drawing.Size(110, 46);
            this.btn_PcYes.TabIndex = 8;
            this.btn_PcYes.Text = "button1";
            this.btn_PcYes.UseVisualStyleBackColor = true;
            // 
            // PimChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 404);
            this.Controls.Add(this.btn_PcYes);
            this.Controls.Add(this.lbl_PcTitle);
            this.Controls.Add(this.lbl_PcTeacher);
            this.Controls.Add(this.txt_PcTeacher);
            this.Name = "PimChange";
            this.Text = "修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PcTitle;
        private System.Windows.Forms.Label lbl_PcTeacher;
        private System.Windows.Forms.TextBox txt_PcTeacher;
        private System.Windows.Forms.Button btn_PcYes;
    }
}