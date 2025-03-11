using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace DI_Gestion_Comercial.modelo
{
    internal class Autor
    {
        public int Cod_Aut {  get; set; }
        public string Nombre {  get; set; }
        public int numProductos {  get; set; }

        public Autor() 
        {
            this.Cod_Aut = -1;
            this.Nombre = "";
        }

        public Autor(int Cod_Aut, string Nombre)
        {
            this.Cod_Aut = Cod_Aut;
            this.Nombre = Nombre;
        }

        public static List<Autor> GetAllAutores()
        {
            List<Autor> listadoAutores = new List<Autor>();
            Database db = new Database();
            string query = "SELECT * FROM autores";
            MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                Autor autor = new Autor();
                autor.Cod_Aut = int.Parse(reader["Cod_Aut"].ToString());
                autor.Nombre = reader["Nombre"].ToString();

                // Buscar número de productos
                autor.numProductos = contarProductos(autor.Nombre);

                listadoAutores.Add(autor);
            }
            db.desconectarConexion();
            return listadoAutores;
        }

        public static List<string> getAllNombreAutores()
        {
            List<Autor> listadoAutores = GetAllAutores();  
            List<string> nombresAutores = new List<string>() { };
            foreach (Autor aut in listadoAutores)
            {
                string nombre = aut.Cod_Aut + ": " + aut.Nombre;
                nombresAutores.Add(nombre);
            }
            return nombresAutores;
        }

        public static int contarProductos(string nombreAutor)
        {
            string query = "select count(*) from producto, autores where producto.cod_aut = autores.cod_aut and autores.nombre = \"" + nombreAutor +"\";";
            Database db = new Database();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = int.Parse(reader["count(*)"].ToString());
                }
                db.desconectarConexion();
                return count;
            } catch (Exception ex){throw ex;}
        }
    }
}
