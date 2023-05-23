using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace main
{
    public partial class Form1 : Form
    {
        List<Pokemon> listaPokemons = new List<Pokemon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);   
        }

        private void btnAgregarPokemon_Click(object sender, EventArgs e)
        {
            frmAltaPokemon frmAlta = new frmAltaPokemon();
            frmAlta.ShowDialog();
            cargar();
        }
        private void btnModificarPokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            frmAltaPokemon frmModifica = new frmAltaPokemon(pokemon);
            frmModifica.ShowDialog();
            cargar();
        }

        //FUNCIONES QUE NO SON EVENTOS 
        public void cargarImagen(string imagen)
        {
            try
            {
                pbPokemons.Load(imagen);
            }
            catch (Exception ex)
            {
                pbPokemons.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
        public void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listarPokemon();
            dgvPokemons.DataSource = listaPokemons;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
            cargarImagen(listaPokemons[0].UrlImagen);
        }

    }
}
