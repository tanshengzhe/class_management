namespace class_management
{
    partial class GmTimechange
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
            this.cmb_PimAddday = new System.Windows.Forms.ComboBox();
            this.cmb_PimAddWeek = new System.Windows.Forms.ComboBox();
            this.Dgv_PA = new System.Windows.Forms.DataGridView();
            this.bnt_no = new System.Windows.Forms.Button();
            this.Dgv_Unable = new System.Windows.Forms.DataGridView();
            this.bnt_enable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Unable)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_PimAddday
            // 
            this.cmb_PimAddday.FormattingEnabled = true;
            this.cmb_PimAddday.Location = new System.Drawing.Point(257, 281);
            this.cmb_PimAddday.Name = "cmb_PimAddday";
            this.cmb_PimAddday.Size = new System.Drawing.Size(121, 20);
            this.cmb_PimAddday.TabIndex = 10;
            this.cmb_PimAddday.Text = "星期一";
            this.cmb_PimAddday.SelectedIndexChanged += new System.EventHandler(this.cmb_PimAddday_SelectedIndexChanged);
            // 
            // cmb_PimAddWeek
            // 
            this.cmb_PimAddWeek.FormattingEnabled = true;
            this.cmb_PimAddWeek.Location = new System.Drawing.Point(74, 281);
            this.cmb_PimAddWeek.Name = "cmb_PimAddWeek";
            this.cmb_PimAddWeek.Size = new System.Drawing.Size(121, 20);
            this.cmb_PimAddWeek.TabIndex = 9;
            this.cmb_PimAddWeek.Text = "第二周";
            this.cmb_PimAddWeek.SelectedIndexChanged += new System.EventHandler(this.cmb_PimAddWeek_SelectedIndexChanged);
            // 
            // Dgv_PA
            // 
            this.Dgv_PA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_PA.Location = new System.Drawing.Point(46, 35);
            this.Dgv_PA.Name = "Dgv_PA";
            this.Dgv_PA.RowTemplate.Height = 23;
            this.Dgv_PA.Size = new System.Drawing.Size(368, 222);
            this.Dgv_PA.TabIndex = 11;
            // 
            // bnt_no
            // 
            this.bnt_no.Location = new System.Drawing.Point(185, 319);
            this.bnt_no.Name = "bnt_no";
            this.bnt_no.Size = new System.Drawing.Size(75, 23);
            this.bnt_no.TabIndex = 12;
            this.bnt_no.Text = "禁用";
            this.bnt_no.UseVisualStyleBackColor = true;
            this.bnt_no.Click += new System.EventHandler(this.bnt_no_Click);
            // 
            // Dgv_Unable
            // 
            this.Dgv_Unable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Unable.Location = new System.Drawing.Point(550, 35);
            this.Dgv_Unable.Name = "Dgv_Unable";
            this.Dgv_Unable.RowTemplate.Height = 23;
            this.Dgv_Unable.Size = new System.Drawing.Size(368, 222);
            this.Dgv_Unable.TabIndex = 13;
            // 
            // bnt_enable
            // 
            this.bnt_enable.Location = new System.Drawing.Point(697, 319);
            this.bnt_enable.Name = "bnt_enable";
            this.bnt_enable.Size = new System.Drawing.Size(75, 23);
            this.bnt_enable.TabIndex = 14;
            this.bnt_enable.Text = "解禁";
            this.bnt_enable.UseVisualStyleBackColor = true;
            this.bnt_enable.Click += new System.EventHandler(this.bnt_enable_Click);
            // 
            // GmTimechange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 366);
            this.Controls.Add(this.bnt_enable);
            this.Controls.Add(this.Dgv_Unable);
            this.Controls.Add(this.bnt_no);
            this.Controls.Add(this.Dgv_PA);
            this.Controls.Add(this.cmb_PimAddday);
            this.Controls.Add(this.cmb_PimAddWeek);
            this.Name = "GmTimechange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GmTimechange";
            this.Load += new System.EventHandler(this.GmTimechange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_PA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Unable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_PimAddday;
        private System.Windows.Forms.ComboBox cmb_PimAddWeek;
        private System.Windows.Forms.DataGridView Dgv_PA;
        private System.Windows.Forms.Button bnt_no;
        private System.Windows.Forms.DataGridView Dgv_Unable;
        private System.Windows.Forms.Button bnt_enable;
    }
}