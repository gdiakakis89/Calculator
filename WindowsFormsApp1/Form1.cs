using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		int param1, identifier = 1;
		int param2;
		double result;
		string calc;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Button_Pressed(object sender, EventArgs e)
		{
			var btn = sender as Button;
			SetNumbers _setNumbers = new SetNumbers();
			if (btn.Text == "*" || btn.Text == "+" || btn.Text == "-" || btn.Text == "/")
			{
				calc = _setNumbers.getCalculation(btn.Text);
			}
			else if (btn.Text != "Cl")
			{
				if (identifier == 1)
				{
					param1 = _setNumbers.getNumbers(Convert.ToInt32(btn.Text));
					identifier += 1;
				}
				else if (identifier == 2)
				{
					param2 = _setNumbers.getNumbers(Convert.ToInt32(btn.Text));
					identifier = 1;
				}
			}
			else
			{
				result = _setNumbers.setResult(param1,param2, calc);
			}

			int parameter = Convert.ToInt32(btn.Text);

			//SetNumbers param = new SetNumbers();

		}

		//private void CalcPressed(object sender, EventArgs e)
		//{
		//	var btn1 = sender as Button;
		//	string calcparam = btn1.Text;

		//	SetNumbers calc = new SetNumbers();
		//	calc.getCalculation(calcparam);
		//}

		//private void getResult(object sender, EventArgs e)
		//{
		//	SetNumbers result = new SetNumbers();
		//	var finalResult = result.setResult();
		//}
	}
}
