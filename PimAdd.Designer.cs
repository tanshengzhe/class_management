﻿namespace class_management
{
    partial class PimAdd
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
            this.Dgv_PA = new System.Windows.Forms.DataGridView();
            this.cmb_PimAddWeek = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PaTitle = new System.Windows.Forms.Label();
            this.bnt_PaBack = new System.Windows.Forms.Button();
            this.bnt_PaAdd = new System.Windows.Forms.Button();
            this.lbl_PaTitle2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PA)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_PA
            // 
            this.Dgv_PA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_PA.Location = new System.Drawing.Point(362, 103);
            this.Dgv_PA.Name = "Dgv_PA";
            this.Dgv_PA.RowTemplate.Height = 23;
            this.Dgv_PA.Size = new System.Drawing.Size(368, 222);
            this.Dgv_PA.TabIndex = 0;
            // 
            // cmb_PimAddWeek
            // 
            this.cmb_PimAddWeek.FormattingEnabled = true;
            this.cmb_PimAddWeek.Location = new System.Drawing.Point(489, 331);
            this.cmb_PimAddWeek.Name = "cmb_PimAddWeek";
            this.cmb_PimAddWeek.Size = new System.Drawing.Size(121, 20);
            this.cmb_PimAddWeek.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lbl_PaTitle
            // 
            this.lbl_PaTitle.AutoSize = true;
            this.lbl_PaTitle.Location = new System.Drawing.Point(105, 61);
            this.lbl_PaTitle.Name = "lbl_PaTitle";
            this.lbl_PaTitle.Size = new System.Drawing.Size(65, 12);
            this.lbl_PaTitle.TabIndex = 4;
            this.lbl_PaTitle.Text = "请输入信息";
            // 
            // bnt_PaBack
            // 
            this.bnt_PaBack.Location = new System.Drawing.Point(446, 376);
            this.bnt_PaBack.Name = "bnt_PaBack";
            this.bnt_PaBack.Size = new System.Drawing.Size(110, 43);
            this.bnt_PaBack.TabIndex = 5;
            this.bnt_PaBack.Text = "返回";
            this.bnt_PaBack.UseVisualStyleBackColor = true;
            // 
            // bnt_PaAdd
            // 
            this.bnt_PaAdd.Location = new System.Drawing.Point(230, 376);
            this.bnt_PaAdd.Name = "bnt_PaAdd";
            this.bnt_PaAdd.Size = new System.Drawing.Size(110, 43);
            this.bnt_PaAdd.TabIndex = 6;
            this.bnt_PaAdd.Text = "添加";
            this.bnt_PaAdd.UseVisualStyleBackColor = true;
            // 
            // lbl_PaTitle2
            // 
            this.lbl_PaTitle2.AutoSize = true;
            this.lbl_PaTitle2.Location = new System.Drawing.Point(504, 79);
            this.lbl_PaTitle2.Name = "lbl_PaTitle2";
            this.lbl_PaTitle2.Size = new System.Drawing.Size(77, 12);
            this.lbl_PaTitle2.TabIndex = 7;
            this.lbl_PaTitle2.Text = "当前可选时间";
            this.lbl_PaTitle2.Click += new System.EventHandler(this.lbl_PaTitle2_Click);
            // 
            // PimAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PaTitle2);
            this.Controls.Add(this.bnt_PaAdd);
            this.Controls.Add(this.bnt_PaBack);
            this.Controls.Add(this.lbl_PaTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_PimAddWeek);
            this.Controls.Add(this.Dgv_PA);
            this.Name = "PimAdd";
            this.Text = "添加";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_PA;
        private System.Windows.Forms.ComboBox cmb_PimAddWeek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PaTitle;
        private System.Windows.Forms.Button bnt_PaBack;
        private System.Windows.Forms.Button bnt_PaAdd;
        private System.Windows.Forms.Label lbl_PaTitle2;
    }
}