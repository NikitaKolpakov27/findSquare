using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log;

namespace WindowsForms_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void calculate_Click(object sender, EventArgs e)
        {
            double side;
            string text = squareLength.Text;

            if (!double.TryParse(text, out side))
            {
                MessageBox.Show("Неверно введённые данные!");
            }
            else
            {
                if (side <= 0)
                {
                    MessageBox.Show("Введено отрицательное или нулевое значение!");
                }
                else
                {
                    var a = new Logic();
                    result.Text = a.findSquare(side).ToString();
                }
            }
        }
    }
}
    
    