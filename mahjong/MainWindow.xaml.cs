using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace mahjong
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ImageBrush ImageSource[,]  = new ImageBrush[4,4] { { "lisa.png", "lisa.png",  "bart.jpg","marge.png"}, { "lisa.png", "lisa.png",  "bart.jpg","marge.png"},
        //                                { "lisa.png", "lisa.png",  "bart.jpg","marge.png"},{ "lisa.png", "lisa.png",  "bart.jpg","marge.png"}};
        //ImageSource[1,1] = "lisa.png";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button botonPulsado = ((Button)sender); // sender es el boton que hemos pulsado y se puede saber en que posición está
            int columna = Grid.GetColumn(botonPulsado);
            int fila = Grid.GetRow(botonPulsado);
            //buscar en un array bidimensional de imágenes la fila y la columna que hemos pulsado


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // llamar a la ventana MessageBox si/no advertencia

            string message = "You did not enter a server name. Cancel this operation?";
            string caption = "Error Detected in Input";


            // Displays the MessageBox.
            MessageBoxResult result = MessageBox.Show("¿Quieres cerrar la aplicacion?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }

        }
    }
}
