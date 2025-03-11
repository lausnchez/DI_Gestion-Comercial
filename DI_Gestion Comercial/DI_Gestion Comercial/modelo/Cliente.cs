using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace DI_Gestion_Comercial.modelo
{
    internal class Cliente
    {
        public int Cod_Cli {  get; set; }
        public string Nombre {  get; set; }
        public string Apellidos {  get; set; }
        public string Telefono {  get; set; }
        public string Direccion {  get; set; }
        public DateTime Fecha_Alta { get; set; }
        public double totalGastado{ get; set; }

        public Cliente()
        {
        }

        public Cliente(int Cod_Cli, string Nombre, string Apellidos, string Telefono, string Direccion, DateTime Fecha)
        {
            this.Cod_Cli = Cod_Cli;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Fecha_Alta = Fecha;
        }

        public Cliente(string Nombre, string Apellidos, string Telefono, string Direccion, DateTime Fecha)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Fecha_Alta = Fecha;
        }

        public static List<Cliente> GetListaClientes() 
        {
            Database db = new Database();
            try
            {
                string query = "SELECT * FROM Cliente";
                MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                List<Cliente> listadoClientes = new List<Cliente>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    Cliente cliente = new Cliente();
                    cliente.Cod_Cli = int.Parse(reader["Cod_Cli"].ToString());
                    cliente.Nombre = reader["Nombre"].ToString();
                    cliente.Apellidos = reader["Apellidos"].ToString();
                    cliente.Telefono = reader["Telefono"].ToString();
                    cliente.Direccion = reader["Direccion"].ToString();
                    cliente.Fecha_Alta = DateTime.Parse(reader["Fecha_Alta"].ToString());
                    listadoClientes.Add(cliente);
                }
                db.desconectarConexion();
                return listadoClientes;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public static Boolean agregarNuevoClienteBBDD(string Nombre, string Apellidos, string Telefono, string Direccion, DateTime Fecha)
        {
            Database db = new Database();
            try
            {

                string query = "INSERT INTO producto" +
                "(Nombre, Apellidos, Telefono, Direccion, Fecha)" +
                " VALUES(" +
                Nombre +"," +
                Apellidos + "," +
                Telefono + "," +
                Direccion + "," +
                Fecha + ")";
                MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha agregado el cliente con éxito", "Éxito al agregar", MessageBoxButton.OK);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo agregar el cliente a la base de datos\n" + ex, "Error al agregar cliente", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            finally
            {
                db.desconectarConexion();
            }
        }

    }
}
