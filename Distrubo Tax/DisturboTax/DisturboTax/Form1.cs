// by Marisha Kulseng
// last modified 2/21/2020

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    public partial class Form1 : Form
    {
        string[] states = { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
            "Connecticut", "DC", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana",
            "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan",
            "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
            "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma",
            "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee",
            "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" }; //new string[51];


        ArrayList textBoxes = new ArrayList();
        //public ArrayList Taxpayers = new ArrayList();
        Form2 form2;// = new Form2();
        public static TaxpayerInfo taxpayer;// = new TaxpayerInfo();


        public Form1()
        {
            InitializeComponent();
            textBoxes.Add(txtName);
            textBoxes.Add(txtAddress);
            textBoxes.Add(txtCity);
            textBoxes.Add(txtZip);
            textBoxes.Add(txtSSN);
            textBoxes.Add(txtExemptions);
            textBoxes.Add(txtGross);
            textBoxes.Add(txtWithheld);
            textBoxes.Add(txtCapital);
            textBoxes.Add(txtRealEstate);
            textBoxes.Add(txtExcise);
            textBoxes.Add(txtMedical);           

        }

               


        private bool IsValidData()
        {
            TextBox[] numericFields = { txtExemptions, txtGross, txtWithheld, txtCapital, txtRealEstate,
                txtExcise, txtMedical};


            if (IsMissingData())
            {
                //message box: "Data is missing! Please ensure ALL fields have a response!"
                MessageBox.Show("Data is missing! Please ensure ALL fields have a response!");
                return false;
            }

            if (!AllNumsValid(numericFields))
            {
                string errorLocation = NumericTextBoxLabelToString(ContainsInvalidNum(numericFields));
                ; // message box: "Data is incorrect! " + errorLocation + " must have a NUMERIC value!"
                MessageBox.Show("Data is incorrect! " + errorLocation + " must have a NUMERIC value!");
                return false;
            }
            if (!isNumericString(txtSSN.Text) || !isNumericString(txtZip.Text))
            {
                string errorLocation;
                if (!isNumericString(txtZip.Text))
                    errorLocation = "Zip";
                else
                    errorLocation = "Social Security Number";

                // message box: "Data is incorrect! " + errorLocation + " must not have letters!"
                MessageBox.Show("Data is incorrect! " + errorLocation + " must be a string of numbers!");
                return false;
            }

            if (!isCorrectNumDigits(txtSSN.Text, 9) || !isCorrectNumDigits(txtZip.Text, 5))
            {
                string errorLocation;
                int reqDigits;
                if (!isCorrectNumDigits(txtZip.Text, 5))
                {
                    errorLocation = "Zip";
                    reqDigits = 5;
                }
                else
                {
                    errorLocation = "Social Security Number";
                    reqDigits = 9;
                }
                MessageBox.Show("Data is incorrect! " + errorLocation + " must have " + reqDigits + " digits!");
                return false;
            }

            return true;
        }

        private bool isCorrectNumDigits(string str, int reqNum)
        {
            return (str.Length == reqNum);
        }

        private bool isNumericString(string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        }

        private string NumericTextBoxLabelToString(TextBox t)
        {
            if (t == txtExemptions)
                return "Number of Exemptions";
            else if (t == txtGross)
                return "Gross Earnings";
            else if (t == txtWithheld)
                return "Federal Tax Withheld";
            else if (t == txtCapital)
                return "Capital Gains/Losses";
            else if (t == txtRealEstate)
                return "Real Estate Tax";
            else if (t == txtExcise)
                return "Excise Tax";
            else
                return "Medical Expenses";
        }


        private TextBox ContainsInvalidNum(TextBox[] fields)
        {
            foreach (TextBox t in fields)
            {
                if (!IsValidNumber(t.Text))
                    return t;
            }
            return null;
        }


        private bool AllNumsValid(TextBox [] fields)
        {
            foreach(TextBox t in fields)
            {
                if (!IsValidNumber(t.Text))
                    return false;
            }
            return true;
        }


        private bool IsValidNumber(string str)
        {
            try
            {
                Convert.ToDecimal(str);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }


        private bool IsMissingData()
        {
            foreach (TextBox txtBx in textBoxes)
            {
                if (IsEmptyField(txtBx))
                    return true;
            }
            if (cbState.SelectedIndex == -1)
                return true;

            return false;
        }

        private bool IsEmptyField(TextBox t)
        {
            return t.Text == "" ;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in textBoxes)
            {
                t.Text = "";
            }
            cbState.SelectedIndex = -1;
            this.txtName.Focus();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            
            if (IsValidData())
            {

                taxpayer = new TaxpayerInfo(txtName.Text, txtAddress.Text, txtCity.Text, cbState.Text, txtZip.Text,
                    txtSSN.Text, txtExemptions.Text, txtGross.Text, txtWithheld.Text, txtCapital.Text,
                    txtRealEstate.Text, txtExcise.Text, txtMedical.Text); 


                form2 = new Form2();
                this.Hide();
                //btClear_Click(sender, e); // save this for later
                form2.Show();
                form2.Focus();
            }
        }


       

    }
}
