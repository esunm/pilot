using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double P1_parall(double a, double b) // периметр параллелограмма
        {
            return 2 * (a + b); 
        }

        private double P2_trap(double a, double b, double d) // периметр равнобедренной трапеции
        {
            return (2 * a) + b + d;
        }

        private double S1_parall(double a, double h) // площадь параллелограмма 
        {
            return a * h;
        }

        private double S2_trap(double a, double b, double h) // площадь равнобедренной трапеции
        {
            return ((a + b) / 2) * h;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == true) && (radioButton3.Checked == true)) // параллелограмм - периметр
            {
                label3.Text = "";
                textBox3.Visible= false;
                label2.Text = "b";
            }
            else if ((radioButton1.Checked == true) && (radioButton4.Checked == true)) // параллелограмм - площадь
            {
                label2.Text = "h";
                textBox3.Visible= false;
            }
            else if ((radioButton2.Checked == true) && (radioButton3.Checked == true)) // трапеция - периметр 
            {
                label3.Visible= true;
                label3.Text = "d";
                textBox3.Visible= true;
            }
            else if ((radioButton2.Checked == true) && (radioButton4.Checked == true)) // трапеция - площадь
            {
                label3.Visible = true;
                label3.Text = "h";
                textBox3.Visible = true;
                label2.Text = "b";
            }
        }
    }
}
