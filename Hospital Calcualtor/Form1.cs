using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Calcualtor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //These methods accept the number of days at the hospital
        //and medical charges as arguments and return the
        //equivalent total of charges.
        private double CalcSyayCharges(double days)
        {
            return days *340.0;
        }
        private double CalcMiscCharges(double medication, double surgical, double lab, double rehab)
        {
            return (medication + surgical + lab + rehab);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            // Variables to hold the number of days spent at the hospital, amount of medication, surgical, lab and rehab charges. 
            double days, staytotal, medication, surgical, lab, rehab, totalCharges;

            // Get the number of days.
            if (double.TryParse(textBoxdays.Text, out days))
            {
                // Calculate the stay charge.
                staytotal = CalcStayCharges(days);

                // Display the stay charge.
                totalStayLabel.Text = staytotal.ToString("n1");

                // Calculate the other services.
                totalCharges = CalcMiscCharges(medication, surgical, lab, rehab);
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Enter a valid number.");
            }
    }

        private void labelDays_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear the Textboxes and average label control
            textBoxdays.Text = "";
            textBoxMedication.Text = "";
            textBoxSurgical.Text = "";
            textBoxLab.Text = "";
            textBoxRehab.Text = "";
        } 
          
            
       