namespace class_management
{
    partial class PersonalInfoManagment
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
            this.btn_PimAdd = new System.Windows.Forms.Button();
            this.btn_PimChange = new System.Windows.Forms.Button();
            this.btn_PimDelet = new System.Windows.Forms.Button();
            this.lbl_YourOrder = new System.Windows.Forms.Label();
            this.btn_PimSort = new System.Windows.Forms.Button();
            this.Dgv_Pim = new System.Windows.Forms.DataGridView();
            this.cmb_Pimweek = new System.Windows.Forms.ComboBox();
            this.btn_PimBack = new System.Windows.Forms.Button();
            this.cmb_Pimday = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PimAdd
            // 
            this.btn_PimAdd.Location = new System.Drawing.Point(47, 86);
            this.btn_PimAdd.Name = "btn_PimAdd";
            this.btn_PimAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_PimAdd.TabIndex = 0;
            this.btn_PimAdd.Text = "添加";
            this.btn_PimAdd.UseVisualStyleBackColor = true;
            this.btn_PimAdd.Click += new System.EventHandler(this.btn_PimAdd_Click);
            // 
            // btn_PimChange
            // 
            this.btn_PimChange.Location = new System.Drawing.Point(47, 178);
            this.btn_PimChange.Name = "btn_PimChange";
            this.btn_PimChange.Size = new System.Drawing.Size(75, 23);
            this.btn_PimChange.TabIndex = 1;
            this.btn_PimChange.Text = "修改";
            this.btn_PimChange.UseVisualStyleBackColor = true;
            this.btn_PimChange.Click += new System.EventHandler(this.btn_PimChange_Click);
            // 
            // btn_PimDelet
            // 
            this.btn_PimDelet.Location = new System.Drawing.Point(47, 271);
            this.btn_PimDelet.Name = "btn_PimDelet";
            this.btn_PimDelet.Size = new System.Drawing.Size(75, 23);
            this.btn_PimDelet.TabIndex = 2;
            this.btn_PimDelet.Text = "删除";
            this.btn_PimDelet.UseVisualStyleBackColor = true;
            this.btn_PimDelet.Click += new System.EventHandler(this.btn_PimDelet_Click);
            // 
            // lbl_YourOrder
            // 
            this.lbl_YourOrder.AutoSize = true;
            this.lbl_YourOrder.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_YourOrder.Location = new System.Drawing.Point(408, 57);
            this.lbl_YourOrder.Name = "lbl_YourOrder";
            this.lbl_YourOrder.Size = new System.Drawing.Size(74, 21);
            this.lbl_YourOrder.TabIndex = 3;
            this.lbl_YourOrder.Text = "您的预约";
            // 
            // btn_PimSort
            // 
            this.btn_PimSort.Location = new System.Drawing.Point(251, 57);
            this.btn_PimSort.Name = "btn_PimSort";
            this.btn_PimSort.Size = new System.Drawing.Size(45, 23);
            this.btn_PimSort.TabIndex = 4;
            this.btn_PimSort.Text = "刷新";
            this.btn_PimSort.UseVisualStyleBackColor = true;
            this.btn_PimSort.Click += new System.EventHandler(this.btn_PimSort_Click);
            // 
            // Dgv_Pim
            // 
            this.Dgv_Pim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pim.Location = new System.Drawing.Point(251, 86);
            this.Dgv_Pim.Name = "Dgv_Pim";
            this.Dgv_Pim.RowTemplate.Height = 23;
            this.Dgv_Pim.Size = new System.Drawing.Size(390, 215);
            this.Dgv_Pim.TabIndex = 5;
            // 
            // cmb_Pimweek
            // 
            this.cmb_Pimweek.FormattingEnabled = true;
            this.cmb_Pimweek.Location = new System.Drawing.Point(328, 307);
            this.cmb_Pimweek.Name = "cmb_Pimweek";
            this.cmb_Pimweek.Size = new System.Drawing.Size(82, 20);
            this.cmb_Pimweek.TabIndex = 6;
            this.cmb_Pimweek.SelectedIndexChanged += new System.EventHandler(this.cmb_Pimweek_SelectedIndexChanged);
            // 
            // btn_PimBack
            // 
            this.btn_PimBack.Location = new System.Drawing.Point(291, 340);
            this.btn_PimBack.Name = "btn_PimBack";
            this.btn_PimBack.Size = new System.Drawing.Size(98, 42);
            this.btn_PimBack.TabIndex = 7;
            this.btn_PimBack.Text = "返回";
            this.btn_PimBack.UseVisualStyleBackColor = true;
            this.btn_PimBack.Click += new System.EventHandler(this.btn_PimBack_Click);
            // 
            // cmb_Pimday
            // 
            this.cmb_Pimday.FormattingEnabled = true;
            this.cmb_Pimday.Location = new System.Drawing.Point(510, 307);
            this.cmb_Pimday.Name = "cmb_Pimday";
            this.cmb_Pimday.Size = new System.Drawing.Size(82, 20);
            this.cmb_Pimday.TabIndex = 8;
            // 
            // PersonalInfoManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 406);
            this.Controls.Add(this.cmb_Pimday);
            this.Controls.Add(this.btn_PimBack);
            this.Controls.Add(this.cmb_Pimweek);
            this.Controls.Add(this.Dgv_Pim);
            this.Controls.Add(this.btn_PimSort);
            this.Controls.Add(this.lbl_YourOrder);
            this.Controls.Add(this.btn_PimDelet);
            this.Controls.Add(this.btn_PimChange);
            this.Controls.Add(this.btn_PimAdd);
            this.Name = "PersonalInfoManagment";
            this.Text = "个人中心";
            this.Load += new System.EventHandler(this.PersonalInfoManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PimAdd;
        private System.Windows.Forms.Button btn_PimChange;
        private System.Windows.Forms.Button btn_PimDelet;
        private System.Windows.Forms.Label lbl_YourOrder;
        private System.Windows.Forms.Button btn_PimSort;
        private System.Windows.Forms.DataGridView Dgv_Pim;
        private System.Windows.Forms.ComboBox cmb_Pimweek;
        private System.Windows.Forms.Button btn_PimBack;
        private System.Windows.Forms.ComboBox cmb_Pimday;
    }
}