using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DI_Gestion_Comercial.modelo
{
    internal class Database
    {
        private string servidor = "localhost";
        private string puerto = "3306";
        private string bbdd = "gestioncomercial";
        private string usuario = "root";
        private string pwd = "";
        private string cadenaConexion = "";
        private MySqlConnection conexion;

        public Database()
        {
            cadenaConexion = "DataSource=" + servidor
                + "; Port=" + puerto
                + "; Database=" + bbdd
                + "; User=" + usuario
                + "; Password=" + pwd;
        }

        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar a la base de datos\n\n" + e.Message, "Error de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return conexion;
        }

        public void desconectarConexion()
        {
            conexion.Close();
        }

    }
}
