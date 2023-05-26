using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class frmAltaPokemon : Form
    {
        Pokemon poke = null;

        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon seleccionado)
        {
            InitializeComponent();
            poke = seleccionado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();

            try
            {
                cboDebilidad.DataSource = negocio.listarElemento();
                cboDebilidad.DisplayMember = "Descripcion";
                cboDebilidad.ValueMember = "Id";
                cboTipo.DataSource = negocio.listarElemento();
                cboTipo.DisplayMember = "Descripcion";
                cboTipo.ValueMember = "Id";

                if (poke != null)
                {
                    txtNumero.Text = poke.Numero.ToString();
                    txtNombre.Text = poke.Nombre;
                    txtDescripcion.Text = poke.Descripcion;
                    txtUrlImagen.Text = poke.UrlImagen;
                    cboTipo.SelectedValue = poke.Tipo.Id;
                    cboDebilidad.SelectedValue = poke.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
                
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (poke == null)
                {
                    poke = new Pokemon();
                }
                    PokemonNegocio negocio = new PokemonNegocio();

                    poke.Nombre = txtNombre.Text;
                    poke.Numero = int.Parse(txtNumero.Text);
                    poke.Descripcion = txtDescripcion.Text;
                    poke.UrlImagen = txtUrlImagen.Text;
                    poke.Tipo = (Elemento)cboTipo.SelectedItem;
                    poke.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                if (poke.Id != 0)
                {
                    negocio.modificarPokemon(poke);
                    MessageBox.Show("Pokemon modificado exitosamente!");
                }
                else
                {
                    negocio.agregarPokemon(poke);
                    MessageBox.Show("Pokemon agregado exitosamente!");
                }

                this.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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
    }
}
