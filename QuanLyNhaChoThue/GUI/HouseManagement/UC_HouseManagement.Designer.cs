﻿namespace QuanLyNhaChoThue.GUI.HouseManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.pctAddHouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhà";
            // 
            // pctAddHouse
            // 
            this.pctAddHouse.Image = global::QuanLyNhaChoThue.Properties.Resources.add_house_50px;
            this.pctAddHouse.Location = new System.Drawing.Point(16, 50);
            this.pctAddHouse.Name = "pctAddHouse";
            this.pctAddHouse.Size = new System.Drawing.Size(50, 50);
            this.pctAddHouse.TabIndex = 2;
            this.pctAddHouse.TabStop = false;
            this.pctAddHouse.Click += new System.EventHandler(this.pctAddHouse_Click);
            // 
            // UC_HouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pctAddHouse);
            this.Controls.Add(this.label1);
            this.Name = "UC_HouseManagement";
            this.Size = new System.Drawing.Size(636, 434);
            ((System.ComponentModel.ISupportInitialize)(this.pctAddHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctAddHouse;
    }
}
