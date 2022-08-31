using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PARA PODER CONECTARLO A UNA BASE DE DATOS: 
using System.Data.SqlClient;


namespace project_Pokemon
{
    internal class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection(); //Se conecta a cierta conexion
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;// Al realizar la lectura, obtengo la instancia de un objeto

            try
            {
                conexion.ConnectionString = "Server = DESKTOP-D2JTRHQ\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Numero, Nombre, Descripcion FROM POKEMONS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) //Si puede leer un registro, devuelve true y posiciona un puntero en la primera fila de la tabla de la BD
                {
                    Pokemon aux = new Pokemon();                
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();

            }

        }
    }
}
