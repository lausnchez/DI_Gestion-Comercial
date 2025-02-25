using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DI_Gestion_Comercial.modelo
{
    internal class Proveedor
    {
        public int Cod_Prov {  get; set; }
        public string Nombre {  get; set; }
        public string Contacto {  get; set; }
        public string Telefono {  get; set; }
        public string Direccion {  get; set; }

        public Proveedor()
        {
            this.Cod_Prov = -1;
            this.Nombre = "";
            this.Contacto = "";
            this.Telefono = "";
            this.Direccion = "";
        }

        public Proveedor(int Cod_Prov, string Nombre, string Contacto, string Telefono, string Direccion)
        {
            this.Cod_Prov = Cod_Prov;
            this.Nombre = Nombre;
            this.Contacto = Contacto;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }

        public static List<Proveedor> GetListProveedores()
        {
            Database db = new Database();
            try
            {
                List<Proveedor> listado = new List<Proveedor>();
                
                string query = "SELECT * FROM proveedor";
                MySqlCommand cmd = new MySqlCommand(query, db.establecerConexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);  
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {                    
                    Proveedor pro = new Proveedor();
                    pro.Cod_Prov = int.Parse(reader["Cod_Prov"].ToString());
                    pro.Nombre = reader["Nombre"].ToString();
                    pro.Contacto = reader["Contacto"].ToString();
                    pro.Telefono = reader["Telefono"].ToString();
                    pro.Direccion = reader["Direccion"].ToString();

                    listado.Add(pro);
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

        public static List<String> getNombreProveedores()
        {
            List<Proveedor> listadoProveedores = GetListProveedores();
            List<String> nombresProveedores = new List<string>
            {

            };  
            foreach (Proveedor prov in listadoProveedores)
            {
                string proveedorConID = prov.Cod_Prov + ": " + prov.Nombre;
                nombresProveedores.Add(proveedorConID);
            }
            return nombresProveedores;
        }
    }
}
