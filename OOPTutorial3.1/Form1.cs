using System;
using System.Windows.Forms;

namespace OOPTutorial3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Returns the sum of the two integers passed as arguments.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int addition(int a, int b)
        {
            return a + b;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IntegerOne.Text, out int a) && int.TryParse(IntegerTwo.Text, out int b))
            {
                ResultValue.Text = addition(a, b).ToString();
            }
        }
    }
}