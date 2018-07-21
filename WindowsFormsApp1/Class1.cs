using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class SetNumbers
	{
		int Number;
		int identifier = 0;
		string calculation;
		double result;
		//int parameter;

		//public void toInt(string number)
		//{
		//	parameter = Convert.ToInt32(number);
		//}
		public int getNumbers(int parameter)
		{
				Number = parameter;
				return Number;
		}

		public string getCalculation(string calc)
		{

			calculation = calc;
			return calculation;
		}

		public double setResult(int firstNumber, int secondNumber, string calculation)
		{
			if(calculation == "+")
			{
				result = firstNumber + secondNumber;
			}
			else if (calculation == "-")
			{
				result = firstNumber - secondNumber;
			}
			else if (calculation == "*")
			{
				result = firstNumber * secondNumber;
			}
			else if (calculation == "/")
			{
				result = firstNumber / secondNumber;
			}

			return result;
		}

	}
}
