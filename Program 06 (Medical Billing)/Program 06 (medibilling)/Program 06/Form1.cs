// Calvin Tracy
// CS 165 01
// Program 06
// 11/27/18
// Program to accept input for hospital bills and output the total cost.

// We do not use "void" for our custom methods because doing so would mean we could not return any values. 
// Void means that the method will not give you anything back

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CalcStayCharges()
        {
            int numDays;
            int stayTotal;
            int dayCharge = 350;

            // Change "txtDaysCare" from a String to an Int
            numDays = int.Parse(txtDaysCare.Text);
            stayTotal = dayCharge * numDays;
            return stayTotal; // Returns the value of "stayTotal"
        }

        public double CalcMiscCharges()
        {
            double Medication, Surgical, Lab, Rehab, medTotal;

            // Changes all Text boxes from Strings to Doubles
            Medication = double.Parse(txtMedication.Text);
            Surgical = double.Parse(txtSurgical.Text);
            Lab = double.Parse(txtLab.Text);
            Rehab = double.Parse(txtRehab.Text);
            medTotal = Medication + Surgical + Lab + Rehab;
            return medTotal;
        }

        // Sets "stayTotal" equal to the value of "hospitalCare"
        // And "mediTotal" equal to the value of "medicalBills"
        public double CalcTotalCharges(double stayTotal, double mediTotal)
        {
            double sumTotal;

            sumTotal = stayTotal + mediTotal;
            return sumTotal;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int hospitalCare;
            double medicalBills;
            double sumTotal;

            // hospitalCare is equal to the output of "CalcStayCharges" which is the value of "stayTotal"
            hospitalCare = CalcStayCharges(); 
            // Converts the integer value of hospitalCare to a string. 
            lblStayCharges.Text = hospitalCare.ToString("c");

            // medicalBills is equal to the value in "medTotal"
            medicalBills = CalcMiscCharges();
            // Converts the double value of medicalBills to a string.
            lblMedicalCharges.Text = medicalBills.ToString("c");

            // Passes in the values of "hospitalCare" and "medicalBills."
            // to the "CalcTotalCharges" function.
            sumTotal = CalcTotalCharges(hospitalCare, medicalBills);
            // Changes sumTotal from a double to a String
            lblSum.Text = sumTotal.ToString("c");
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
