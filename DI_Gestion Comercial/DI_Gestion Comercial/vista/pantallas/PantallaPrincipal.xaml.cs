using DI_Gestion_Comercial.controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DI_Gestion_Comercial.vista.pantallas
{
    /// <summary>
    /// Lógica de interacción para PantallaPrincipal.xaml
    /// </summary>
    public partial class PantallaPrincipal : Window
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            ControladorPantallaPrincipal.volcarProductosEnListBox(listadoProductos_principal);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PantallaNuevoProducto nuevoProducto = new PantallaNuevoProducto();
            nuevoProducto.ShowDialog();
        }
    }
}
