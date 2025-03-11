using DI_Gestion_Comercial.modelo;
using DI_Gestion_Comercial.vista.pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Gestion_Comercial.controlador
{
    internal class ControladorPantallaDetalleProducto
    {
        Producto producto { get; set; }
        
        public void volcarTextos(PantallaDetalleProducto pantalla, Producto producto)
        {
            pantalla.txt_nombreProducto.Text = producto.Nombre;
        }
    }
}
