namespace DisturboTax
{
    partial class Form2
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
            this.lbAdjGross = new System.Windows.Forms.Label();
            this.lbTaxAmt = new System.Windows.Forms.Label();
            this.lbW2TaxWithheld = new System.Windows.Forms.Label();
            this.lbPenalty = new System.Windows.Forms.Label();
            this.lbTaxOwed = new System.Windows.Forms.Label();
            this.lbRefund = new System.Windows.Forms.Label();
            this.txtAdjGross = new System.Windows.Forms.TextBox();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.txtW2TaxWithheld = new System.Windows.Forms.TextBox();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.txtRefund = new System.Windows.Forms.TextBox();
            this.btContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAdjGross
            // 
            this.lbAdjGross.AutoSize = true;
            this.lbAdjGross.Location = new System.Drawing.Point(180, 69);
            this.lbAdjGross.Name = "lbAdjGross";
            this.lbAdjGross.Size = new System.Drawing.Size(105, 17);
            this.lbAdjGross.TabIndex = 0;
            this.lbAdjGross.Text = "Adjusted Gross";
            // 
            // lbTaxAmt
            // 
            this.lbTaxAmt.AutoSize = true;
            this.lbTaxAmt.Location = new System.Drawing.Point(106, 107);
            this.lbTaxAmt.Name = "lbTaxAmt";
            this.lbTaxAmt.Size = new System.Drawing.Size(179, 17);
            this.lbTaxAmt.TabIndex = 1;
            this.lbTaxAmt.Text = "Amount of Tax (Calculated)";
            // 
            // lbW2TaxWithheld
            // 
            this.lbW2TaxWithheld.AutoSize = true;
            this.lbW2TaxWithheld.Location = new System.Drawing.Point(70, 147);
            this.lbW2TaxWithheld.Name = "lbW2TaxWithheld";
            this.lbW2TaxWithheld.Size = new System.Drawing.Size(215, 17);
            this.lbW2TaxWithheld.TabIndex = 2;
            this.lbW2TaxWithheld.Text = "Amount of Tax Withheld from W2";
            // 
            // lbPenalty
            // 
            this.lbPenalty.AutoSize = true;
            this.lbPenalty.Location = new System.Drawing.Point(230, 184);
            this.lbPenalty.Name = "lbPenalty";
            this.lbPenalty.Size = new System.Drawing.Size(55, 17);
            this.lbPenalty.TabIndex = 3;
            this.lbPenalty.Text = "Penalty";
            // 
            // lbTaxOwed
            // 
            this.lbTaxOwed.AutoSize = true;
            this.lbTaxOwed.Location = new System.Drawing.Point(40, 227);
            this.lbTaxOwed.Name = "lbTaxOwed";
            this.lbTaxOwed.Size = new System.Drawing.Size(245, 17);
            this.lbTaxOwed.TabIndex = 4;
            this.lbTaxOwed.Text = "Tax Owed to the Federal Government";
            // 
            // lbRefund
            // 
            this.lbRefund.AutoSize = true;
            this.lbRefund.Location = new System.Drawing.Point(98, 273);
            this.lbRefund.Name = "lbRefund";
            this.lbRefund.Size = new System.Drawing.Size(187, 17);
            this.lbRefund.TabIndex = 5;
            this.lbRefund.Text = "Refund Due to the Taxpayer";
            // 
            // txtAdjGross
            // 
            this.txtAdjGross.Location = new System.Drawing.Point(304, 63);
            this.txtAdjGross.Name = "txtAdjGross";
            this.txtAdjGross.Size = new System.Drawing.Size(151, 22);
            this.txtAdjGross.TabIndex = 6;
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Location = new System.Drawing.Point(304, 104);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.Size = new System.Drawing.Size(151, 22);
            this.txtTaxAmt.TabIndex = 7;
            // 
            // txtW2TaxWithheld
            // 
            this.txtW2TaxWithheld.Location = new System.Drawing.Point(304, 147);
            this.txtW2TaxWithheld.Name = "txtW2TaxWithheld";
            this.txtW2TaxWithheld.Size = new System.Drawing.Size(151, 22);
            this.txtW2TaxWithheld.TabIndex = 8;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(304, 184);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(151, 22);
            this.txtPenalty.TabIndex = 9;
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Location = new System.Drawing.Point(304, 224);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.Size = new System.Drawing.Size(151, 22);
            this.txtTaxOwed.TabIndex = 10;
            // 
            // txtRefund
            // 
            this.txtRefund.Location = new System.Drawing.Point(304, 268);
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.Size = new System.Drawing.Size(151, 22);
            this.txtRefund.TabIndex = 11;
            this.txtRefund.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btContinue
            // 
            this.btContinue.Location = new System.Drawing.Point(432, 388);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(92, 23);
            this.btContinue.TabIndex = 12;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = true;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btContinue);
            this.Controls.Add(this.txtRefund);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.txtW2TaxWithheld);
            this.Controls.Add(this.txtTaxAmt);
            this.Controls.Add(this.txtAdjGross);
            this.Controls.Add(this.lbRefund);
            this.Controls.Add(this.lbTaxOwed);
            this.Controls.Add(this.lbPenalty);
            this.Controls.Add(this.lbW2TaxWithheld);
            this.Controls.Add(this.lbTaxAmt);
            this.Controls.Add(this.lbAdjGross);
            this.Name = "Form2";
            this.Text = "Disturbo Tax 1.0 - Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdjGross;
        private System.Windows.Forms.Label lbTaxAmt;
        private System.Windows.Forms.Label lbW2TaxWithheld;
        private System.Windows.Forms.Label lbPenalty;
        private System.Windows.Forms.Label lbTaxOwed;
        private System.Windows.Forms.Label lbRefund;
        private System.Windows.Forms.TextBox txtAdjGross;
        private System.Windows.Forms.TextBox txtTaxAmt;
        private System.Windows.Forms.TextBox txtW2TaxWithheld;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.TextBox txtRefund;
        private System.Windows.Forms.Button btContinue;
    }
}