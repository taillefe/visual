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
            // aqui se indeca cual es el data contesxt
            // si this.DataContext =this;
            // los datos están en esta propia pantalla
            // si están en viewmodel hay  que hacer
            this.DataContext = new HallOfFameViewModel();  // se crea un contexto de tipo viewModel

            InitializeComponent();



        }

        private void btnResetear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // cerrar pantalla
            this.Close();
        }
    }
}
