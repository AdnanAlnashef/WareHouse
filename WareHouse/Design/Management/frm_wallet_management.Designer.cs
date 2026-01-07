namespace WareHouse.Design.Management
{
    partial class frm_wallet_management
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_balance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_withdraw = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(508, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Wallet Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.BorderRadius = 18;
            this.txt_balance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_balance.DefaultText = "";
            this.txt_balance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_balance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_balance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_balance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_balance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_balance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_balance.Location = new System.Drawing.Point(178, 77);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.PlaceholderText = "";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.SelectedText = "";
            this.txt_balance.Size = new System.Drawing.Size(252, 36);
            this.txt_balance.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "The Balance is :";
            // 
            // txt_amount
            // 
            this.txt_amount.BorderRadius = 18;
            this.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_amount.DefaultText = "";
            this.txt_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_amount.Location = new System.Drawing.Point(187, 269);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PlaceholderText = "";
            this.txt_amount.SelectedText = "";
            this.txt_amount.Size = new System.Drawing.Size(269, 36);
            this.txt_amount.TabIndex = 36;
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_add.BorderRadius = 13;
            this.btn_add.BorderThickness = 3;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_add.Location = new System.Drawing.Point(52, 400);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 62);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Add amount";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Animated = true;
            this.btn_withdraw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_withdraw.BorderRadius = 13;
            this.btn_withdraw.BorderThickness = 3;
            this.btn_withdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_withdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_withdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_withdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_withdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_withdraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_withdraw.Location = new System.Drawing.Point(187, 400);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(103, 62);
            this.btn_withdraw.TabIndex = 38;
            this.btn_withdraw.Text = "Rival amount";
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(8, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Enter a amount :";
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
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(1075, 468);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(165, 52);
            this.btn_exit.TabIndex = 40;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Animated = true;
            this.btn_reset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_reset.BorderRadius = 13;
            this.btn_reset.BorderThickness = 3;
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btn_reset.Location = new System.Drawing.Point(327, 400);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 62);
            this.btn_reset.TabIndex = 41;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_wallet_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1252, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_wallet_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallet Management";
            this.Load += new System.EventHandler(this.frm_wallet_management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_balance;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_amount;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_withdraw;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
    }
}