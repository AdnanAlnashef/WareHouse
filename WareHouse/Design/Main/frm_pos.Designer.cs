namespace WareHouse.Design
{
    partial class frm_pos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_bills = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv_order = new Guna.UI2.WinForms.Guna2DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.txt_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_print = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new = new Guna.UI2.WinForms.Guna2Button();
            this.btn_show_quantity = new Guna.UI2.WinForms.Guna2Button();
            this.txt_enteredAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_archive = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_invoice = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_menu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.upd_invoice_number = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_note = new Guna.UI2.WinForms.Guna2TextBox();
            this.flp_btn_categories = new System.Windows.Forms.FlowLayoutPanel();
            this.flb_btn_products = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upd_invoice_number)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bills
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_bills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bills.ColumnHeadersHeight = 4;
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bills.Location = new System.Drawing.Point(13, 33);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.Size = new System.Drawing.Size(484, 305);
            this.dgv_bills.TabIndex = 0;
            this.dgv_bills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bills.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_bills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_bills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_bills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_bills.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bills.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_bills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_bills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_bills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_bills.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_bills.ThemeStyle.ReadOnly = false;
            this.dgv_bills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_bills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_bills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_bills.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_bills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_bills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellClick);
            this.dgv_bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bills_CellContentClick);
            // 
            // dgv_order
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_order.ColumnHeadersHeight = 4;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_order.Location = new System.Drawing.Point(529, 33);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersVisible = false;
            this.dgv_order.Size = new System.Drawing.Size(465, 305);
            this.dgv_order.TabIndex = 1;
            this.dgv_order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_order.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_order.ThemeStyle.ReadOnly = false;
            this.dgv_order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_order.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellClick);
            this.dgv_order.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellValueChanged);
            this.dgv_order.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_order_CurrentCellDirtyStateChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BorderColor = System.Drawing.Color.Red;
            this.btn_delete.BorderRadius = 13;
            this.btn_delete.BorderThickness = 1;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(919, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 24);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btn_delete, "Delete an item from the order");
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_total
            // 
            this.txt_total.BorderRadius = 14;
            this.txt_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_total.DefaultText = "";
            this.txt_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_total.Location = new System.Drawing.Point(1053, 52);
            this.txt_total.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_total.Name = "txt_total";
            this.txt_total.PlaceholderText = "";
            this.txt_total.ReadOnly = true;
            this.txt_total.SelectedText = "";
            this.txt_total.Size = new System.Drawing.Size(141, 30);
            this.txt_total.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txt_total, "Net ammount");
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
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_print.Location = new System.Drawing.Point(1045, 363);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(103, 62);
            this.btn_print.TabIndex = 35;
            this.btn_print.Text = "Print invoice";
            this.toolTip1.SetToolTip(this.btn_print, "Print invoice");
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_new
            // 
            this.btn_new.Animated = true;
            this.btn_new.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_new.BorderRadius = 13;
            this.btn_new.BorderThickness = 3;
            this.btn_new.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_new.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_new.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_new.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_new.Location = new System.Drawing.Point(1151, 363);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(103, 62);
            this.btn_new.TabIndex = 36;
            this.btn_new.Text = "New";
            this.toolTip1.SetToolTip(this.btn_new, "New order");
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_show_quantity
            // 
            this.btn_show_quantity.Animated = true;
            this.btn_show_quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_show_quantity.BorderRadius = 13;
            this.btn_show_quantity.BorderThickness = 3;
            this.btn_show_quantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_quantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show_quantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_show_quantity.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_show_quantity.Location = new System.Drawing.Point(1044, 457);
            this.btn_show_quantity.Name = "btn_show_quantity";
            this.btn_show_quantity.Size = new System.Drawing.Size(173, 49);
            this.btn_show_quantity.TabIndex = 39;
            this.btn_show_quantity.Text = "Show quantities";
            this.toolTip1.SetToolTip(this.btn_show_quantity, "Show the quantity of products in the selected category.");
            this.btn_show_quantity.Click += new System.EventHandler(this.btn_show_quantity_Click);
            // 
            // txt_enteredAmount
            // 
            this.txt_enteredAmount.BorderRadius = 14;
            this.txt_enteredAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_enteredAmount.DefaultText = "";
            this.txt_enteredAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_enteredAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_enteredAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_enteredAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_enteredAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_enteredAmount.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enteredAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_enteredAmount.Location = new System.Drawing.Point(1215, 135);
            this.txt_enteredAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_enteredAmount.Name = "txt_enteredAmount";
            this.txt_enteredAmount.PlaceholderText = "";
            this.txt_enteredAmount.SelectedText = "";
            this.txt_enteredAmount.Size = new System.Drawing.Size(141, 30);
            this.txt_enteredAmount.TabIndex = 40;
            this.toolTip1.SetToolTip(this.txt_enteredAmount, "Enter customer amount");
            // 
            // txt_customerName
            // 
            this.txt_customerName.BorderRadius = 14;
            this.txt_customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customerName.DefaultText = "";
            this.txt_customerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customerName.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customerName.Location = new System.Drawing.Point(1215, 174);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PlaceholderText = "";
            this.txt_customerName.SelectedText = "";
            this.txt_customerName.Size = new System.Drawing.Size(141, 30);
            this.txt_customerName.TabIndex = 43;
            this.toolTip1.SetToolTip(this.txt_customerName, "customer name");
            // 
            // btn_archive
            // 
            this.btn_archive.Animated = true;
            this.btn_archive.BorderRadius = 13;
            this.btn_archive.BorderThickness = 3;
            this.btn_archive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_archive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_archive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_archive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_archive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_archive.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.ForeColor = System.Drawing.Color.Black;
            this.btn_archive.Location = new System.Drawing.Point(1260, 363);
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.Size = new System.Drawing.Size(103, 62);
            this.btn_archive.TabIndex = 44;
            this.btn_archive.Text = "Archive";
            this.toolTip1.SetToolTip(this.btn_archive, "Archive bills");
            this.btn_archive.Click += new System.EventHandler(this.btn_archive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(944, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Invoice number :";
            // 
            // dt_invoice
            // 
            this.dt_invoice.Enabled = false;
            this.dt_invoice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_invoice.Location = new System.Drawing.Point(1138, 8);
            this.dt_invoice.Name = "dt_invoice";
            this.dt_invoice.Size = new System.Drawing.Size(225, 21);
            this.dt_invoice.TabIndex = 22;
            this.dt_invoice.ValueChanged += new System.EventHandler(this.dt_invoice_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(1000, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(727, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(191, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Invoices";
            // 
            // cmb_menu
            // 
            this.cmb_menu.BackColor = System.Drawing.Color.Transparent;
            this.cmb_menu.BorderRadius = 15;
            this.cmb_menu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.cmb_menu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_menu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmb_menu.ForeColor = System.Drawing.Color.White;
            this.cmb_menu.ItemHeight = 30;
            this.cmb_menu.Items.AddRange(new object[] {
            "Adminstrative menu",
            "Log out"});
            this.cmb_menu.Location = new System.Drawing.Point(1138, 702);
            this.cmb_menu.Name = "cmb_menu";
            this.cmb_menu.Size = new System.Drawing.Size(225, 36);
            this.cmb_menu.TabIndex = 27;
            this.cmb_menu.Tag = "";
            this.cmb_menu.SelectedIndexChanged += new System.EventHandler(this.cmb_menu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label5.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(1076, 714);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Menu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(1040, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(1040, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Products";
            // 
            // upd_invoice_number
            // 
            this.upd_invoice_number.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upd_invoice_number.InterceptArrowKeys = false;
            this.upd_invoice_number.Location = new System.Drawing.Point(1064, 7);
            this.upd_invoice_number.Name = "upd_invoice_number";
            this.upd_invoice_number.ReadOnly = true;
            this.upd_invoice_number.Size = new System.Drawing.Size(61, 23);
            this.upd_invoice_number.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(1128, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Customer :";
            // 
            // txt_note
            // 
            this.txt_note.BorderRadius = 18;
            this.txt_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.DefaultText = "";
            this.txt_note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_note.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_note.Location = new System.Drawing.Point(1110, 209);
            this.txt_note.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.PlaceholderText = "Notes";
            this.txt_note.SelectedText = "";
            this.txt_note.Size = new System.Drawing.Size(253, 146);
            this.txt_note.TabIndex = 34;
            // 
            // flp_btn_categories
            // 
            this.flp_btn_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.flp_btn_categories.Location = new System.Drawing.Point(13, 653);
            this.flp_btn_categories.Name = "flp_btn_categories";
            this.flp_btn_categories.Size = new System.Drawing.Size(1021, 76);
            this.flp_btn_categories.TabIndex = 37;
            // 
            // flb_btn_products
            // 
            this.flb_btn_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.flb_btn_products.Location = new System.Drawing.Point(12, 374);
            this.flb_btn_products.Name = "flb_btn_products";
            this.flb_btn_products.Size = new System.Drawing.Size(1021, 273);
            this.flb_btn_products.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label9.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label9.Location = new System.Drawing.Point(1105, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Amount paid :";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.lbl_user.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Olive;
            this.lbl_user.Location = new System.Drawing.Point(1125, 605);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 22);
            this.lbl_user.TabIndex = 42;
            // 
            // timer_now
            // 
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // frm_pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1370, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btn_archive);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_enteredAmount);
            this.Controls.Add(this.btn_show_quantity);
            this.Controls.Add(this.flb_btn_products);
            this.Controls.Add(this.flp_btn_categories);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.upd_invoice_number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.dt_invoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.dgv_bills);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_pos";
            this.ShowIcon = false;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_pos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upd_invoice_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_bills;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_order;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_invoice;
        private Guna.UI2.WinForms.Guna2TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown upd_invoice_number;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_note;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private Guna.UI2.WinForms.Guna2Button btn_new;
        private System.Windows.Forms.FlowLayoutPanel flp_btn_categories;
        private System.Windows.Forms.FlowLayoutPanel flb_btn_products;
        private Guna.UI2.WinForms.Guna2Button btn_show_quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_enteredAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_user;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerName;
        private Guna.UI2.WinForms.Guna2Button btn_archive;
        private System.Windows.Forms.Timer timer_now;
    }
}