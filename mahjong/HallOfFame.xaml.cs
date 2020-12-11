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

namespace mahjong
{
    /// <summary>
    /// Lógica de interacción para HallOfFame.xaml
    /// </summary>
    public partial class HallOfFame : Window
    {

        // esto es lo que debe hacerse en viewModel
        // public List<Jugador> listaJugadores() { get;set; }
        public HallOfFame()
        {
            // aqui se indica cual es el data context
            // si this.DataContext =this;
            // los datos están en esta propia pantalla

            // si están en viewmodel hay  que hacer
            this.DataContext = new HallOfFameViewModel();  // se crea un contexto de tipo viewModel

            InitializeComponent();

           // DataGridHallOfFame.ItemsSource = HallOfFameViewModel.listaJugadores;  // equivalente a poner ItemSource en el xml

        }

        private void btnResetear_Click(object sender, RoutedEventArgs e)
        {
            HallOfFameViewModel.resetear();
            //DataGridHallOfFame.Items.Refresh();   // esto se usa si listaJugadores fuera una List
                                                    // con ObservableCollection, cuando se hace una modificacion en la lista
                                                    // ya se actualizan los datos en la pantalla
                                                    // eso se ha hecho con un foreach en HallOfFameViewModel
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // cerrar pantalla
            this.Close();
        }
    }
}
