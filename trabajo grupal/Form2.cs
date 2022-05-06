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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 r = new Form3();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 r = new Form1();
            r.Show();
        }
    }
}
