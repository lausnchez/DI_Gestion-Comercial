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
    /// Lógica de interacción para PantallaNuevoProducto.xaml
    /// </summary>
    public partial class PantallaNuevoProducto : Window
    {
        ControladorAgregarProductos cAgregarProductos = new ControladorAgregarProductos();
        PantallaNuevoProducto instancia = null;

        public PantallaNuevoProducto()
        {    
            InitializeComponent();
            cAgregarProductos.establecerNombresProveedores(cb_proveedorAgregarProducto);
            cAgregarProductos.establecerNombresAutores(cb_autorAgregarProducto);
            cAgregarProductos.establecerNombresGeneros(cb_generoAgregarProducto);
            instancia = this;
        }

        private void btn_agregarProducto_Click(object sender, RoutedEventArgs e)
        {
            cAgregarProductos.crearProducto(
                this.instancia,
                txt_nombreAgregarProducto,
                txt_descripcionAgregarProducto,
                txt_precioAgregarProducto,
                txt_stockAgregarProducto,
                txt_formatoAgregarProducto,
                cb_autorAgregarProducto,
                cb_proveedorAgregarProducto,
                cb_generoAgregarProducto,
                img_agregarProducto,
                date_agregarProducto);
                
        }

        private void btn_seleccionarImagenAgregarProducto_Click(object sender, RoutedEventArgs e)
        {
            cAgregarProductos.seleccionarImagen(img_agregarProducto);
        }
    }
}
