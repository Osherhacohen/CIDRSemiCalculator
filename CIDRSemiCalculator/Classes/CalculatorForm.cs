using CIDRSemiCalculator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDRSemiCalculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (CalculatorFunctions.ValidCIDR(textBoxValidate.Text))
            {
                validationLabel.Text = "OK";
            }
            else
            {
                validationLabel.Text = "BAD";
            }
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            if (CalculatorFunctions.ValidCIDR(textBoxRange.Text))
            {
                string[] addressRange = CalculatorFunctions.CalculateCIDRRange(textBoxRange.Text).Split(':');
                cidrRangeLowLabel.Text = addressRange[0];
                cidrRangeHighLabel.Text = addressRange[1];
            }
            else
            {
                cidrRangeLowLabel.Text = "BAD CIDR.";
                cidrRangeHighLabel.Text = "BAD CIDR.";
            }            
        }

        private void buttonOverlap_Click(object sender, EventArgs e)
        {
            if (CalculatorFunctions.ValidCIDR(textBoxOverlapNet1.Text)&& CalculatorFunctions.ValidCIDR(textBoxOverlapNet2.Text))
            {
                if (CalculatorFunctions.CIDROverlaps(textBoxOverlapNet1.Text, textBoxOverlapNet2.Text))
                {
                    labelOverlap.Text = "OVERLAP";
                }
                else
                {
                    labelOverlap.Text = "NO OVERLAP";
                }
            }
            else
            {
                labelOverlap.Text = "BAD CIDR";
            }
        }
    }
}
