using System;
namespace Calculator
{
	public class Calculations
	{
		internal static decimal CalculateResult(string nr1, string nr2, string operatorType)
		{
			decimal result = 0;

			var operand1 = decimal.Parse(nr1);
			var operand2 = decimal.Parse(nr2);

			switch (operatorType)
			{
				case "+":
				result = operand1 + operand2;
				break;

				case "-":
				result = operand1 - operand2;
				break;

				case "*":
				result = operand1 * operand2;
				break;

				case "/":
				if (operand2 == 0)
				{
					result = 0;
				} else
				{
					result = operand1 / operand2;
				}
				break;

			}

			result = Math.Round(result, 5);
			return result;
		}
	}
}