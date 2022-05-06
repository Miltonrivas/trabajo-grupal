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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.NumerosDecimales(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

      
    }


}
