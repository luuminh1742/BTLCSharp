namespace QuanLyNhaChoThue.GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.btnHouseManagement = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.imageMenu = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uC_Home1 = new QuanLyNhaChoThue.GUI.Home.UC_Home();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAccountSetting);
            this.panel1.Controls.Add(this.btnHouseManagement);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 444);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lưu Bá Minh";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.uC_Home1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 444);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhaChoThue.Properties.Resources.icon_user_home;
            this.pictureBox1.Location = new System.Drawing.Point(42, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.btnLogout.Image = global::QuanLyNhaChoThue.Properties.Resources.sign_out_32px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(42, 388);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccountSetting.FlatAppearance.BorderSize = 0;
            this.btnAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountSetting.Image")));
            this.btnAccountSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSetting.Location = new System.Drawing.Point(0, 179);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Size = new System.Drawing.Size(194, 34);
            this.btnAccountSetting.TabIndex = 2;
            this.btnAccountSetting.Text = "Quản lý tài khoản";
            this.btnAccountSetting.UseVisualStyleBackColor = false;
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // btnHouseManagement
            // 
            this.btnHouseManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHouseManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHouseManagement.FlatAppearance.BorderSize = 0;
            this.btnHouseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHouseManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHouseManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnHouseManagement.Image")));
            this.btnHouseManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHouseManagement.Location = new System.Drawing.Point(0, 146);
            this.btnHouseManagement.Name = "btnHouseManagement";
            this.btnHouseManagement.Size = new System.Drawing.Size(194, 34);
            this.btnHouseManagement.TabIndex = 1;
            this.btnHouseManagement.Text = "Quản lý nhà";
            this.btnHouseManagement.UseVisualStyleBackColor = false;
            this.btnHouseManagement.Click += new System.EventHandler(this.btnHouseManagement_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = global::QuanLyNhaChoThue.Properties.Resources.icon_trang_chu_32px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 113);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // imageMenu
            // 
            this.imageMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageMenu.ImageStream")));
            this.imageMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageMenu.Images.SetKeyName(0, "icon_trang_chu_32px.png");
            this.imageMenu.Images.SetKeyName(1, "icon_trang-chu_checked_32px.png");
            this.imageMenu.Images.SetKeyName(2, "house_32px.png");
            this.imageMenu.Images.SetKeyName(3, "house_checked_32px.png");
            this.imageMenu.Images.SetKeyName(4, "user_settings_32px.png");
            this.imageMenu.Images.SetKeyName(5, "user_settings_checked_32px.png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackColor = System.Drawing.Color.White;
            this.uC_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(594, 444);
            this.uC_Home1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cho thuê";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccountSetting;
        private System.Windows.Forms.Button btnHouseManagement;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Home.UC_Home uC_Home1;
        private System.Windows.Forms.ImageList imageMenu;
        private System.Windows.Forms.ImageList imageList1;
    }
}