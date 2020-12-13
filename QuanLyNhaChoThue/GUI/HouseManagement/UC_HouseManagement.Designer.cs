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
            this.pctAddHouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddHouse)).BeginInit();
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
            this.lvHouse.Location = new System.Drawing.Point(17, 55);
            this.lvHouse.Name = "lvHouse";
            this.lvHouse.Size = new System.Drawing.Size(599, 350);
            this.lvHouse.TabIndex = 3;
            this.lvHouse.UseCompatibleStateImageBehavior = false;
            this.lvHouse.SelectedIndexChanged += new System.EventHandler(this.lvHouse_SelectedIndexChanged);
            this.lvHouse.DoubleClick += new System.EventHandler(this.lvHouse_DoubleClick);
            // 
            // imageListHouse
            // 
            this.imageListHouse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHouse.ImageStream")));
            this.imageListHouse.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHouse.Images.SetKeyName(0, "house_100px.png");
            // 
            // pctAddHouse
            // 
            this.pctAddHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctAddHouse.Image = global::QuanLyNhaChoThue.Properties.Resources.add_house_50px;
            this.pctAddHouse.Location = new System.Drawing.Point(566, 11);
            this.pctAddHouse.Name = "pctAddHouse";
            this.pctAddHouse.Size = new System.Drawing.Size(50, 35);
            this.pctAddHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAddHouse.TabIndex = 2;
            this.pctAddHouse.TabStop = false;
            this.pctAddHouse.Click += new System.EventHandler(this.pctAddHouse_Click);
            // 
            // UC_HouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lvHouse);
            this.Controls.Add(this.pctAddHouse);
            this.Controls.Add(this.label1);
            this.Name = "UC_HouseManagement";
            this.Size = new System.Drawing.Size(636, 434);
            this.Load += new System.EventHandler(this.UC_HouseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAddHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctAddHouse;
        private System.Windows.Forms.ListView lvHouse;
        private System.Windows.Forms.ImageList imageListHouse;
    }
}
