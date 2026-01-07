namespace WareHouse.Design
{
    partial class frm_bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_bill = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(197, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_date.Location = new System.Drawing.Point(375, 9);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(83, 19);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "--/--/----";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.lbl_time.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Navy;
            this.lbl_time.Location = new System.Drawing.Point(15, 9);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(43, 19);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "--:--";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_total.Location = new System.Drawing.Point(15, 390);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(68, 19);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total : ";
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_exit.BorderColor = System.Drawing.Color.Navy;
            this.btn_exit.BorderRadius = 13;
            this.btn_exit.BorderThickness = 3;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Navy;
            this.btn_exit.Location = new System.Drawing.Point(359, 379);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(90, 42);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "OK";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dgv_bill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bill.ColumnHeadersHeight = 4;
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bill.Location = new System.Drawing.Point(9, 43);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.RowHeadersVisible = false;
            this.dgv_bill.Size = new System.Drawing.Size(442, 318);
            this.dgv_bill.TabIndex = 21;
            this.dgv_bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_bill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_bill.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_bill.ThemeStyle.ReadOnly = false;
            this.dgv_bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_bill.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frm_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(461, 433);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_bill);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_bill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Bill";
            this.Load += new System.EventHandler(this.frm_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_total;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_bill;
    }
}