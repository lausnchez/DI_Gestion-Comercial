using DI_Gestion_Comercial.modelo;
using DI_Gestion_Comercial.vista.pantallas;
using Mysqlx.Cursor;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DI_Gestion_Comercial.controlador
{
    internal class ControladorAgregarProductos
    {
        string urlImagen = "";


        public void establecerNombresProveedores(ComboBox cBox)
        {
            cBox.Items.Clear();
            List<string> list = Proveedor.getNombreProveedores();
            cBox.ItemsSource = list;
        }

        public void establecerNombresAutores(ComboBox cBox)
        {
            cBox.Items.Clear();
            List<string> list = Autor.getAllNombreAutores();
            cBox.ItemsSource = list;
        }

        public void establecerNombresGeneros(ComboBox cBox)
        {
            cBox.Items.Clear();
            List<string> list = Genero.getAllNombreGeneros();
            cBox.ItemsSource = list;
        }

        public void crearProducto(PantallaNuevoProducto ventana ,TextBox nombre, TextBox desc, TextBox precio, TextBox stock, TextBox formato, ComboBox autor, ComboBox proveedor, ComboBox genero, Image imagen, DatePicker fecha)
        {
            if (ComprobarCampos(nombre, precio, stock, formato, autor, proveedor, genero, imagen, fecha))
            {
                // Guardar imagen internamente en el programa
                copiarImagen(imagen);
                DateTime fechaFormateada = fecha.SelectedDate.Value;
                string fechaSQL = fechaFormateada.ToString("yyyy-MM-dd");

                if (Producto.agregarNuevoProductoBBDD(
                    nombre.Text,
                    desc.Text,
                    Double.Parse(precio.Text),
                    int.Parse(stock.Text),
                    this.urlImagen.ToString(),
                    proveedor.SelectedIndex+1,
                    autor.SelectedIndex+1,
                    fechaSQL,
                    formato.Text,
                    genero.SelectedIndex + 1))
                {
                    ventana.Close();
                }
                
            }
            
        }

        /**
         * Copia la imagen que esté en el source en la carpeta local del proyecto
         */
        public void copiarImagen(Image imagen)
        {           
            string rutaImagen = "/vista/imagenes/vinyl_background.jpg";
            if (this.urlImagen != "")
            {
                string nombreImagen = this.urlImagen.Substring(this.urlImagen.LastIndexOf("/") + 1);
                rutaImagen = Path.Combine("/vista/imagenes/covers/", nombreImagen);
                System.IO.File.Copy(this.urlImagen, rutaImagen, true);
            }
            else urlImagen = rutaImagen;

        }

        public Boolean ComprobarCampos(TextBox nombre, TextBox precio, TextBox stock, TextBox formato, ComboBox autor, ComboBox proveedor, ComboBox genero, Image imagen, DatePicker fecha)
        {
            // Comprobar los datos
            Boolean valoresValidos = true;
            string error = "";

            // Comprobar si están vacíos los campos
            if (nombre.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Nombre\n";
                valoresValidos = false;
            }
            if (precio.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Precio\n";
                valoresValidos = false;
            }
            if (stock.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Stock\n";
                valoresValidos = false;
            }
            if (formato.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Formato\n";
                valoresValidos = false;
            }
            if (autor.SelectedIndex == -1)
            {
                error += "Debe seleccionar un Autor\n";
                valoresValidos = false;
            }
            if (proveedor.SelectedIndex == -1)
            {
                error += "Debe seleccionar un Proveedor\n";
                valoresValidos = false;
            }
            if (genero.SelectedIndex == -1)
            {
                error += "Debe seleccionar un Género\n";
                valoresValidos = false;
            }
            if (fecha.SelectedDate == null)
            {
                error += "Debe seleccionar una Fecha\n";
                valoresValidos = false;
            }

            // Comprobar si los campos tienen el tipo de dato correcto
            if (!Utils.comprobarFloat(precio.Text))
            {
                error += "Valor en el campo Precio no válido\n";
                valoresValidos = false;
            }
            if (!Utils.comprobarInt(stock.Text))
            {
                error += "Valor en el campo Stock no válido\n";
                valoresValidos = false;
            }

            if (!valoresValidos)
            {
                MessageBox.Show(error, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else return true;
        }

        public void seleccionarImagen(Image imagen)
        {
            String ruta = "";
            var dialog = new Microsoft.Win32.OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                this.urlImagen = dialog.FileName;
                imagen.Source = new BitmapImage(new Uri(dialog.FileName));
            }
            
        }

    }
}
