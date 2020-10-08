using System;
using System.Globalization;
using System.Windows.Forms;

namespace OOPTutorial3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Delegate for math operation
        delegate decimal MathDelegate(decimal a, decimal b);
        
        // Var for delegate
        private MathDelegate Calculation;

        // Function for addition
/*
        decimal Addition(decimal a, decimal b)
        {
            return Decimal.Round(a + b,2);
        }
*/
        
        // Function for subtraction
/*
        decimal Subtraction(decimal a, decimal b)
        {
            return Decimal.Round(a - b,2);
        }
*/
        
        // Function for multiplication
/*
        decimal Multiplication(decimal a, decimal b)
        {
            return Decimal.Round(Decimal.Multiply(a, b),2);
        }
*/
        
        // Function for division
/*
        decimal Division(decimal a, decimal b)
        {
            return  Decimal.Round(Decimal.Divide(a, b),2);
        }
*/


        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(ValueOne.Text, out decimal a) && Decimal.TryParse(ValueTwo.Text,out decimal b))
            {
                ResultValue.Text = Calculation(a, b).ToString(CultureInfo.InvariantCulture);
            }
        }

        private void RadioAddition_CheckedChanged(object sender, EventArgs e)
        {
            // with function (commented above)
            // Calculation = Addition;
            // or with lamda
            Calculation = (a, b) => Decimal.Round(a + b, 2);
        }

        private void RadioSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            // with function (commented above)
            // Calculation = Subtraction;
            // or with lamda
            Calculation = (a, b) => Decimal.Round(a - b, 2);
        }

        private void RadioMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            // with function (commented above)
            // Calculation = Multiplication;
            // or with lambda
            Calculation = (a, b) => Decimal.Round(Decimal.Multiply(a, b), 2);
        }

        private void RadioDivision_CheckedChanged(object sender, EventArgs e)
        {
            // with function (commented above)
            // Calculation = Division;
            // or lamda
            Calculation = (a, b) => Decimal.Round(Decimal.Divide(a, b), 2);
        }
    }
}