using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listarPokemon()
        {
            List<Pokemon> list = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select P.Id, Numero, Nombre, P.Descripcion, UrlImagen, T.Descripcion Tipo, D.Descripcion Debilidad, T.Id IdTipo, D.Id IdDebilidad from POKEMONS P, ELEMENTOS T, ELEMENTOS D where P.IdTipo = T.Id and P.IdDebilidad = D.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    }

                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];

                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }




        }
        public void agregarPokemon(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad) values (@Numero, @Nombre, @Descripcion, @UrlImagen, @IdTipo, @IdDebilidad)");
                datos.setearParametro("@Numero", nuevo.Numero);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@UrlImagen", nuevo.UrlImagen);
                datos.setearParametro("@IdTipo", nuevo.Tipo.Id);
                datos.setearParametro("@IdDebilidad", nuevo.Debilidad.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificarPokemon(Pokemon poke)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update POKEMONS set Numero = @Numero, Nombre = @Nombre, UrlImagen = @UrlImagen, Descripcion = @Descripcion, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad where id = @Id");
                datos.setearParametro("@Numero", poke.Numero);
                datos.setearParametro("@Nombre", poke.Nombre);
                datos.setearParametro("@UrlImagen", poke.UrlImagen);
                datos.setearParametro("@Descripcion", poke.Descripcion);
                datos.setearParametro("@IdTipo", poke.Tipo.Id);
                datos.setearParametro("@IdDebilidad", poke.Debilidad.Id);
                datos.setearParametro("@Id", poke.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
