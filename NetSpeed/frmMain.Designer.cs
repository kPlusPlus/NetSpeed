﻿namespace NetSpeed
{
    partial class frmMain
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
            this.btnCheckSpeed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtURLmain = new System.Windows.Forms.TextBox();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckSpeed
            // 
            this.btnCheckSpeed.Location = new System.Drawing.Point(3, 3);
            this.btnCheckSpeed.Name = "btnCheckSpeed";
            this.btnCheckSpeed.Size = new System.Drawing.Size(112, 27);
            this.btnCheckSpeed.TabIndex = 0;
            this.btnCheckSpeed.Text = "Check speed";
            this.btnCheckSpeed.UseVisualStyleBackColor = true;
            this.btnCheckSpeed.Click += new System.EventHandler(this.btnCheckSpeed_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 483);
            this.panel1.TabIndex = 1;
            // 
            // txtURLmain
            // 
            this.txtURLmain.Location = new System.Drawing.Point(121, 4);
            this.txtURLmain.Name = "txtURLmain";
            this.txtURLmain.Size = new System.Drawing.Size(274, 20);
            this.txtURLmain.TabIndex = 2;
            this.txtURLmain.Text = "http://google.com";
            // 
            // panelUp
            // 
            this.panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUp.BackgroundImage = global::NetSpeed.Properties.Resources.pozadina_traka;
            this.panelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUp.Controls.Add(this.txtURLmain);
            this.panelUp.Controls.Add(this.btnCheckSpeed);
            this.panelUp.Location = new System.Drawing.Point(12, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(850, 27);
            this.panelUp.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(862, 512);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "kSpeed";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckSpeed;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtURLmain;
        private System.Windows.Forms.Panel panelUp;
    }
}

