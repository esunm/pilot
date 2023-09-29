using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Метод, срабатывающий  при нажатии на button1. Вызывается при событии Click на button1
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0) || (textBox1.Text == "-"))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                button1.Enabled = true;
                double x = Convert.ToDouble(textBox1.Text);
                double E = Convert.ToDouble(textBox2.Text);
            }
        }


        // Метод для обработки ввода в textBox. Вызывается при событии KeyPress в textBox1, textBox2.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == textBox1) // поле для ввода X
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                    return;
                if (e.KeyChar == '.') e.KeyChar = ',';	// Замена точки на запятую
                if (e.KeyChar == ',')
                {
                    if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                        e.KeyChar = '\0'; // Разреншение ввода только одной запятой и не в начале строки
                    return;
                }
                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Back)
                        return;
                }
                if (e.KeyChar == '-')
                {
                    if ((textBox1.Text.IndexOf('-') != -1) || (textBox1.Text.Length != 0))
                        e.KeyChar = '\0'; // Разреншение ввода только одного знака минус в начале строки
                    return;
                }
                e.KeyChar = '\0'; // Запрет на ввод остальных символов
            }
            if (sender == textBox2)
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                    return;
                if (e.KeyChar == '.') e.KeyChar = ',';	// Замена точки на запятую
                if (e.KeyChar == ',')
                {
                    if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                        e.KeyChar = '\0'; // Разреншение ввода только одной запятой и не в начале строки
                    return;
                }
                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Back)
                        return;
                }
                e.KeyChar = '\0'; // Запрет на ввод остальных символов
            }
        }

        //Метод, срабатывабщий при обработки текста. Вызывается при событии TextChanged в textBox1, textBox2
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length > 0))
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled= false;
        }
    }
}
