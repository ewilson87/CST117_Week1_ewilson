/**
 * Program: Exercise 1 & 2
 * File: Exercises_1-2.cs
 * Summary: Basic windows form with controls and minimal function
 * Author: Evan Wilson
 * Date: April 26th, 2018
 **/

using System;
using System.Windows.Forms;

namespace CST_117_Exercise_1_EWilson
{
    public partial class Exercises1And2 : Form
    {
        public Exercises1And2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length >= 4 && passwordTextBox.Text.Length >= 6)
            {
                MessageBox.Show("Account Successfully Created \r\n \r\n" +
                        "User Name: " + nameTextBox.Text +
                        "\r\nPassword: " + passwordTextBox.Text, "Success");
            }
            else
            {
                if (nameTextBox.Text.Length < 4 && passwordTextBox.Text.Length >= 6)
                {
                    MessageBox.Show("User name must be at least 4 characters long!", "Error");
                }

                if (passwordTextBox.Text.Length < 6 && nameTextBox.Text.Length >= 4)
                {
                    MessageBox.Show("Password must be at least 6 characters long!", "Error");
                }

                if (nameTextBox.Text.Length < 4 && passwordTextBox.Text.Length < 6)
                {
                    MessageBox.Show("You must enter a user name and password \r\n" +
                                    "User name must be at least 4 characters long! \r\n" +
                                    "Password must be at least 6 characters long!", "Error");
                }
            }
        }
    }
}
