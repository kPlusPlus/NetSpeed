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
            this.SuspendLayout();
            // 
            // btnCheckSpeed
            // 
            this.btnCheckSpeed.Location = new System.Drawing.Point(515, 12);
            this.btnCheckSpeed.Name = "btnCheckSpeed";
            this.btnCheckSpeed.Size = new System.Drawing.Size(112, 27);
            this.btnCheckSpeed.TabIndex = 0;
            this.btnCheckSpeed.Text = "Check speed";
            this.btnCheckSpeed.UseVisualStyleBackColor = true;
            this.btnCheckSpeed.Click += new System.EventHandler(this.btnCheckSpeed_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 369);
            this.Controls.Add(this.btnCheckSpeed);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckSpeed;
    }
}

