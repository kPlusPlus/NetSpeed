namespace NetSpeed
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
            this.SuspendLayout();
            // 
            // btnCheckSpeed
            // 
            this.btnCheckSpeed.Location = new System.Drawing.Point(12, 12);
            this.btnCheckSpeed.Name = "btnCheckSpeed";
            this.btnCheckSpeed.Size = new System.Drawing.Size(112, 27);
            this.btnCheckSpeed.TabIndex = 0;
            this.btnCheckSpeed.Text = "Check speed";
            this.btnCheckSpeed.UseVisualStyleBackColor = true;
            this.btnCheckSpeed.Click += new System.EventHandler(this.btnCheckSpeed_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 454);
            this.panel1.TabIndex = 1;
            // 
            // txtURLmain
            // 
            this.txtURLmain.Location = new System.Drawing.Point(157, 12);
            this.txtURLmain.Name = "txtURLmain";
            this.txtURLmain.Size = new System.Drawing.Size(274, 20);
            this.txtURLmain.TabIndex = 2;
            this.txtURLmain.Text = "http://google.com";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 512);
            this.Controls.Add(this.txtURLmain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckSpeed);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckSpeed;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtURLmain;
    }
}

