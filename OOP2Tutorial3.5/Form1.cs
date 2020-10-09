using System.Drawing;
using System.Windows.Forms;

namespace OOP2Tutorial3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseDown += OnMouseDown;
            MouseUp += OnMouseUp;
            MouseMove += OnMouseMove;
        }

        private bool _isMouseDown;

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                CreateGraphics().FillRectangle(Brushes.Green, e.X,e.Y,3,3);   
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            CreateGraphics().FillRectangle(Brushes.Red, e.X,e.Y,3,3);
            _isMouseDown = false;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            CreateGraphics().FillRectangle(Brushes.Blue, e.X,e.Y,3,3);
            _isMouseDown = true;
        }
    }
}