using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_grupal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            if (a > b && b > c)
            {
                textBox4.Text = ("El valor del medio es B");

            }
            else
            {
                if (a > c && c > b)
                {
                    textBox4.Text = ("El valor del medio es C");
                }

                else

                if (c > a && a > b)
                {
                    textBox4.Text = ("El valor del medio es A");
                }

                else

                if (b > c && c > a)
                {
                    textBox4.Text = ("El valor del medio es C");
                }

                else

                if (c > b && b > a)
                {
                    textBox4.Text = ("El valor del medio es B");
                }

                else
                if (b > a && a > c)
                {
                    textBox4.Text = ("El valor del medio es A");
                }

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
