using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Number
{
    public partial class averageValue : Form
    {
        public averageValue()
        {
            InitializeComponent();
        }
        double numberOfNumbers = 0;
        double totalValue = 0;
        double textBoxNumber;
        double average;
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNumber = Int32.Parse(textBox.Text);
                totalValue = totalValue + textBoxNumber;
                numberOfNumbers = numberOfNumbers + 1;
                instructionLabel.Text = "Enter a number and press add";
                textBox.Text = "";
                outputLabel.Text = $"{textBoxNumber} was added to the sum";
            }
            catch { instructionLabel.Text = "ENTER A NUMBER"; }
        }

        private void findAverage_Click(object sender, EventArgs e)
        {
            average = totalValue / numberOfNumbers;
            outputLabel.Text = $"{average} is your average";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            totalValue = 0;
            average = 0;
            numberOfNumbers = 0;
            textBox.Text = "";
        }
    }
}
