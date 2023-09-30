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
    public partial class Form3 : Form
    {
        //ArrayList results = new ArrayList();
        public Form3()
        {
            InitializeComponent();
            Form2.Taxpayers.Sort();
            //string a = ((TaxpayerInfo)Form1.Taxpayers[0]).getSSN();
            FillData();


        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillData()
        {
            string[] row0 = getData(0),    row1 = getData(1),
                row2 = getData(2),         row3 = getData(3),
                row4 = getData(4),         row5 = getData(5),
                row6 = getData(6),         row7 = getData(7),
                row8 = getData(8),         row9 = getData(9);

            dataGridView1.Rows.Add(row0);        dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);        dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);        dataGridView1.Rows.Add(row5);
            dataGridView1.Rows.Add(row6);        dataGridView1.Rows.Add(row7);
            dataGridView1.Rows.Add(row8);        dataGridView1.Rows.Add(row9);

        }

        private string[] getData(int index)
        { //String.Format("{0:C}", toDisplay.getPenalty())
            //decimal tempString = ((TaxpayerInfo)Form2.Taxpayers[index]).getTaxOwed();//).ToString());
            string[] result = { ((TaxpayerInfo)Form2.Taxpayers[index]).getSSN(),
                    ((TaxpayerInfo)Form2.Taxpayers[index]).getLName(),
                    ((TaxpayerInfo)Form2.Taxpayers[index]).getFName(),
                     String.Format("{0:C0}", ((TaxpayerInfo)Form2.Taxpayers[index]).getTaxOwed()),//String.Format("{0:C}", ((((TaxpayerInfo)Form2.Taxpayers[index]).getTaxOwed()).ToString())),
                     String.Format("{0:C0}",((TaxpayerInfo)Form2.Taxpayers[index]).getRefundOwed())};
            return result;
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }


}
