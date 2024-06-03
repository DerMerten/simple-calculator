using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator {
    public partial class Form1 : Form {

        double resultValue = 0;
        String operation;
        private TextBox currentTxtBox;

        public Form1 () {
            InitializeComponent( );
            currentTxtBox = txtNum1;
        }

        private void evntClickNum ( object sender, EventArgs e ) {
            if (currentTxtBox.Text == "0")
                currentTxtBox.Clear( );

            Button btnEventClickNum = ( Button ) sender;

              if(string.IsNullOrEmpty(operation)) {
                currentTxtBox = txtNum1;
            }
            else {
                currentTxtBox = txtNum2;
            }

            currentTxtBox.Text += btnEventClickNum.Text;
        }

        private void evntClickOperation ( object sender, EventArgs e ) {

            Button btnEventClickOperation = ( Button ) sender;
            operation = btnEventClickOperation.Text;
            txtOperation.Text = operation;
        }

        private void txtNum1_TextChanged ( object sender, EventArgs e ) {
            currentTxtBox = txtNum1;
        }

        private void txtNum2_TextChanged ( object sender, EventArgs e ) {
            currentTxtBox = txtNum2;
        }

        private void btnClear_Click ( object sender, EventArgs e ) {
            currentTxtBox.Text = "0";
        }

        private void txtOperation_TextChanged ( object sender, EventArgs e ) {
            if (string.IsNullOrWhiteSpace(txtOperation.Text) && string.IsNullOrWhiteSpace(operation)) {
                MessageBox.Show("Please enter a valid operator.");
            }
            else {
                operation = txtOperation.Text;
            }
        }

        private void btnEqual_Click ( object sender, EventArgs e ) {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            switch (operation) {
                case "+":
                    resultValue = num1 + num2;
                    break;
                case "-":
                    resultValue = num1 - num2;
                    break;
                case "*":
                    resultValue = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        resultValue = num1 / num2;
                    else {
                        MessageBox.Show("Division by zero is not permitted.");
                        return;
                    }
                    break;
                default:
                    break;
            }

            lblResuFinal.Text = resultValue.ToString( );

            txtNum1.Clear();
            txtNum2.Clear();
            txtOperation.Clear();

            operation = null;

            currentTxtBox = txtNum1;
        }

    }
}
