/*
 * Jacob Hands
 * 2015-04-20
 * Chapter 12 Problem 8 (p.836)
 * COSC 2430 001
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12Problem8
{
    public partial class CalculatorForm : Form
    {
        private Calculator _calc = new Calculator();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            if (double.TryParse(txtNum1.Text, out n1))
            {
                if (double.TryParse(txtNum2.Text, out n2))
                {
                    _calc.Num1 = n1;
                    _calc.Num2 = n2;
                    try
                    {
                        switch (GetCalcType())
                        {
                            case CalcType.Add:
                                _calc.Add();
                                break;
                            case CalcType.Subtract:
                                _calc.Subtract();
                                break;
                            case CalcType.Multiply:
                                _calc.Multiply();
                                break;
                            case CalcType.Devide:
                                _calc.Devide();
                                break;
                        }
                        res = _calc.Result;
                        lblResult.Text = res.ToString();
                    }
                    catch (DevideByZeroException ex)
                    {
                        MessageBox.Show("Error, can not devide by zero.");
                    }
                }
                else
                {
                    MessageBox.Show("Error, number 2 must be a valid number!");
                    txtNum2.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Error, number 1 must be a valid number!");
                txtNum1.Text = string.Empty;
            }
        }

        private CalcType GetCalcType()
        {
            CalcType ct = CalcType.Add;
            if (radAdd.Checked) ct = CalcType.Add;
            else if (radSubtract.Checked) ct = CalcType.Subtract;
            else if (radMultiply.Checked) ct = CalcType.Multiply;
            else if (radDevide.Checked) ct = CalcType.Devide;
            return ct;
        }
        private enum CalcType { Add, Subtract, Multiply, Devide }
    }
}
