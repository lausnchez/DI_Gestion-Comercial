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
    internal class ControladorPantallaPrincipal
    {
        public static void volcarProductosEnListBox(ListBox listBox)
        {
            List<Producto> listaProductosGeneral = Producto.GetListProductos();
            if (listaProductosGeneral == null)
            {
                MessageBox.Show("No existen productos actualmente");
            }
            else
            {
                //listBox.Items.Clear();
                listBox.ItemsSource = listaProductosGeneral;
            }     
        }
    }
}
