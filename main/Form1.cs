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
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);   
            }
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
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            if(txtFiltroRapido.Text.Length >= 1)
            {
                listaFiltrada = listaPokemons.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Numero.ToString().Contains(txtFiltroRapido.Text));
            }
            else
            {
                listaFiltrada = listaPokemons;
            }
            dgvPokemons.DataSource = null;
            dgvPokemons.DataSource = listaFiltrada;

            ocultarColumnas();

        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCampo.Text == "Número")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else /*if (cboCampo.Text == "Nombre" || cboCampo.Text == "Descripción")*/
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            string campo = cboCampo.Text;
            string criterio = cboCriterio.Text;
            string filtro = txtFiltro.Text;
            dgvPokemons.DataSource = negocio.filtrarPokemon(campo, criterio, filtro);

        }

        //FUNCIONES QUE NO SON EVENTOS 
        public void cargarImagen(string imagen)
        {
            try
            {
                pbPokemons.Load(imagen);
            }
            catch (Exception)
            {
                pbPokemons.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
        public void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.listarPokemon();
            dgvPokemons.DataSource = listaPokemons;
            ocultarColumnas();
            cargarImagen(listaPokemons[0].UrlImagen);
        }
        public void ocultarColumnas()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }
        public void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                if (!logico)
                {
                    DialogResult resultado = MessageBox.Show("Estás seguro que quieres eliminar el pokemon permanentemente?", "Borrar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                    seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionado.Id);
                    cargar();
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Estás seguro que quieres deshabilitar el pokemon?", "Borrar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.Yes)
                    {
                        seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                        negocio.eliminarLogico(seleccionado.Id);
                        cargar();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}