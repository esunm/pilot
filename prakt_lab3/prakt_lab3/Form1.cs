using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt_lab3
{
    public partial class Form1 : Form
    {
        enum STATUS 
        {
            Left, Right
        };
        STATUS flag;
        Settings settings = new Settings();
        Color colorForCircle, colorForForm;
        Graphics g;
        int x = 100; // локация по x
        int w = 100; // размер круна
        bool flag2;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            colorForCircle = settings.ColorCircle;
            colorForForm = settings.ColorForm;
        }

        // Метод, срабатывающий при перерисовки элемента управления. Вызывается при событии Paint на Form1
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(colorForForm);
            g.FillEllipse(new SolidBrush(colorForCircle), x, 100, w, w);
        }

        // Метод, срабатывающий по истечении заданного временного интервала. Вызывается при событии Tick в timer1
        private void timer1_Tick(object sender, EventArgs e)
        {         
            g = CreateGraphics();
            g.Clear(colorForForm);
            g.FillEllipse(Brushes.White, x, 100, w, w);
            this.Invalidate();

            if (flag == STATUS.Left) // движение влево
                x -= 5;
            if (flag == STATUS.Right) // движение вправо
                x += 5;

            if (x >= (this.ClientSize.Width - w)) // если достигли правого края формы
            {
                flag = STATUS.Left; // меняем статус движения на левый
            }

            else if (x <= 1) // если достигли левого края формыSSSS
            {
                flag = STATUS.Right;    // меняем статус движения на правый
            }

            if (flag2 == true) 
            {
                w += 10; // увеличение круга
            }
            else
            {
                w -= 10; // уменьшение круга
            }
            flag2 = !flag2;

        }

        // Метод, срабатывающий при нажатии любой клавиши на клавиатуре. Вызывается при событии KeyPress на button1
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }

        // Метод, срабатывающий при нажатии левой или правой кнопки мыши. Вызывается при событии Click на Form1
        private void Form1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Метод, срабатывающий  при нажатии на button1. Вызывается при событии Click на button1
        private void button1_Click(object sender, EventArgs e)
        {
            settings.Owner = this;
            settings.ShowDialog(); 
            colorForCircle = settings.ColorCircle; // получение цвета фигуры из настроек
            colorForForm = settings.ColorForm; // получение цвета формы из настроек
            button1.ForeColor = colorForForm; 
            timer1.Interval = Convert.ToInt32(150 / settings.SpeedCircle); // получение скорости движения из настроек
        }
    }
}
