// OOPL - Spring 2020 with Prof. Richmond
//
// Disturbo Tax 1.0
// This is a program that will take user demographic 
// and tax info, calculate tax information, and display
// 10 users' information in a table using Windows Forms in C#
// 
// by Marisha Kulseng
// last modified 2/21/2020
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
