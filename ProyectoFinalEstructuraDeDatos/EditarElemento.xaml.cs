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
    /// Lógica de interacción para EditarElemento.xaml
    /// </summary>
    public partial class EditarElemento : UserControl
    {
        public EditarElemento()
        {
            InitializeComponent();
        }

        private void RdbPeliculaEditar_Checked(object sender, RoutedEventArgs e)
        {
            lblPeliculaEditar.Visibility = Visibility.Visible;
            lblSerieEditar.Visibility = Visibility.Hidden;
            rdbPeliculaEditar.Visibility = Visibility.Hidden;
            rdbSerieEditar.Visibility = Visibility.Hidden;
            lblTipoEditar.Visibility = Visibility.Hidden;
        }

        private void RdbSerieEditar_Checked(object sender, RoutedEventArgs e)
        {
            lblPeliculaEditar.Visibility = Visibility.Hidden;
            lblSerieEditar.Visibility = Visibility.Visible;
            rdbPeliculaEditar.Visibility = Visibility.Hidden;
            rdbSerieEditar.Visibility = Visibility.Hidden;
            lblTipoEditar.Visibility = Visibility.Hidden;
        }
    }
}
