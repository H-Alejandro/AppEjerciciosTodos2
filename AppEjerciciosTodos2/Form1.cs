using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosTodos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            if(this.txtA.Text.Length ==0)
            {
                MessageBox.Show("Debe ingresar el valor de A");
                    this.txtA.Focus();
                return;

            }
            if (this.txtB.Text.Length == 0)

            {
                MessageBox.Show("Debe ingresar el valor de B");
                this.txtB.Focus();
                return;
            }
            if (this.txtC.Text.Length == 0)

            {
                MessageBox.Show("Debe ingresar el valor de C");
                this.txtC.Focus();
                return;
            }

            //ouble a = Double.Parse(this.txtA.Text);
            double a, b, c, result;

            if (Double.TryParse(this.txtA.Text, out result))
                a = result;
            else

            {

                MessageBox.Show("Debe ingresar valores numércios");
                this.txtA.Focus();
                return;
            }

            else
                
            if (Double.TryParse(this.txtB.Text, out result))
                b = result;
            {
                MessageBox.Show("Debe ingresar valores numércios");
                this.txtB.Focus();
                return;
            }

            else
                
            if (Double.TryParse(this.txtC.Text, out result))
                c = result;
            {
                MessageBox.Show("Debe ingresar valores numércios");
                this.txtC.Focus();
                return;
            }


        }
        private double friAreaTriangulo(double a, double b, double c)
        {
            double area, sp;
            sp = (a + b + c) / 2;

            area= Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c))
            return area;
        }
    }
}
