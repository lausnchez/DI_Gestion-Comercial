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
using LiveCharts;
using LiveCharts.Wpf;

namespace DI_Gestion_Comercial.vista.pantallas
{
    /// <summary>
    /// Lógica de interacción para PantallaEstadisticas.xaml
    /// </summary>
    public partial class PantallaEstadisticas : Window
    {
        
        public SeriesCollection graficoTemperaturas { get; set; }
        public ChartValues<int> valoresTemperaturas = new ChartValues<int> { 10, 4, 6, 2, 13, 5, 9, 0, 7, 3, 11 };
        
        public PantallaEstadisticas()
        {
            InitializeComponent();
            graficoTemperaturas = new SeriesCollection{
                new LineSeries{
                    Values = valoresTemperaturas,
                    Title = "Mejores Clientes",
                    Fill = new SolidColorBrush(Color.FromArgb(50, 255, 0, 29)),
                    Stroke = Brushes.Crimson,
                    PointGeometrySize = 5
                }
            };
            DataContext = this;

        }

        private void est_mejoresClientes_Click(object sender, RoutedEventArgs e)
        {
            valoresTemperaturas = new ChartValues<int> { 8, 1, 12, 5, 3, 14, 6, 9, 7, 2, 0 };
            graficoTemperaturas.Clear();
            graficoTemperaturas = new SeriesCollection{
                new LineSeries{
                    Values = valoresTemperaturas,
                    Title = "Mejores Clientes",
                    Fill = new SolidColorBrush(Color.FromArgb(50, 255, 0, 29)),
                    Stroke = Brushes.Crimson,
                    PointGeometrySize = 5
                }
            };
            DataContext = this;
        }

        private void est_productoEstrella_Click(object sender, RoutedEventArgs e)
        {
            valoresTemperaturas = new ChartValues<int> { 5, 9, 2, 14, 6, 3, 11, 7, 1, 8, 12 };
            graficoTemperaturas.Clear();
            graficoTemperaturas = new SeriesCollection{
                new LineSeries{
                    Values = valoresTemperaturas,
                    Title = "Mejores Clientes",
                    Fill = new SolidColorBrush(Color.FromArgb(50, 255, 0, 29)),
                    Stroke = Brushes.Crimson,
                    PointGeometrySize = 5
                }
            };
            DataContext = this;
        }

        private void est_mayoresProveedores_Click(object sender, RoutedEventArgs e)
        {
            valoresTemperaturas = new ChartValues<int> {11, 7, 1, 8, 12 };
            graficoTemperaturas.Clear();
            graficoTemperaturas = new SeriesCollection{
                new LineSeries{
                    Values = valoresTemperaturas,
                    Title = "Mejores Clientes",
                    Fill = new SolidColorBrush(Color.FromArgb(50, 255, 0, 29)),
                    Stroke = Brushes.Crimson,
                    PointGeometrySize = 5
                }
            };
            DataContext = this;
        }

        private void est_totalMeses_Click(object sender, RoutedEventArgs e)
        {
            valoresTemperaturas = new ChartValues<int> { 5, 9, 2, 14, 6};
            graficoTemperaturas.Clear();
            graficoTemperaturas = new SeriesCollection{
                new LineSeries{
                    Values = valoresTemperaturas,
                    Title = "Mejores Clientes",
                    Fill = new SolidColorBrush(Color.FromArgb(50, 255, 0, 29)),
                    Stroke = Brushes.Crimson,
                    PointGeometrySize = 5
                }
            };
            DataContext = this;
        }
    }
}
