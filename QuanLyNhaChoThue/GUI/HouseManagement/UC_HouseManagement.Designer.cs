namespace QuanLyNhaChoThue.GUI.HouseManagement
{
    partial class UC_HouseManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HouseManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.lvHouse = new System.Windows.Forms.ListView();
            this.imageListHouse = new System.Windows.Forms.ImageList(this.components);
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhà";
            // 
            // lvHouse
            // 
            this.lvHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvHouse.HideSelection = false;
            this.lvHouse.LargeImageList = this.imageListHouse;
            this.lvHouse.Location = new System.Drawing.Point(17, 64);
            this.lvHouse.Name = "lvHouse";
            this.lvHouse.Size = new System.Drawing.Size(599, 350);
            this.lvHouse.TabIndex = 2;
            this.lvHouse.UseCompatibleStateImageBehavior = false;
            this.lvHouse.DoubleClick += new System.EventHandler(this.lvHouse_DoubleClick);
            // 
            // imageListHouse
            // 
            this.imageListHouse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHouse.ImageStream")));
            this.imageListHouse.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHouse.Images.SetKeyName(0, "house_100px.png");
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.FlatAppearance.BorderSize = 0;
            this.btnAddHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHouse.Image = global::QuanLyNhaChoThue.Properties.Resources.add_25px;
            this.btnAddHouse.Location = new System.Drawing.Point(158, 11);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(25, 25);
            this.btnAddHouse.TabIndex = 3;
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            this.btnAddHouse.MouseHover += new System.EventHandler(this.btnAddHouse_MouseHover);
            // 
            // UC_HouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.lvHouse);
            this.Controls.Add(this.label1);
            this.Name = "UC_HouseManagement";
            this.Size = new System.Drawing.Size(636, 434);
            this.Load += new System.EventHandler(this.UC_HouseManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvHouse;
        private System.Windows.Forms.ImageList imageListHouse;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
