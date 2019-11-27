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

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para NuevoElemento.xaml
    /// </summary>
    public partial class NuevoElemento : UserControl
    {
        public NuevoElemento()
        {
            InitializeComponent();
        }

        private void RdbPeliculaNuevoElemento_Checked(object sender, RoutedEventArgs e)
        {
            lblPeliculaNuevoElemento.Visibility = Visibility.Visible;
            lblSerieNuevoElemento.Visibility = Visibility.Hidden;
            rdbPeliculaNuevoElemento.Visibility = Visibility.Hidden;
            rdbSerieNuevoElemento.Visibility = Visibility.Hidden;
            lblTipoNuevoElemento.Visibility = Visibility.Hidden;
        }

        private void RdbSerieNuevoElemento_Checked(object sender, RoutedEventArgs e)
        {
            lblPeliculaNuevoElemento.Visibility = Visibility.Hidden;
            lblSerieNuevoElemento.Visibility = Visibility.Visible;
            rdbPeliculaNuevoElemento.Visibility = Visibility.Hidden;
            rdbSerieNuevoElemento.Visibility = Visibility.Hidden;
            lblTipoNuevoElemento.Visibility = Visibility.Hidden;
        }
    }
}
