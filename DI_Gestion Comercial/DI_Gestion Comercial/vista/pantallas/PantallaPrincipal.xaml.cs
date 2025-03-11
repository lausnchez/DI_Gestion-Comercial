using DI_Gestion_Comercial.controlador;
using DI_Gestion_Comercial.modelo;
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
            ControladorPantallaPrincipal.volcarProductosEnListBox(this);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PantallaNuevoProducto nuevoProducto = new PantallaNuevoProducto();
            nuevoProducto.ShowDialog();
            ControladorPantallaPrincipal.volcarProductosEnListBox(this);
        }

        private void btn_principalEstadísticas_Click(object sender, RoutedEventArgs e)
        {
            PantallaEstadisticas pantallaEstadisticas = new PantallaEstadisticas();
            pantallaEstadisticas.ShowDialog();
        }
        private void ItemDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }


        // Cambiar listados
        private void btn_filtrarProductos_Click(object sender, RoutedEventArgs e)
        {
            ControladorPantallaPrincipal.volcarProductosEnListBox(this);
            
        }

        private void btn_filtrarClientes_Click(object sender, RoutedEventArgs e)
        {
            ControladorPantallaPrincipal.volcarClientesEnListBox(this);
        }

        private void btn_filtrarProveedores_Click(object sender, RoutedEventArgs e)
        {
            ControladorPantallaPrincipal.volcarProveedoresEnListBox(this);
        }

        private void btn_filtrarAutores_Click(object sender, RoutedEventArgs e)
        {
            ControladorPantallaPrincipal.volcarAutoresEnListBox(this);
        }

        private void btn_filtrarGeneros_Click(object sender, RoutedEventArgs e)
        {
            ControladorPantallaPrincipal.volcarGenerosEnListBox(this);
        }

        private void ProductoDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Producto producto = (Producto)listadoProductos_principal.SelectedItem;
            ControladorPantallaPrincipal.mostrarVentanaDetalleProducto(Producto.GetProducto(producto.Cod_Pro));
        }
    }
}
