namespace WareHouse.Design
{
    partial class frm_category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_category_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_category_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_category = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(558, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category Name :";
            // 
            // txt_category_id
            // 
            this.txt_category_id.BorderRadius = 18;
            this.txt_category_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_category_id.DefaultText = "";
            this.txt_category_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_category_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_category_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_category_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_category_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_category_id.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_category_id.Location = new System.Drawing.Point(283, 104);
            this.txt_category_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_category_id.Name = "txt_category_id";
            this.txt_category_id.PlaceholderText = "";
            this.txt_category_id.ReadOnly = true;
            this.txt_category_id.SelectedText = "";
            this.txt_category_id.Size = new System.Drawing.Size(328, 36);
            this.txt_category_id.TabIndex = 4;
            // 
            // txt_category_name
            // 
            this.txt_category_name.BorderRadius = 18;
            this.txt_category_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_category_name.DefaultText = "";
            this.txt_category_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_category_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_category_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_category_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_category_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_category_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_category_name.Location = new System.Drawing.Point(283, 155);
            this.txt_category_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.PlaceholderText = "";
            this.txt_category_name.SelectedText = "";
            this.txt_category_name.Size = new System.Drawing.Size(328, 36);
            this.txt_category_name.TabIndex = 5;
            // 
            // dgv_category
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_category.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_category.ColumnHeadersHeight = 4;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_category.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_category.Location = new System.Drawing.Point(64, 253);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersVisible = false;
            this.dgv_category.Size = new System.Drawing.Size(940, 410);
            this.dgv_category.TabIndex = 6;
            this.dgv_category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_category.ThemeStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dgv_category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_category.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_category.ThemeStyle.ReadOnly = false;
            this.dgv_category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_category.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
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
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_add_category
            // 
            this.btn_add_category.Animated = true;
            this.btn_add_category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_add_category.BorderRadius = 13;
            this.btn_add_category.BorderThickness = 3;
            this.btn_add_category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_category.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_add_category.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_add_category.Location = new System.Drawing.Point(1026, 268);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(157, 52);
            this.btn_add_category.TabIndex = 13;
            this.btn_add_category.Text = "ADD";
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Animated = true;
            this.btn_edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_edit.BorderRadius = 13;
            this.btn_edit.BorderThickness = 3;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_edit.Location = new System.Drawing.Point(1026, 347);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(157, 52);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_delete.Location = new System.Drawing.Point(1026, 427);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(157, 52);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frm_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1370, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_category);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.txt_category_name);
            this.Controls.Add(this.txt_category_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_category";
            this.ShowIcon = false;
            this.Text = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_category_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_category_name;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_category;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_add_category;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
    }
}