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
    public partial class Form2 : Form
    {
        Form1 form1;
        Form3 form3;
        public static ArrayList Taxpayers = new ArrayList();

        public Form2()
        {
            InitializeComponent();

            Taxpayers.Add(Form1.taxpayer);
            //fillTestingData(); // toggle on/off for testing purposes 


            int lastElement = Taxpayers.Count - 1;
            //TaxpayerInfo toDisplay = (TaxpayerInfo)Form1.Taxpayers[lastElement];
            TaxpayerInfo toDisplay = (TaxpayerInfo)Form1.taxpayer;
            txtAdjGross.Text = String.Format("{0:C0}", toDisplay.getAdjGross());// (toDisplay.getAdjGross()).ToString();
            txtTaxAmt.Text = String.Format("{0:C0}", (toDisplay.getTaxToPay()) > 0m ? toDisplay.getTaxToPay() : 0m);//toDisplay.getTaxToPay()); 
                
            txtW2TaxWithheld.Text = String.Format("{0:C0}", toDisplay.getTaxWithheld());
                
            txtPenalty.Text = String.Format("{0:C0}", toDisplay.getPenalty()); 
               
            txtTaxOwed.Text = String.Format("{0:C0}", toDisplay.getTaxOwed());
             
            txtRefund.Text = String.Format("{0:C0}", toDisplay.getRefundOwed());
            

            //fillTestingData();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form2_Load(object sender, EventArgs e) { }

        private void btContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtAdjGross.Text = "";
            txtTaxAmt.Text = "";
            txtW2TaxWithheld.Text = "";
            txtPenalty.Text = "";
            txtTaxOwed.Text = "";
            txtRefund.Text = "";
            if (Taxpayers.Count >= 10)
            {
                form3 = new Form3();
                form3.Show();
            }
            else
            {
                form1 = new Form1();
                form1.Show();
            }
                
            this.Hide();

        }


        private void fillTestingData() // toggle on/off for testing purposes
        {
            Taxpayers.Add(new TaxpayerInfo("Steve Jobs", "1 Apple Headquarters", "San Francisco", "California", "90210",
                "384984760", "0", "1000000000", "500000000", "-2000",
                "1000000", "0", "1000000"));

            Taxpayers.Add(new TaxpayerInfo("John Smith", "87 Blacksmith Way", "Pittsburgh", "Pennsylvania", "33333",
                "368503432", "1", "80000", "5000", "10000",
                "60000", "0", "90000"));

            Taxpayers.Add(new TaxpayerInfo("Beth Doe", "55 Deer Drive", "Lansing", "Wyoming", "34343",
                "343343343", "2", "30000", "30", "43434",
                "0", "0", "900000"));

            Taxpayers.Add(new TaxpayerInfo("Eleanor Shellstrop", "77 Whiskey Avenue", "Tempe", "Arizona", "22222",
                "987456654", "8", "55000", "0", "70000",
                "6000", "0", "0"));

            Taxpayers.Add(new TaxpayerInfo("Chelsea Baker", "28 Baguette Lane", "Paris", "Vermont", "99990",
                "288228882", "1", "90000", "30000", "28800",
                "4000", "1200", "8000"));

            Taxpayers.Add(new TaxpayerInfo("Mortimer Goth", "73 Spooky Street", "Pleasantville", "Maryland", "01030",
                "103091030", "0", "35000", "20000", "-50",
                "20000", "30000", "50"));

            Taxpayers.Add(new TaxpayerInfo("Jack Sparrow", "64 Pirate Place", "Miami", "Florida", "32190",
                "251444152", "5", "900000", "20000", "-24000",
                "60000", "10000", "40000"));

            Taxpayers.Add(new TaxpayerInfo("Chris Sawyer", "89 Evergreen Park", "Detroit", "Michigan", "49506",
                "199903310", "1", "100000000000", "333183453", "300000",
                "500000", "1000", "5000"));

            Taxpayers.Add(new TaxpayerInfo("Scruff McGruff", "8 Biteouta Crime St", "Chicago", "Illinois", "60652",
                "483227463", "3", "20000", "1000", "0",
                "4000", "50", "8000"));

        }

    }
}

