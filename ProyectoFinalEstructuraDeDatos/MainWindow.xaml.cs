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
            Elementos.Add(new Elemento("el ayuwoki", "2019", "terror", "0", "drossito bb", "una espeluznante noche del hehe", "5"));
            Elementos.Add(new Elemento("cj vuelve al barrio", "2004", "accion", "0", "la roka jam", "un ganster recuperando lo que perdio", "4"));
            Elementos.Add(new Elemento("vida lejos del rancho", "2016", "comedia", "3", "rodolfo M.", "un foraneo se va a vivir en la ciudad", "3"));
            lsNombreAnno.ItemsSource = Elementos;
        }

        private void BtnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Children.Add(new NuevoElemento());
            grdInterfaz.Visibility = Visibility.Visible;
            btnGuardarElemento.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnActualizarElemento.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Hidden;
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAnnoUp.Visibility = Visibility.Hidden;
            btnAnnoDown.Visibility = Visibility.Hidden;

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Children.Clear();
            grdInterfaz.Visibility = Visibility.Hidden;
            btnGuardarElemento.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnActualizarElemento.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAnnoUp.Visibility = Visibility.Visible;
            btnAnnoDown.Visibility = Visibility.Visible;
        }

        private void LsNombreAnno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (lsNombreAnno.SelectedIndex != -1)
            {
                grdInterfaz.Children.Clear();
                grdInterfaz.Children.Add(new VisualizarElemento());
                grdInterfaz.Visibility = Visibility.Visible;
                btnGuardarElemento.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Visible;
                btnNuevoElemento.Visibility = Visibility.Hidden;
                btnHabilitarEdicion.Visibility = Visibility.Visible;
                btnEliminarElemento.Visibility = Visibility.Visible;
                btnActualizarElemento.Visibility = Visibility.Hidden;
                btnOrdenarAZ.Visibility = Visibility.Hidden;
                btnOrdenarZA.Visibility = Visibility.Hidden;
                btnAnnoUp.Visibility = Visibility.Hidden;
                btnAnnoDown.Visibility = Visibility.Hidden;

                ((VisualizarElemento)(grdInterfaz.Children[0])).txtTituloVizualizar.Text = Elementos[lsNombreAnno.SelectedIndex].Titulo;
                ((VisualizarElemento)(grdInterfaz.Children[0])).txtAnnoVizualizar.Text = Elementos[lsNombreAnno.SelectedIndex].Anno;
                ((VisualizarElemento)(grdInterfaz.Children[0])).txtGeneroVizualizar.Text = Elementos[lsNombreAnno.SelectedIndex].Genero;
                ((VisualizarElemento)(grdInterfaz.Children[0])).txtTemporadasVizualizar.Text = Elementos[lsNombreAnno.SelectedIndex].Temporada;
                ((VisualizarElemento)(grdInterfaz.Children[0])).txtProductorVizualizar.Text = Elementos[lsNombreAnno.SelectedIndex].Productor;
                ((VisualizarElemento)(grdInterfaz.Children[0])).txtDescripcionVizualizar.Text = Elementos[lsNombreAnno.SelectedIndex].Descripcion;

                if (Elementos[lsNombreAnno.SelectedIndex].Rating == "0")
                {
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella1.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella2.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella3.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella4.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella5.Visibility = Visibility.Hidden;
                }
                if (Elementos[lsNombreAnno.SelectedIndex].Rating == "1")
                {
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella1.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella2.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella3.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella4.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella5.Visibility = Visibility.Hidden;
                }
                if (Elementos[lsNombreAnno.SelectedIndex].Rating == "2")
                {
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella1.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella2.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella3.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella4.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella5.Visibility = Visibility.Hidden;
                }
                if (Elementos[lsNombreAnno.SelectedIndex].Rating == "3")
                {
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella1.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella2.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella3.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella4.Visibility = Visibility.Hidden;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella5.Visibility = Visibility.Hidden;
                }
                if (Elementos[lsNombreAnno.SelectedIndex].Rating == "4")
                {
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella1.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella2.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella3.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella4.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella5.Visibility = Visibility.Hidden;
                }
                if (Elementos[lsNombreAnno.SelectedIndex].Rating == "5")
                {
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella1.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella2.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella3.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella4.Visibility = Visibility.Visible;
                    ((VisualizarElemento)(grdInterfaz.Children[0])).imgEstrella5.Visibility = Visibility.Visible;
                }
            }
        }

        private void BtnGuardarElemento_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Visibility = Visibility.Hidden;
            btnGuardarElemento.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnActualizarElemento.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAnnoUp.Visibility = Visibility.Visible;
            btnAnnoDown.Visibility = Visibility.Visible;

            ((NuevoElemento)(grdInterfaz.Children[0])).lblPeliculaNuevoElemento.Visibility = Visibility.Hidden;
            ((NuevoElemento)(grdInterfaz.Children[0])).lblSerieNuevoElemento.Visibility = Visibility.Hidden;
            ((NuevoElemento)(grdInterfaz.Children[0])).rdbPeliculaNuevoElemento.Visibility = Visibility.Visible;
            ((NuevoElemento)(grdInterfaz.Children[0])).rdbSerieNuevoElemento.Visibility = Visibility.Visible;
            ((NuevoElemento)(grdInterfaz.Children[0])).lblTipoNuevoElemento.Visibility = Visibility.Visible;

            Elementos.Add(new Elemento(((NuevoElemento)(grdInterfaz.Children[0])).txtTituloNuevoElemento.Text, ((NuevoElemento)(grdInterfaz.Children[0])).txtAnnoNuevoElemento.Text, ((NuevoElemento)(grdInterfaz.Children[0])).txtGeneroNuevoElemento.Text, ((NuevoElemento)(grdInterfaz.Children[0])).txtTemporadasNuevoElemento.Text, ((NuevoElemento)(grdInterfaz.Children[0])).txtProductorNuevoElemento.Text, ((NuevoElemento)(grdInterfaz.Children[0])).txtDescripcionNuevoElemento.Text, ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text));
            ((NuevoElemento)(grdInterfaz.Children[0])).txtTituloNuevoElemento.Text = "";
            ((NuevoElemento)(grdInterfaz.Children[0])).txtAnnoNuevoElemento.Text = "";
            ((NuevoElemento)(grdInterfaz.Children[0])).txtGeneroNuevoElemento.Text = "";
            ((NuevoElemento)(grdInterfaz.Children[0])).txtTemporadasNuevoElemento.Text = "";
            ((NuevoElemento)(grdInterfaz.Children[0])).txtTemporadasNuevoElemento.Text = "";
            ((NuevoElemento)(grdInterfaz.Children[0])).txtDescripcionNuevoElemento.Text = "";
            ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text = "";
            if (((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text == "0" || ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text == "1" || ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text == "2" || ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text == "3" || ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text == "4" || ((NuevoElemento)(grdInterfaz.Children[0])).txtRatingNuevoElemento.Text == "5")
            {
                lblException.Visibility = Visibility.Hidden;
            }
            else
            {
                lblException.Visibility = Visibility.Visible;
                grdInterfaz.Children.Clear();
            }
            grdInterfaz.Children.Clear();
        }

        private void BtnAnnoUp_Click(object sender, RoutedEventArgs e)
        {
            int gap, i, j;
            gap = Elementos.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < Elementos.Count; i++)
                {
                    if (gap + i < Elementos.Count && int.Parse(Elementos[i].Anno) < int.Parse(Elementos[gap + i].Anno))
                    {
                        var temp = Elementos[i];
                        Elementos[i] = Elementos[gap + i];
                        Elementos[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void BtnAnnoDown_Click(object sender, RoutedEventArgs e)
        {
            int gap, i, j;
            gap = Elementos.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < Elementos.Count; i++)
                {
                    if (gap + i < Elementos.Count && int.Parse(Elementos[i].Anno) > int.Parse(Elementos[gap + i].Anno))
                    {
                        var temp = Elementos[i];
                        Elementos[i] = Elementos[gap + i];
                        Elementos[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void BtnOrdenarAZ_Click(object sender, RoutedEventArgs e)
        {
            bool aux;
            do
            {
                aux = false;
                for (int i = 0; i < (Elementos.Count - 1); i++)
                {
                    if (string.Compare(Elementos[i].Titulo, Elementos[i + 1].Titulo) > 0)
                    {
                        var temp = Elementos[i];
                        Elementos[i] = Elementos[i + 1];
                        Elementos[i + 1] = temp;
                        aux = true;
                    }
                }
            } while (aux == true);
        }

        private void BtnOrdenarZA_Click(object sender, RoutedEventArgs e)
        {
            bool aux;
            do
            {
                aux = false;
                for (int i = 0; i < (Elementos.Count - 1); i++)
                {
                    if (string.Compare(Elementos[i].Titulo, Elementos[i + 1].Titulo) < 0)
                    {
                        var temp = Elementos[i];
                        Elementos[i] = Elementos[i + 1];
                        Elementos[i + 1] = temp;
                        aux = true;
                    }
                }
            } while (aux == true);
        }

        private void BtnHabilitarEdicion_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Children.Clear();
            grdInterfaz.Children.Add(new EditarElemento());
            grdInterfaz.Visibility = Visibility.Visible;
            btnGuardarElemento.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Visible;
            btnNuevoElemento.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Visible;
            btnActualizarElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAnnoUp.Visibility = Visibility.Hidden;
            btnAnnoDown.Visibility = Visibility.Hidden;

            ((EditarElemento)(grdInterfaz.Children[0])).txtTituloEditar.Text = Elementos[lsNombreAnno.SelectedIndex].Titulo;
            ((EditarElemento)(grdInterfaz.Children[0])).txtAnnoEditar.Text = Elementos[lsNombreAnno.SelectedIndex].Anno;
            ((EditarElemento)(grdInterfaz.Children[0])).txtGeneroEditar.Text = Elementos[lsNombreAnno.SelectedIndex].Genero;
            ((EditarElemento)(grdInterfaz.Children[0])).txtTemporadasEditar.Text = Elementos[lsNombreAnno.SelectedIndex].Temporada;
            ((EditarElemento)(grdInterfaz.Children[0])).txtProductorEditar.Text = Elementos[lsNombreAnno.SelectedIndex].Productor;
            ((EditarElemento)(grdInterfaz.Children[0])).txtDescripcionEditar.Text = Elementos[lsNombreAnno.SelectedIndex].Descripcion;
        }

        private void BtnEliminarElemento_Click(object sender, RoutedEventArgs e)
        {
            if (lsNombreAnno.SelectedIndex != -1)
            {
                Elementos.RemoveAt(lsNombreAnno.SelectedIndex);
            }
        }

        private void BtnActualizarElemento_Click(object sender, RoutedEventArgs e)
        {
            grdInterfaz.Visibility = Visibility.Hidden;
            btnGuardarElemento.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnActualizarElemento.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAnnoUp.Visibility = Visibility.Visible;
            btnAnnoDown.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAnnoUp.Visibility = Visibility.Hidden;
            btnAnnoDown.Visibility = Visibility.Hidden;

            if (lsNombreAnno.SelectedIndex != -1)
            {
                Elementos[lsNombreAnno.SelectedIndex].Titulo = ((EditarElemento)(grdInterfaz.Children[0])).txtTituloEditar.Text;
                Elementos[lsNombreAnno.SelectedIndex].Anno = ((EditarElemento)(grdInterfaz.Children[0])).txtAnnoEditar.Text;
                Elementos[lsNombreAnno.SelectedIndex].Genero = ((EditarElemento)(grdInterfaz.Children[0])).txtGeneroEditar.Text;
                Elementos[lsNombreAnno.SelectedIndex].Temporada = ((EditarElemento)(grdInterfaz.Children[0])).txtTemporadasEditar.Text;
                Elementos[lsNombreAnno.SelectedIndex].Productor = ((EditarElemento)(grdInterfaz.Children[0])).txtProductorEditar.Text;
                Elementos[lsNombreAnno.SelectedIndex].Descripcion = ((EditarElemento)(grdInterfaz.Children[0])).txtDescripcionEditar.Text;
                Elementos[lsNombreAnno.SelectedIndex].Rating = ((EditarElemento)(grdInterfaz.Children[0])).txtRatingEditar.Text;
            }
            lsNombreAnno.Items.Refresh();
            grdInterfaz.Children.Clear();
        }
    }
}
