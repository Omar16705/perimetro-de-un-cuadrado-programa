using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perimetro_de_un_cuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btncalcularperimetro_Click(object sender, EventArgs e)
        {
            double lado1, perim;

            lado1 = double.Parse(txtblado1.Text);
            perim = 4 * lado1;
            txtperimetrocuadrad.Text = perim.ToString("N2");

        }

        private void btnsalirprogram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtblado1.Clear();
          txtperimetrocuadrad.Clear();
  
        }
    }
}
