/**
 * Program: Exercise 3 & Project 1
 * File: Week1Exercise3.cs
 * Summary: Fahrenheit/Celsius temperature conversion program
 * Author: Evan Wilson
 * Date: April 26th, 2018
 **/

using System;
using System.Windows.Forms;

namespace Week1_Exercise3
{
    public partial class Week1Exercise3 : Form
    {
        public Week1Exercise3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Week1Exercise3_Load(object sender, EventArgs e)
        {
        }

        private void tempTextBox_TextChanged(object sender, EventArgs e)
        {
            if (tempTextBox.Text == "")
            {
                convertedTempTextBox.Text = "";
            }
            else
            {
                try
                {
                    decimal originalTemp = decimal.Parse(tempTextBox.Text);
                    if (fahrenheitRadioButton.Checked)
                    {
                        decimal convertedTemp = (originalTemp - 32) * 5 / 9;
                        convertedTempTextBox.Text = Math.Round(convertedTemp, 3).ToString();
                    }
                    else if (celsiusRadioButton.Checked)
                    {
                        decimal convertedTemp = originalTemp * 9 / 5 + 32;
                        convertedTempTextBox.Text = Math.Round(convertedTemp, 3).ToString();
                    }
                }
                catch
                {
                    tempTextBox.Text = "";
                    MessageBox.Show("You can only enter numbers!");
                }
            }
        }

        private void celsiusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tempTextBox.Text = "";
            if (fahrenheitRadioButton.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (celsiusRadioButton.Checked)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
        }
    }
}