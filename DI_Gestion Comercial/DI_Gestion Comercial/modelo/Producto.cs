using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DI_Gestion_Comercial.modelo
{
    internal class Producto
    {
        public int Cod_Pro {  get; set; }
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public double Precio {  get; set; }
        public int Stock {  get; set; }
        public string Foto {  get; set; }
        public int Cod_Prov {  get; set; }
        public string Nombre_Proveedor {  get; set; }
        public int Cod_Aut {  get; set; }
        public string Nombre_Autor {  get; set; }
        public DateTime Fecha {  get; set; }
        public string Formato {  get; set; }
        public int Cod_Gen {  get; set; }
        public string Nombre_Genero {  get; set; }

        public Producto()
        {
            this.Cod_Pro = -1;
            this.Cod_Prov = -1;
            this.Cod_Aut = -1;
            this.Cod_Gen = -1;
            this.Nombre = "";
            this.Precio = 0;
            this.Stock = 0;
            this.Fecha = DateTime.Today;
        }

        public Producto(int Cod_Pro, string Nombre, string Descripcion, double Precio, int Stock, string Foto, int Cod_Prov, int Cod_Aut, DateTime Fecha, string Formato, int Cod_Gen)
        {
            this.Cod_Pro = Cod_Pro;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Foto = Foto;
            this.Cod_Prov = Cod_Prov;
            this.Cod_Aut = Cod_Aut;
            this.Fecha = Fecha;
            this.Formato = Formato;
            this.Cod_Gen = Cod_Gen;
        }

        public Producto(int Cod_Pro, string Nombre, double Precio, int Stock, int Cod_Prov, int Cod_Aut, DateTime Fecha, int Cod_Gen)
        {
            this.Cod_Pro = Cod_Pro;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Cod_Prov = Cod_Prov;
            this.Cod_Aut = Cod_Aut;
            this.Fecha = Fecha;
            this.Cod_Gen = Cod_Gen;
        }

        public static Boolean agregarNuevoProductoBBDD(string Nombre, string Descripcion, double Precio, int Stock, string Foto, int Cod_Prov, int Cod_Aut, string Fecha, string Formato, int Cod_Gen)
        {
            Database db = new Database();
            try
            {
                
                    string query = "INSERT INTO producto" +
                    "(Nombre, Descripcion, Precio, Stock, Foto, Cod_Prov, Cod_Aut, Fecha, Formato, Cod_Gen)" +
                    " VALUES('" 
                    + Nombre + "','"
                    + Descripcion + "',"
                    + Precio + ","
                    + Stock + ",'"
                    + Foto + "',"
                    + Cod_Prov + ","
                    + Cod_Aut + ",'"
                    + Fecha + "','"
                    + Formato + "',"
                    + Cod_Gen +
                    ")";
                MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha agregado el producto con éxito", "Éxito al agregar", MessageBoxButton.OK);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo agregar el producto a la base de datos\n" + ex, "Error al agregar producto", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            finally
            {
                db.desconectarConexion();
            }
        }

        public static List<Producto> GetListProductos() { 
            Database db = new Database();
            try
            {
                string query = "SELECT producto.Cod_Pro, producto.Nombre, producto.Descripcion, producto.Precio," +
                    " producto.Stock, producto.Foto, proveedor.Nombre \"nombreProveedor\", autores.Nombre \"nombreAutor\", producto.Fecha, " +
                    "producto.Formato, generos.Nombre \"nombreGenero\", producto.Cod_Prov, producto.Cod_Aut, producto.Cod_Gen" +
                    " FROM producto, autores, generos, proveedor " +
                    "WHERE producto.Cod_Aut = autores.Cod_Aut " +
                    "AND producto.Cod_Prov = proveedor.Cod_Prov " +
                    "AND producto.Cod_Gen = generos.Cod_Gen;";
                MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                List<Producto> listado = new List<Producto>();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Cod_Pro = int.Parse(reader["Cod_Pro"].ToString());
                    producto.Nombre = reader["Nombre"].ToString();
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Precio = double.Parse(reader["Precio"].ToString());
                    producto.Stock = int.Parse(reader["Stock"].ToString());
                    producto.Foto = reader["Foto"].ToString();
                    producto.Cod_Prov = int.Parse(reader["Cod_Prov"].ToString());
                    producto.Cod_Aut = int.Parse(reader["Cod_Aut"].ToString());
                    producto.Fecha = DateTime.Parse(reader["Fecha"].ToString());
                    producto.Formato = reader["Formato"].ToString();
                    producto.Cod_Gen = int.Parse(reader["Cod_Gen"].ToString());
                    
                    producto.Nombre_Autor = reader["nombreAutor"].ToString();
                    producto.Nombre_Proveedor = reader["nombreProveedor"].ToString();
                    producto.Nombre_Genero = reader["nombreGenero"].ToString();

                    listado.Add(producto);
                }
                db.desconectarConexion();
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
        }
    }
}
