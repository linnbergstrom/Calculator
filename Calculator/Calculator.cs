using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		private string nr1 = "";
		private string nr2 = "";
		private decimal result;
		private string operatorType = "";
		private string deci = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

		public Calculator()
		{
			InitializeComponent();
			btnDeci.Text = deci;
		}

		private void DigitPressed(string btnPressed)
		{
			var input = inputBox.Text;

			if (btnPressed == "0")
			{
				if (input != "0" || input.Contains(deci))
				{
					input += "0";
				}
				if (input.Length > 11)
				{
					return;
				}

				inputBox.Text = input;
				inputBox.SelectionStart = inputBox.TextLength;
				return;
			}

			if (input == "0")
				input = "";

			if (input.Length > 11)
			{
				return;
			}
			input += btnPressed;
			inputBox.Text = input;
		}

		private void btnSum_Click(object sender, EventArgs e)
		{
			//check that operators and operands exists, calculate result
			if (!String.IsNullOrEmpty(nr1) && !String.IsNullOrEmpty(operatorType) && inputBox.Text != "")
			{
				if (nr1.Length < 11 || nr2.Length < 11)
				{

					result = Calculations.CalculateResult(nr1, inputBox.Text, operatorType);
					topBox.Text = nr1 + " " + operatorType + " " + inputBox.Text + " = " + result;

					nr1 = result.ToString();
					inputBox.Text = nr1;
					nr2 = "";
					nr1 = "";
					operatorType = "";
				}
			}
		}
		//for keyboard input
		private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
		{
			var btnPressed = e.KeyChar.ToString();

			//if digit
			if (Char.IsDigit(e.KeyChar))
			{
				DigitPressed(btnPressed);
				inputBox.SelectionStart = inputBox.TextLength;
			}

			//if decimal, add "0" if its the first char, only one seperator in string.
			else if (e.KeyChar == ',' || e.KeyChar == '.')
			{
				if (inputBox.Text.Length < 1) 
				{
					inputBox.Text += "0" + deci;
				} 
				
				else if (inputBox.Text.Contains(deci))
				{
					e.Handled = true;
				} 
				
				else
				{
					inputBox.Text += deci;
				}

				inputBox.SelectionStart = inputBox.TextLength;
			}

			//if backspace
			else if (e.KeyChar == '\b')
				return;

			//if enter, check if operator and operands exists and return result
			else if (e.KeyChar == '\r' && !String.IsNullOrEmpty(nr1) && !String.IsNullOrEmpty(operatorType) && inputBox.Text != "")
			{
				if (nr1.Length > 11 || nr2.Length > 11)
				{
					result = Calculations.CalculateResult(nr1, inputBox.Text, operatorType);
					topBox.Text = nr1 + " " + operatorType + " " + inputBox.Text + " = " + result;

					nr1 = result.ToString();
					inputBox.Text = nr1;
					nr2 = "";
					nr1 = "";
					operatorType = "";
				}
			}
			//if operator
			if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '/' || e.KeyChar == '*')
			{
				operatorType = e.KeyChar.ToString();
				Calculate();
			}

			e.Handled = true;
		}

		private void Calculate()
		{
			//define nr1
			if (nr1 == String.Empty && inputBox.Text.Length > 0)
			{
				nr1 = inputBox.Text;
				topBox.Text = nr1 + " " + operatorType;
				inputBox.Clear();
			}
			//define nr2 if nr1 exists
			else if (nr2 == String.Empty && inputBox.Text.Length > 0)
			{
				nr2 = inputBox.Text;
				topBox.Text = nr1 + " " + operatorType + " " + nr2;
				inputBox.Clear();
			}
			//calculate and show result
			else if (nr1 != String.Empty && nr2 != String.Empty)
			{
				if (nr1.Length > 11 || nr2.Length > 11)
				{
					result = Calculations.CalculateResult(nr1, nr2, operatorType);
					topBox.Text = nr1 + " " + operatorType + " " + inputBox.Text + " = " + result;

					nr1 = result.ToString();
					inputBox.Text = "";
				}
			}
		}

		private void NumberClicked(object sender, EventArgs e)
		{
			var btnPressed = ((Button)sender).Text;

			DigitPressed(btnPressed);
		}

		//decimal point
		private void btnDeci_Click(object sender, EventArgs e)
		{
			var number = inputBox.Text;
			if (!number.Contains(deci))
			{
				if (inputBox.Text.Length < 1)
				{
					inputBox.Text = "0.";
					return;
				}
				inputBox.Text += deci;
			}
		}

		private void Operator_Click(object sender, EventArgs e)
		{
			operatorType = ((Button)sender).Tag.ToString();
			Calculate();
		}

		private void btnBackspace_Click(object sender, EventArgs e)
		{
			if (inputBox.Text != "")
				inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			nr1 = "";
			nr2 = "";
			topBox.Clear();
			inputBox.Clear();
		}
	}
}