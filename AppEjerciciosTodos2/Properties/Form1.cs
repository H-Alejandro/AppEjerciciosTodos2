using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosTodos2.Properties
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)


        {
            this.Close();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtMetros.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar los metros");
                this.txtMetros.Focus();
                return;

            }
            try
            {

                double metros = Double.Parse(this.txtMetros.Text);
                this.txtMetrosEnPulgadas.Text = fnMetrosaPulgadas(metros).ToString();

                this.txtMetrosEnPies.Text = fnMestrosaPies(metros).ToString("0.00");
            }
            catch(Exeption ex1)
            {
                MessageBox.Show(ex1.Message.ToString());

            }




        }
        private double fnMetrosaPulgadas(double metros)
        {
            return (metros * 39.37);

        }
        private double fnMestrosaPies(double metros)
private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
