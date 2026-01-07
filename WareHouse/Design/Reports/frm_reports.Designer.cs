namespace WareHouse.Design
{
    partial class frm_inventory
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
            this.dgv_rports = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_inventory = new Guna.UI2.WinForms.Guna2Button();
            this.btn_profit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sales = new Guna.UI2.WinForms.Guna2Button();
            this.btn_print = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_discounts = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(700, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reports";
            // 
            // dgv_rports
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_rports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rports.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rports.ColumnHeadersHeight = 4;
            this.dgv_rports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rports.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rports.Location = new System.Drawing.Point(12, 261);
            this.dgv_rports.Name = "dgv_rports";
            this.dgv_rports.RowHeadersVisible = false;
            this.dgv_rports.Size = new System.Drawing.Size(1043, 444);
            this.dgv_rports.TabIndex = 28;
            this.dgv_rports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rports.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_rports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_rports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_rports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_rports.ThemeStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dgv_rports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_rports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_rports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_rports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_rports.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_rports.ThemeStyle.ReadOnly = false;
            this.dgv_rports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_rports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_rports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_rports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_rports.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_rports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_rports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_rports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rports_CellClick);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Animated = true;
            this.btn_inventory.BorderColor = System.Drawing.Color.Teal;
            this.btn_inventory.BorderRadius = 13;
            this.btn_inventory.BorderThickness = 3;
            this.btn_inventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_inventory.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.Teal;
            this.btn_inventory.Location = new System.Drawing.Point(41, 107);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(269, 44);
            this.btn_inventory.TabIndex = 29;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_profit
            // 
            this.btn_profit.Animated = true;
            this.btn_profit.BorderColor = System.Drawing.Color.Teal;
            this.btn_profit.BorderRadius = 13;
            this.btn_profit.BorderThickness = 3;
            this.btn_profit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_profit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_profit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_profit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_profit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_profit.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profit.ForeColor = System.Drawing.Color.Teal;
            this.btn_profit.Location = new System.Drawing.Point(41, 180);
            this.btn_profit.Name = "btn_profit";
            this.btn_profit.Size = new System.Drawing.Size(269, 44);
            this.btn_profit.TabIndex = 30;
            this.btn_profit.Text = "Profit";
            this.btn_profit.Click += new System.EventHandler(this.btn_profit_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Animated = true;
            this.btn_sales.BorderColor = System.Drawing.Color.Teal;
            this.btn_sales.BorderRadius = 13;
            this.btn_sales.BorderThickness = 3;
            this.btn_sales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_sales.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.Teal;
            this.btn_sales.Location = new System.Drawing.Point(354, 180);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(280, 44);
            this.btn_sales.TabIndex = 31;
            this.btn_sales.Text = "Bills";
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_print
            // 
            this.btn_print.Animated = true;
            this.btn_print.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_print.BorderRadius = 13;
            this.btn_print.BorderThickness = 3;
            this.btn_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_print.Location = new System.Drawing.Point(1076, 279);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(151, 66);
            this.btn_print.TabIndex = 34;
            this.btn_print.Text = "Print";
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BorderColor = System.Drawing.Color.Red;
            this.btn_exit.BorderRadius = 13;
            this.btn_exit.BorderThickness = 3;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(1188, 653);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(170, 76);
            this.btn_exit.TabIndex = 35;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_delete.BorderRadius = 13;
            this.btn_delete.BorderThickness = 3;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_delete.Location = new System.Drawing.Point(1076, 390);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 66);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete Bills";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_discounts
            // 
            this.btn_discounts.Animated = true;
            this.btn_discounts.BorderColor = System.Drawing.Color.Teal;
            this.btn_discounts.BorderRadius = 13;
            this.btn_discounts.BorderThickness = 3;
            this.btn_discounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_discounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_discounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_discounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_discounts.Enabled = false;
            this.btn_discounts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_discounts.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discounts.ForeColor = System.Drawing.Color.Teal;
            this.btn_discounts.Location = new System.Drawing.Point(354, 107);
            this.btn_discounts.Name = "btn_discounts";
            this.btn_discounts.Size = new System.Drawing.Size(280, 44);
            this.btn_discounts.TabIndex = 37;
            this.btn_discounts.Text = "Discounts";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(170, 708);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(86, 25);
            this.lbl_total.TabIndex = 38;
            this.lbl_total.Text = "Total : ";
            // 
            // frm_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1370, 741);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_discounts);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_profit);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.dgv_rports);
            this.Controls.Add(this.label1);
            this.Name = "frm_inventory";
            this.ShowIcon = false;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_rports;
        private Guna.UI2.WinForms.Guna2Button btn_inventory;
        private Guna.UI2.WinForms.Guna2Button btn_profit;
        private Guna.UI2.WinForms.Guna2Button btn_sales;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_discounts;
        private System.Windows.Forms.Label lbl_total;
    }
}