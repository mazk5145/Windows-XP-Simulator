﻿
namespace Windows_XP_Simulator
{
    partial class osdown
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.loadingform = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.apptext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingform)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // loadingform
            // 
            this.loadingform.FillColor = System.Drawing.Color.Black;
            this.loadingform.ImageRotate = 0F;
            this.loadingform.Location = new System.Drawing.Point(-9, 30);
            this.loadingform.Name = "loadingform";
            this.loadingform.ShadowDecoration.Parent = this.loadingform;
            this.loadingform.Size = new System.Drawing.Size(952, 550);
            this.loadingform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingform.TabIndex = 1;
            this.loadingform.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Red;
            this.guna2Panel1.Controls.Add(this.apptext);
            this.guna2Panel1.Location = new System.Drawing.Point(-9, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(952, 36);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // apptext
            // 
            this.apptext.AutoSize = true;
            this.apptext.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptext.Location = new System.Drawing.Point(439, 10);
            this.apptext.Name = "apptext";
            this.apptext.Size = new System.Drawing.Size(71, 17);
            this.apptext.TabIndex = 0;
            this.apptext.Text = "APPTITLE";
            // 
            // osdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 576);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.loadingform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "osdown";
            this.Text = "osdown";
            this.Load += new System.EventHandler(this.osdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingform)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox loadingform;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label apptext;
    }
}