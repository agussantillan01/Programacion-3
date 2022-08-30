using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(num1.Text);
                b = int.Parse(num2.Text);
                r = a + b;

                resultado.Text = "= " + r;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); //Una forma de mostrar el error
                MessageBox.Show("Ingrese unicamente numero por favor....");


            }
            finally
            {
                MessageBox.Show("Finally -- Se ejecuta SIEMPRE, sin importar lo que suceda en try o catch");

            }
        }
    }
}
