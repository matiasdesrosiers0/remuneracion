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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Liquidaciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            Liquidacion frmNuevoCliente = new Liquidacion();

            Canvasmenu.Children.Clear();
            Canvasmenu.Children.Add(frmNuevoCliente);
            
        }

        private void CONTACTO_Click(object sender, RoutedEventArgs e)
        {
            contacto frmNuevoCliente = new contacto();

            Canvasmenu.Children.Clear();
            Canvasmenu.Children.Add(frmNuevoCliente);

        }

       

       

      
    }
}
