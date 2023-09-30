using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prakt_lab3
{
    public partial class Settings : Form
    {
        Color colorForCircle;
        Color colorForForm;
        int speed;

        public Settings()
        {
            InitializeComponent();
            colorForCircle = Color.White;
            colorForForm = Color.RoyalBlue;
        }

        // Цвет фона
        public Color ColorForm
        {
            get
            {
                return colorForForm;
            }
        }

        // Цвет фигуры
        public Color ColorCircle
        {
            get
            {
                return colorForCircle;
            }
        }

        // Скорость движения фигуры
        public double SpeedCircle
        {
            get
            {
                return speed;
            }
        }

        // Метод, срабатывающий  при нажатии на button1. Вызывается при событии Click на button1
        private void button1_Click(object sender, EventArgs e)
        {
            // цвет фигуры
            if (comboBox1.SelectedIndex == 0) // красный
            {
                colorForCircle = Color.Red;
            }
            else if (comboBox1.SelectedIndex == 1) // зеленый 
            {
                colorForCircle = Color.Green;
            }
            else if (comboBox1.SelectedIndex == 2) // белый
            {
                colorForCircle = Color.White;
            }
            else if (comboBox1.SelectedIndex == 3) // фиолетовый
            {
                colorForCircle = Color.Purple;
            }
            else if (comboBox1.SelectedIndex == 4) // серый
            {
                colorForCircle = Color.Gray;
            }

            // цвет фона
            if (comboBox2.SelectedIndex == 0) // черный
            {
                colorForForm = Color.Black;
            }
            else if (comboBox2.SelectedIndex == 1) // синий 
            {
                colorForForm= Color.RoyalBlue;
            }
            else if (comboBox2.SelectedIndex == 2) // коричневый
            {
                colorForForm= Color.Brown;
            }
            else if (comboBox2.SelectedIndex == 3) // оранжевый
            {
                colorForForm= Color.Orange;
            }
            else if (comboBox2.SelectedIndex == 4) // розовый
            {
                colorForForm= Color.Pink;
            }
            speed = Convert.ToInt32(numericUpDown1.Value);
            Close();
        }
    }
}
