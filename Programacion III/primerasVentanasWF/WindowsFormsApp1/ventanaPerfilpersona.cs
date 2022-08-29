using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventanaPerfilpersona : Form
    {
        public ventanaPerfilpersona()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColorFavorito.Items.Add("Rojo");
            comboBoxColorFavorito.Items.Add("Azul");
            comboBoxColorFavorito.Items.Add("Blanco");
            comboBoxColorFavorito.Items.Add("Negro");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Nombre;
            string nombre = "Su nombre es: "+ txtNombre.Text;
            nombre.ToLower();
            //fecha Nacimiento;
            DateTime fechaNacimiento = dtpFecha.Value;
            //Chocolate;
            string likeChocolate;
            if (chkBoxChocolate.Checked== true) likeChocolate = "Le gusta el chocolate";
            else likeChocolate = "Odia el chocolate";
            //comida Fac;
            string team;
            if (rbtHamburguesa.Checked) team = "Team Hamburguesa";
            else if (rbtEmpeanadas.Checked) team = "Team Empandas";
            else team = "Team Pizza";
            //Color fav;
            string colorFav = "Su color favorito es: " + comboBoxColorFavorito.SelectedItem.ToString();
            //num fav; 
            string numFav = "Su numero favorito es: " + numeroFavorito.Value.ToString();


            MessageBox.Show(nombre + "; " + fechaNacimiento + "; " + likeChocolate + "; " + team + "; " + colorFav + "; " + numFav + ". ");

        
        }
    }
}
