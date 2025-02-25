using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Gestion_Comercial.modelo
{
    internal class Genero
    {
        public int Cod_Gen {  get; set; }
        public string Nombre {  get; set; }

        public Genero()
        {
            this.Cod_Gen = -1;
            this.Nombre = "";
        }

        public Genero(int Cod_Gen, string Nombre)
        {
            this.Cod_Gen = Cod_Gen;
            this.Nombre = Nombre;
        }

        public static List<Genero> GetAllGenero()
        {
            List<Genero> listadoGeneros = new List<Genero>();
            Database db = new Database();
            string query = "SELECT * FROM generos";
            MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Genero genero = new Genero();
                genero.Cod_Gen = int.Parse(reader["Cod_Gen"].ToString());
                genero.Nombre = reader["Nombre"].ToString();
                listadoGeneros.Add(genero);
            }
            db.desconectarConexion();
            return listadoGeneros;
        }

        public static List<string> getAllNombreGeneros()
        {
            List<Genero> listadoGenero = GetAllGenero();
            List<string> nombresAutores = new List<string>() { };
            foreach (Genero gen in listadoGenero)
            {
                string nombre = gen.Cod_Gen + ": " + gen.Nombre;
                nombresAutores.Add(nombre);
            }
            return nombresAutores;
        }
    }
}
