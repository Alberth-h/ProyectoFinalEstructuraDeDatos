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
using System.Collections.ObjectModel;

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Elemento> Elementos = new ObservableCollection<Elemento>();
        public MainWindow()
        {
            InitializeComponent();
            Elementos.Add(new Elemento("ayuwoki", "2019", "terror", "0", "drossito bb", "una noche espeluzante con el hehe", "5"));
            lsNombreAnno.ItemsSource = Elementos;
        }

        private void BtnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Children.Add(new NuevoElemento());
            grdInterfaz.Visibility = Visibility.Visible;
            btnGuardarElemento.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnNuevoElemento.Visibility = Visibility.Hidden;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Children.Remove(new NuevoElemento());
            grdInterfaz.Children.Remove(new VisualizarElemento());
            grdInterfaz.Children.Remove(new EditarElemento());
            grdInterfaz.Visibility = Visibility.Hidden;
            btnGuardarElemento.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnActualizarElemento.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Visible;
        }

        private void BtnGuardarElemento_Click(object sender, RoutedEventArgs e)
        {
            NuevoElemento nuevoElemento = new NuevoElemento();
            Elementos.Add(new Elemento(nuevoElemento.txtTituloNuevoElemento.Text, nuevoElemento.txtAnnoNuevoElemento.Text, nuevoElemento.txtGeneroNuevoElemento.Text, nuevoElemento.txtTemporadasNuevoElemento.Text, nuevoElemento.txtProductorNuevoElemento.Text, nuevoElemento.txtDescripcionNuevoElemento.Text, nuevoElemento.txtRatingNuevoElemento.Text));
            nuevoElemento.txtTituloNuevoElemento.Text = "";
            nuevoElemento.txtAnnoNuevoElemento.Text = "";
            nuevoElemento.txtGeneroNuevoElemento.Text = "";
            nuevoElemento.txtTemporadasNuevoElemento.Text = "";
            nuevoElemento.txtProductorNuevoElemento.Text = "";
            nuevoElemento.txtDescripcionNuevoElemento.Text = "";
            nuevoElemento.txtRatingNuevoElemento.Text = "";
        }

        private void LsNombreAnno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NuevoElemento nuevoElemento = new NuevoElemento();
            if (lsNombreAnno.SelectedIndex != -1)
            {
                nuevoElemento.txtTituloNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].titulo;
                nuevoElemento.txtAnnoNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].anno;
                nuevoElemento.txtGeneroNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].genero;
                nuevoElemento.txtTemporadasNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].temporadas;
                nuevoElemento.txtProductorNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].productor;
                nuevoElemento.txtDescripcionNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].descripcion;
                nuevoElemento.txtRatingNuevoElemento.Text = Elementos[lsNombreAnno.SelectedIndex].rating;
            }

            lsNombreAnno.ItemsSource = Elementos;
        }
    }
}
