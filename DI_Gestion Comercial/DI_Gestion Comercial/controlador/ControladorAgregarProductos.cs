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

    }
}
