using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Pokemon
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemon;

        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false; // Oculta la columna de urlImagen, antes de cargar
            cargarImagen(listaPokemon[0].UrlImagen);
        }
        // Hasta el momento unicamente muestra una sola imagen...

        //En este caso, va a mostrar la imagen de cada pokemon seleccionado
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
           Pokemon seleccionado =  (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;// => esto devuelve un objeto.. por eso lo transformamos en POKEMON
            cargarImagen(seleccionado.UrlImagen);


        }
        private void cargarImagen (string imagen)
        {
            try
            {
            pbxPokemon.Load(imagen);

            }
            catch (Exception ex)
            {
                //Esto hace que si no hay una imagen cargada, muestra una imagen por defecto (en este caso de placeHolder)
                pbxPokemon.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");

            }

;
        }
    }
}
