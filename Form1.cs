using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e4_StringCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int getIndexOfFirstLineBreak(string input)
        {
            var index = 0;
            int newlinechar = Convert.ToChar(Environment.NewLine);
            foreach (var c in input)
                if (c == (char)13|| c== newlinechar)
                    return index;
                else
                    index++;

            return input.Length;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
            lblFinal.Text = "";

            BL.StringCalc mainCalc = new BL.StringCalc();
            BL.Results mainResults = mainCalc.CalculateString(txtCalcInput.Text);

            txtResults.Text = mainResults.Messages;
            lblFinal.Text += Environment.NewLine + "FINAL RESULT! : " + mainResults.FinalResult.ToString();
        }

        
    }
}
