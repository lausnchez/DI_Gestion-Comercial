using DI_Gestion_Comercial.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DI_Gestion_Comercial.controlador
{
    internal class ControladorAgregarProductos
    {
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

        public Producto crearProducto(TextBox nombre, TextBox precio, TextBox stock, TextBox formato, ComboBox autor, ComboBox proveedor, ComboBox genero, Image imagen, DatePicker fecha)
        {
            // Comprobar los datos
            Boolean valoresValidos = true;
            string error = "";

            // Comprobar si están vacíos los campos
            if (nombre.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Nombre";
                valoresValidos = false;
            }
            if (precio.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Precio";
                valoresValidos = false;
            }
            if (stock.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Stock";
                valoresValidos = false;
            }
            if (formato.Text.Trim().Length == 0)
            {
                error += "Debe rellenar el campo Formato";
                valoresValidos = false;
            }
            if (autor.SelectedIndex == -1)
            {
                error += "Debe seleccionar un Autor";
                valoresValidos = false;
            }
            if (proveedor.SelectedIndex == -1)
            {
                error += "Debe seleccionar un Proveedor";
                valoresValidos = false;
            }
            if (genero.SelectedIndex == -1)
            {
                error += "Debe seleccionar un Género";
                valoresValidos = false;
            }
            if (fecha.SelectedDate == null)
            {
                error += "Debe seleccionar una Fecha";
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

            return null;
        }

    }
}
