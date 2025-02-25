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
        public PantallaNuevoProducto()
        {    
            InitializeComponent();
            ControladorAgregarProductos cAgregarProductos = new ControladorAgregarProductos();
            cAgregarProductos.establecerNombresProveedores(cb_proveedorAgregarProducto);
            cAgregarProductos.establecerNombresAutores(cb_autorAgregarProducto);
            cAgregarProductos.establecerNombresGeneros(cb_generoAgregarProducto);
        }
    }
}
