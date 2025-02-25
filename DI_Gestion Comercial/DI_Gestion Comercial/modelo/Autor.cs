using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DI_Gestion_Comercial.modelo
{
    internal class Autor
    {
        public int Cod_Aut {  get; set; }
        public string Nombre {  get; set; }

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
    }
}
