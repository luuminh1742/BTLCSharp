namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    partial class FormRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.btnHouseManagement = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinSize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaxSize = new System.Windows.Forms.Button();
            this.uC_Home1 = new QuanLyNhaChoThue.GUI.Home.UC_Home();
            this.uC_ManageAccount1 = new QuanLyNhaChoThue.GUI.AccountSetting.UC_ManageAccount();
            this.uC_RoomManager1 = new QuanLyNhaChoThue.GUI.HouseManagement.Room.UC_RoomManager();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAccountSetting);
            this.panel1.Controls.Add(this.btnHouseManagement);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 511);
            this.panel1.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::QuanLyNhaChoThue.Properties.Resources.help_25px;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(8, 262);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(215, 54);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "  Trợ giúp";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÀ";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 94);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(8, 54);
            this.SidePanel.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(42, 455);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.btnAccountSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccountSetting.FlatAppearance.BorderSize = 0;
            this.btnAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSetting.ForeColor = System.Drawing.Color.White;
            this.btnAccountSetting.Image = global::QuanLyNhaChoThue.Properties.Resources.user_settings_25px;
            this.btnAccountSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSetting.Location = new System.Drawing.Point(8, 206);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Size = new System.Drawing.Size(215, 54);
            this.btnAccountSetting.TabIndex = 2;
            this.btnAccountSetting.Text = "   Quản lý tài khoản";
            this.btnAccountSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountSetting.UseVisualStyleBackColor = false;
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // btnHouseManagement
            // 
            this.btnHouseManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.btnHouseManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHouseManagement.FlatAppearance.BorderSize = 0;
            this.btnHouseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouseManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHouseManagement.ForeColor = System.Drawing.Color.White;
            this.btnHouseManagement.Image = global::QuanLyNhaChoThue.Properties.Resources.business_building_25px;
            this.btnHouseManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHouseManagement.Location = new System.Drawing.Point(8, 150);
            this.btnHouseManagement.Name = "btnHouseManagement";
            this.btnHouseManagement.Size = new System.Drawing.Size(215, 54);
            this.btnHouseManagement.TabIndex = 1;
            this.btnHouseManagement.Text = "   Quản lý nhà";
            this.btnHouseManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHouseManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHouseManagement.UseVisualStyleBackColor = false;
            this.btnHouseManagement.Click += new System.EventHandler(this.btnHouseManagement_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::QuanLyNhaChoThue.Properties.Resources.windows_client_25px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(8, 94);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(215, 54);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "   Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(223, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 5);
            this.panel2.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.btnMinSize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnMaxSize);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(223, 5);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(781, 30);
            this.panelTitle.TabIndex = 3;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinSize
            // 
            this.btnMinSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinSize.FlatAppearance.BorderSize = 0;
            this.btnMinSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinSize.Image = global::QuanLyNhaChoThue.Properties.Resources.subtract_15px;
            this.btnMinSize.Location = new System.Drawing.Point(646, 0);
            this.btnMinSize.Name = "btnMinSize";
            this.btnMinSize.Size = new System.Drawing.Size(45, 30);
            this.btnMinSize.TabIndex = 4;
            this.btnMinSize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QuanLyNhaChoThue.Properties.Resources.delete_15px;
            this.btnClose.Location = new System.Drawing.Point(738, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnMaxSize
            // 
            this.btnMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxSize.FlatAppearance.BorderSize = 0;
            this.btnMaxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxSize.Image = global::QuanLyNhaChoThue.Properties.Resources.maximize_button_15px;
            this.btnMaxSize.Location = new System.Drawing.Point(692, 0);
            this.btnMaxSize.Name = "btnMaxSize";
            this.btnMaxSize.Size = new System.Drawing.Size(45, 30);
            this.btnMaxSize.TabIndex = 3;
            this.btnMaxSize.UseVisualStyleBackColor = true;
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackColor = System.Drawing.Color.White;
            this.uC_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Home1.Location = new System.Drawing.Point(223, 35);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(781, 476);
            this.uC_Home1.TabIndex = 4;
            // 
            // uC_ManageAccount1
            // 
            this.uC_ManageAccount1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_ManageAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ManageAccount1.Location = new System.Drawing.Point(0, 0);
            this.uC_ManageAccount1.Name = "uC_ManageAccount1";
            this.uC_ManageAccount1.Size = new System.Drawing.Size(1004, 511);
            this.uC_ManageAccount1.TabIndex = 5;
            // 
            // uC_RoomManager1
            // 
            this.uC_RoomManager1.BackColor = System.Drawing.Color.White;
            this.uC_RoomManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_RoomManager1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomManager1.Name = "uC_RoomManager1";
            this.uC_RoomManager1.Size = new System.Drawing.Size(1004, 511);
            this.uC_RoomManager1.TabIndex = 6;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.uC_Home1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_RoomManager1);
            this.Controls.Add(this.uC_ManageAccount1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccountSetting;
        private System.Windows.Forms.Button btnHouseManagement;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnMinSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxSize;
        private Home.UC_Home uC_Home1;
        private AccountSetting.UC_ManageAccount uC_ManageAccount1;
        private UC_RoomManager uC_RoomManager1;
    }
}