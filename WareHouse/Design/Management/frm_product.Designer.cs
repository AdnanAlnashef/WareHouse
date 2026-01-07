namespace WareHouse.Design
{
    partial class frm_product
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_product_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_selling_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_purchase_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_product_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_category_list = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_delete_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_product = new Guna.UI2.WinForms.Guna2Button();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(601, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Purchase Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Selling Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(708, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Added To The Category :";
            // 
            // txt_product_id
            // 
            this.txt_product_id.BorderRadius = 18;
            this.txt_product_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_id.DefaultText = "";
            this.txt_product_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_id.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_id.Location = new System.Drawing.Point(273, 70);
            this.txt_product_id.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.PlaceholderText = "";
            this.txt_product_id.ReadOnly = true;
            this.txt_product_id.SelectedText = "";
            this.txt_product_id.Size = new System.Drawing.Size(328, 36);
            this.txt_product_id.TabIndex = 9;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BorderRadius = 18;
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quantity.DefaultText = "";
            this.txt_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Location = new System.Drawing.Point(273, 254);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PlaceholderText = "";
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.Size = new System.Drawing.Size(328, 36);
            this.txt_quantity.TabIndex = 10;
            // 
            // txt_selling_price
            // 
            this.txt_selling_price.BorderRadius = 18;
            this.txt_selling_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_selling_price.DefaultText = "";
            this.txt_selling_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_selling_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_selling_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_selling_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_selling_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_selling_price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selling_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_selling_price.Location = new System.Drawing.Point(273, 208);
            this.txt_selling_price.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_selling_price.Name = "txt_selling_price";
            this.txt_selling_price.PlaceholderText = "";
            this.txt_selling_price.SelectedText = "";
            this.txt_selling_price.Size = new System.Drawing.Size(328, 36);
            this.txt_selling_price.TabIndex = 11;
            // 
            // txt_purchase_price
            // 
            this.txt_purchase_price.BorderRadius = 18;
            this.txt_purchase_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_purchase_price.DefaultText = "";
            this.txt_purchase_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_purchase_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_purchase_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purchase_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_purchase_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purchase_price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchase_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_purchase_price.Location = new System.Drawing.Point(273, 162);
            this.txt_purchase_price.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_purchase_price.Name = "txt_purchase_price";
            this.txt_purchase_price.PlaceholderText = "";
            this.txt_purchase_price.SelectedText = "";
            this.txt_purchase_price.Size = new System.Drawing.Size(328, 36);
            this.txt_purchase_price.TabIndex = 12;
            // 
            // txt_product_name
            // 
            this.txt_product_name.BorderRadius = 18;
            this.txt_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_name.DefaultText = "";
            this.txt_product_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_name.Location = new System.Drawing.Point(273, 116);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.PlaceholderText = "";
            this.txt_product_name.SelectedText = "";
            this.txt_product_name.Size = new System.Drawing.Size(328, 36);
            this.txt_product_name.TabIndex = 13;
            // 
            // cmb_category_list
            // 
            this.cmb_category_list.BackColor = System.Drawing.Color.Transparent;
            this.cmb_category_list.BorderRadius = 15;
            this.cmb_category_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_category_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category_list.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_category_list.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_category_list.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmb_category_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_category_list.ItemHeight = 30;
            this.cmb_category_list.Location = new System.Drawing.Point(1038, 70);
            this.cmb_category_list.Name = "cmb_category_list";
            this.cmb_category_list.Size = new System.Drawing.Size(243, 36);
            this.cmb_category_list.TabIndex = 14;
            // 
            // dgv_product
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_product.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_product.ColumnHeadersHeight = 4;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_product.Location = new System.Drawing.Point(17, 311);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.Size = new System.Drawing.Size(953, 418);
            this.dgv_product.TabIndex = 15;
            this.dgv_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_product.ThemeStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dgv_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_product.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_product.ThemeStyle.ReadOnly = false;
            this.dgv_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_product.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Animated = true;
            this.btn_delete_product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_delete_product.BorderRadius = 13;
            this.btn_delete_product.BorderThickness = 3;
            this.btn_delete_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_delete_product.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_delete_product.Location = new System.Drawing.Point(997, 470);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(157, 52);
            this.btn_delete_product.TabIndex = 18;
            this.btn_delete_product.Text = "DELETE";
            this.btn_delete_product.Click += new System.EventHandler(this.btn_delete_product_Click);
            // 
            // btn_edit_product
            // 
            this.btn_edit_product.Animated = true;
            this.btn_edit_product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_edit_product.BorderRadius = 13;
            this.btn_edit_product.BorderThickness = 3;
            this.btn_edit_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_edit_product.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_edit_product.Location = new System.Drawing.Point(997, 390);
            this.btn_edit_product.Name = "btn_edit_product";
            this.btn_edit_product.Size = new System.Drawing.Size(157, 52);
            this.btn_edit_product.TabIndex = 17;
            this.btn_edit_product.Text = "EDIT";
            this.btn_edit_product.Click += new System.EventHandler(this.btn_edit_product_Click);
            // 
            // btn_add_product
            // 
            this.btn_add_product.Animated = true;
            this.btn_add_product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_add_product.BorderRadius = 13;
            this.btn_add_product.BorderThickness = 3;
            this.btn_add_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_add_product.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_add_product.Location = new System.Drawing.Point(997, 311);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(157, 52);
            this.btn_add_product.TabIndex = 16;
            this.btn_add_product.Text = "ADD";
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
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
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frm_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1370, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete_product);
            this.Controls.Add(this.btn_edit_product);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.cmb_category_list);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_purchase_price);
            this.Controls.Add(this.txt_selling_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_product";
            this.ShowIcon = false;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frm_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_selling_price;
        private Guna.UI2.WinForms.Guna2TextBox txt_purchase_price;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_name;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_category_list;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_product;
        private Guna.UI2.WinForms.Guna2Button btn_delete_product;
        private Guna.UI2.WinForms.Guna2Button btn_edit_product;
        private Guna.UI2.WinForms.Guna2Button btn_add_product;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
    }
}