namespace DisturboTax
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmtOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmtRefunded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSSN,
            this.colLName,
            this.colFName,
            this.colAmtOwed,
            this.colAmtRefunded});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colSSN
            // 
            this.colSSN.HeaderText = "SSN";
            this.colSSN.Name = "colSSN";
            // 
            // colLName
            // 
            this.colLName.HeaderText = "Last Name";
            this.colLName.Name = "colLName";
            // 
            // colFName
            // 
            this.colFName.HeaderText = "First Name";
            this.colFName.Name = "colFName";
            // 
            // colAmtOwed
            // 
            this.colAmtOwed.HeaderText = "Amount Owed";
            this.colAmtOwed.Name = "colAmtOwed";
            // 
            // colAmtRefunded
            // 
            this.colAmtRefunded.HeaderText = "Amount Refunded";
            this.colAmtRefunded.Name = "colAmtRefunded";
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(674, 404);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(75, 23);
            this.btQuit.TabIndex = 1;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 439);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Disturbo Tax 1.0 - Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmtOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmtRefunded;
        private System.Windows.Forms.Button btQuit;
    }
}