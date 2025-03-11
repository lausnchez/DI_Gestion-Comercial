using DI_Gestion_Comercial.modelo;
using DI_Gestion_Comercial.vista.pantallas;
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
        public Producto Producto { get; set; }

        public static void volcarProductosEnListBox(PantallaPrincipal pantalla)
        {
            ListBox listBox = pantalla.listadoProductos_principal;
            // Ocultar listados
            pantalla.listadoClientes_principal.Visibility = Visibility.Hidden;
            pantalla.listadoProveedores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoAutores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoGeneros_principal.Visibility = Visibility.Hidden;

            // Volcar datos
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
            
            listBox.Visibility = Visibility.Visible;
        }

        public static void volcarClientesEnListBox(PantallaPrincipal pantalla)
        {
            ListBox listBox = pantalla.listadoClientes_principal;
            // Ocultar listados
            pantalla.listadoProductos_principal.Visibility = Visibility.Hidden;
            pantalla.listadoProveedores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoAutores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoGeneros_principal.Visibility = Visibility.Hidden;

            List<Cliente> clientes = Cliente.GetListaClientes();
            if (clientes == null)
            {
                MessageBox.Show("No existen clientes actualmente");
            }
            else
            {
                listBox.ItemsSource = clientes;
            }
            pantalla.listadoClientes_principal.Visibility = Visibility.Visible;
        }

        public static void volcarProveedoresEnListBox(PantallaPrincipal pantalla)
        {
            ListBox listBox = pantalla.listadoProveedores_principal;
            // Ocultar listados
            pantalla.listadoProductos_principal.Visibility = Visibility.Hidden;
            pantalla.listadoClientes_principal.Visibility = Visibility.Hidden;
            pantalla.listadoAutores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoGeneros_principal.Visibility = Visibility.Hidden;


            List<Proveedor> proveedores = Proveedor.GetListProveedores();
            if (proveedores == null)
            {
                MessageBox.Show("No existen proveedores actualmente");
            }
            else
            {
                listBox.ItemsSource = proveedores;
            }
            pantalla.listadoProveedores_principal.Visibility = Visibility.Visible;
        }

        public static void volcarAutoresEnListBox(PantallaPrincipal pantalla)
        {
            ListBox listBox = pantalla.listadoAutores_principal;
            // Ocultar listados
            pantalla.listadoProductos_principal.Visibility = Visibility.Hidden;
            pantalla.listadoClientes_principal.Visibility = Visibility.Hidden;
            pantalla.listadoProveedores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoGeneros_principal.Visibility = Visibility.Hidden;

            List<Autor> autores = Autor.GetAllAutores();
            if (autores == null)
            {
                MessageBox.Show("No existen autores actualmente");
            }
            else
            {
                listBox.ItemsSource = autores;
            }
            pantalla.listadoAutores_principal.Visibility = Visibility.Visible;
        }

        public static void volcarGenerosEnListBox(PantallaPrincipal pantalla)
        {
            ListBox listBox = pantalla.listadoGeneros_principal;
            // Ocultar listados
            pantalla.listadoProductos_principal.Visibility = Visibility.Hidden;
            pantalla.listadoClientes_principal.Visibility = Visibility.Hidden;
            pantalla.listadoProveedores_principal.Visibility = Visibility.Hidden;
            pantalla.listadoAutores_principal.Visibility = Visibility.Hidden;

            List<Genero> generos = Genero.GetAllGenero();
            if (generos == null)
            {
                MessageBox.Show("No existen generos actualmente");
            }
            else
            {
                listBox.ItemsSource = generos;
            }
            pantalla.listadoGeneros_principal.Visibility = Visibility.Visible;
        }

        public static void agregarAutor()
        {
            
        }

        public static void mostrarVentanaDetalleProducto(Producto prod)
        {
            PantallaDetalleProducto pantalla = new PantallaDetalleProducto(prod);
        }
    }
}
