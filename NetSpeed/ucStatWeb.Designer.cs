namespace NetSpeed
{
    partial class ucStatWeb
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSpeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSpeed = new NetSpeed.dsSpeed();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(84, 8);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(200, 20);
            this.txtURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Web Address:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ucDataGridViewTextBoxColumn,
            this.webDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dsSpeedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 360);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // ucDataGridViewTextBoxColumn
            // 
            this.ucDataGridViewTextBoxColumn.DataPropertyName = "uc";
            this.ucDataGridViewTextBoxColumn.HeaderText = "uc";
            this.ucDataGridViewTextBoxColumn.Name = "ucDataGridViewTextBoxColumn";
            // 
            // webDataGridViewTextBoxColumn
            // 
            this.webDataGridViewTextBoxColumn.DataPropertyName = "web";
            this.webDataGridViewTextBoxColumn.HeaderText = "web";
            this.webDataGridViewTextBoxColumn.Name = "webDataGridViewTextBoxColumn";
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // dsSpeedBindingSource
            // 
            this.dsSpeedBindingSource.AllowNew = false;
            this.dsSpeedBindingSource.DataMember = "InternetSpeed";
            this.dsSpeedBindingSource.DataSource = this.dsSpeed;
            // 
            // dsSpeed
            // 
            this.dsSpeed.DataSetName = "dsSpeed";
            this.dsSpeed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(290, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check speed";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(386, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 29);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(261, 38);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(119, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // ucStatWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Name = "ucStatWeb";
            this.Size = new System.Drawing.Size(497, 436);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCheck;
        public System.Windows.Forms.BindingSource dsSpeedBindingSource;
        public dsSpeed dsSpeed;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}
