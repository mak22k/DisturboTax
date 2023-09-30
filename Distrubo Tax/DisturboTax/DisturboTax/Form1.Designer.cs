namespace DisturboTax
{
    partial class Form1
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbZip = new System.Windows.Forms.Label();
            this.lbSSN = new System.Windows.Forms.Label();
            this.lbExemptions = new System.Windows.Forms.Label();
            this.lbGross = new System.Windows.Forms.Label();
            this.lbTaxWithheld = new System.Windows.Forms.Label();
            this.lbCapital = new System.Windows.Forms.Label();
            this.lbRealEstate = new System.Windows.Forms.Label();
            this.lbExcise = new System.Windows.Forms.Label();
            this.lbMedical = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtExemptions = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtWithheld = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtRealEstate = new System.Windows.Forms.TextBox();
            this.txtExcise = new System.Windows.Forms.TextBox();
            this.txtMedical = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(59, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(108, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Taxpayer Name";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(107, 73);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 17);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Address";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(136, 120);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(31, 17);
            this.lbCity.TabIndex = 2;
            this.lbCity.Text = "City";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(126, 167);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(41, 17);
            this.lbState.TabIndex = 3;
            this.lbState.Text = "State";
            // 
            // lbZip
            // 
            this.lbZip.AutoSize = true;
            this.lbZip.Location = new System.Drawing.Point(139, 204);
            this.lbZip.Name = "lbZip";
            this.lbZip.Size = new System.Drawing.Size(28, 17);
            this.lbZip.TabIndex = 4;
            this.lbZip.Text = "Zip";
            // 
            // lbSSN
            // 
            this.lbSSN.AutoSize = true;
            this.lbSSN.Location = new System.Drawing.Point(12, 246);
            this.lbSSN.Name = "lbSSN";
            this.lbSSN.Size = new System.Drawing.Size(155, 17);
            this.lbSSN.TabIndex = 5;
            this.lbSSN.Text = "Social Security Number";
            // 
            // lbExemptions
            // 
            this.lbExemptions.AutoSize = true;
            this.lbExemptions.Location = new System.Drawing.Point(17, 291);
            this.lbExemptions.Name = "lbExemptions";
            this.lbExemptions.Size = new System.Drawing.Size(150, 17);
            this.lbExemptions.TabIndex = 6;
            this.lbExemptions.Text = "Number of Exemptions";
            // 
            // lbGross
            // 
            this.lbGross.AutoSize = true;
            this.lbGross.Location = new System.Drawing.Point(488, 28);
            this.lbGross.Name = "lbGross";
            this.lbGross.Size = new System.Drawing.Size(106, 17);
            this.lbGross.TabIndex = 7;
            this.lbGross.Text = "Gross Earnings";
            // 
            // lbTaxWithheld
            // 
            this.lbTaxWithheld.AutoSize = true;
            this.lbTaxWithheld.Location = new System.Drawing.Point(453, 73);
            this.lbTaxWithheld.Name = "lbTaxWithheld";
            this.lbTaxWithheld.Size = new System.Drawing.Size(142, 17);
            this.lbTaxWithheld.TabIndex = 8;
            this.lbTaxWithheld.Text = "Federal Tax Withheld";
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Location = new System.Drawing.Point(454, 120);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(141, 17);
            this.lbCapital.TabIndex = 9;
            this.lbCapital.Text = "Capital Gains/Losses";
            // 
            // lbRealEstate
            // 
            this.lbRealEstate.AutoSize = true;
            this.lbRealEstate.Location = new System.Drawing.Point(486, 164);
            this.lbRealEstate.Name = "lbRealEstate";
            this.lbRealEstate.Size = new System.Drawing.Size(108, 17);
            this.lbRealEstate.TabIndex = 10;
            this.lbRealEstate.Text = "Real Estate Tax";
            // 
            // lbExcise
            // 
            this.lbExcise.AutoSize = true;
            this.lbExcise.Location = new System.Drawing.Point(519, 204);
            this.lbExcise.Name = "lbExcise";
            this.lbExcise.Size = new System.Drawing.Size(75, 17);
            this.lbExcise.TabIndex = 11;
            this.lbExcise.Text = "Excise Tax";
            // 
            // lbMedical
            // 
            this.lbMedical.AutoSize = true;
            this.lbMedical.Location = new System.Drawing.Point(474, 246);
            this.lbMedical.Name = "lbMedical";
            this.lbMedical.Size = new System.Drawing.Size(121, 17);
            this.lbMedical.TabIndex = 12;
            this.lbMedical.Text = "Medical Expenses";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 22);
            this.txtName.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(206, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 22);
            this.txtAddress.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(206, 120);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(227, 22);
            this.txtCity.TabIndex = 15;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(206, 204);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(227, 22);
            this.txtZip.TabIndex = 17;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(206, 246);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(227, 22);
            this.txtSSN.TabIndex = 18;
            // 
            // txtExemptions
            // 
            this.txtExemptions.Location = new System.Drawing.Point(206, 291);
            this.txtExemptions.Name = "txtExemptions";
            this.txtExemptions.Size = new System.Drawing.Size(227, 22);
            this.txtExemptions.TabIndex = 19;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(616, 29);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(227, 22);
            this.txtGross.TabIndex = 20;
            // 
            // txtWithheld
            // 
            this.txtWithheld.Location = new System.Drawing.Point(616, 68);
            this.txtWithheld.Name = "txtWithheld";
            this.txtWithheld.Size = new System.Drawing.Size(227, 22);
            this.txtWithheld.TabIndex = 21;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(616, 120);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(227, 22);
            this.txtCapital.TabIndex = 22;
            // 
            // txtRealEstate
            // 
            this.txtRealEstate.Location = new System.Drawing.Point(616, 164);
            this.txtRealEstate.Name = "txtRealEstate";
            this.txtRealEstate.Size = new System.Drawing.Size(227, 22);
            this.txtRealEstate.TabIndex = 23;
            // 
            // txtExcise
            // 
            this.txtExcise.Location = new System.Drawing.Point(616, 204);
            this.txtExcise.Name = "txtExcise";
            this.txtExcise.Size = new System.Drawing.Size(227, 22);
            this.txtExcise.TabIndex = 24;
            // 
            // txtMedical
            // 
            this.txtMedical.Location = new System.Drawing.Point(616, 246);
            this.txtMedical.Name = "txtMedical";
            this.txtMedical.Size = new System.Drawing.Size(227, 22);
            this.txtMedical.TabIndex = 25;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "DC",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.cbState.Location = new System.Drawing.Point(206, 167);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(227, 24);
            this.cbState.TabIndex = 16;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(616, 340);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 26;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(765, 340);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 27;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 397);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.txtMedical);
            this.Controls.Add(this.txtExcise);
            this.Controls.Add(this.txtRealEstate);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtWithheld);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.txtExemptions);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbMedical);
            this.Controls.Add(this.lbExcise);
            this.Controls.Add(this.lbRealEstate);
            this.Controls.Add(this.lbCapital);
            this.Controls.Add(this.lbTaxWithheld);
            this.Controls.Add(this.lbGross);
            this.Controls.Add(this.lbExemptions);
            this.Controls.Add(this.lbSSN);
            this.Controls.Add(this.lbZip);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Disturbo Tax 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbZip;
        private System.Windows.Forms.Label lbSSN;
        private System.Windows.Forms.Label lbExemptions;
        private System.Windows.Forms.Label lbGross;
        private System.Windows.Forms.Label lbTaxWithheld;
        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.Label lbRealEstate;
        private System.Windows.Forms.Label lbExcise;
        private System.Windows.Forms.Label lbMedical;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        ///////////////////////////// Changed a bunch of Textboxes to public
        public System.Windows.Forms.TextBox txtSSN;
        public System.Windows.Forms.TextBox txtExemptions;
        public System.Windows.Forms.TextBox txtGross;
        public System.Windows.Forms.TextBox txtWithheld;
        public System.Windows.Forms.TextBox txtCapital;
        public System.Windows.Forms.TextBox txtRealEstate;
        public System.Windows.Forms.TextBox txtExcise;
        public System.Windows.Forms.TextBox txtMedical;
        ///////////////////////////// Changed a bunch of Textboxes to public
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btClear;
    }
}

