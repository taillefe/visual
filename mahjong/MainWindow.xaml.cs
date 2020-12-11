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

     // defino unos valores fijos de las imagenes para cada posicion 

        String[,] fuente = new String[4, 4] { { "bart.png", "marge.png",  "moe.png","krusty.png"}, { "maggie.png", "homer.png",  "lisa.png","milhouse.png"},
                                         { "marge.png", "maggie.png",  "bart.png","homer.png"},{ "moe.png", "krusty.png",  "lisa.png","milhouse.png"}};
     
     
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
            String imagen = fuente[columna, fila];          
            CambiarImagen(imagen, botonPulsado);

        }

        private void mniConfigurar_Click(object sender, RoutedEventArgs e)
        {
            // esto sería llamar a la ventana configurar con messageBox
            // Displays the MessageBox 
            //   MessageBoxResult result = MessageBox.Show("Tiempo de transicion", "Configuración", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            //  if (result == MessageBoxResult.Cancel)
            //  {
            //      // Closes the parent form.
            //      this.Close();
            // }

            // mostrar la pantalla configura
            Configura pantConfigura = new Configura();
            pantConfigura.ShowDialog();

        }

      
        private void mniExportar_Click(object sender, RoutedEventArgs e)
        {
            //Llamar a la ventana FileDialog

              
                // Configure save file dialog box
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Mahjong"; // Default file name
                dlg.DefaultExt = ".txt"; // Default file extension
                dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

                // Show save file dialog box
                Nullable<bool> result = dlg.ShowDialog();

                // Process save file dialog box results
                if (result == true)
                {
                    // Save document
                    string filename = dlg.FileName;
                }
               
                //esto sería para abrir fileDialog para lectura
/*
                // Configure open file dialog box
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".txt"; // Default file extension
                dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

                // Show open file dialog box
                Nullable<bool> result = dlg.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    string filename = dlg.FileName;
                }
               ////////////////////////////////////////////
  */   

        }

        private void mniSalir_Click(object sender, RoutedEventArgs e)
        {
            // llamar a la ventana MessageBox si/no advertencia

            // Displays the MessageBox.
            MessageBoxResult result = MessageBox.Show("¿Quieres cerrar la aplicacion?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void mniHall_Click(object sender, RoutedEventArgs e)
        {
            // mostrar otra pantalla con una lista de datos
            HallOfFame pantHaala = new HallOfFame();
            pantHaala.ShowDialog();
        }

        private void CambiarImagen(string imagen, Button boton)
        {
            // mandar la imagen pasada por parámetro al background del boton pulsado


            String directorioImagen = "../../" + imagen;
  
            Uri CURRENT_URI = new Uri(directorioImagen, UriKind.Relative);

       
             BitmapImage _bitmap = new BitmapImage();
            _bitmap.BeginInit();
            _bitmap.UriSource = CURRENT_URI;
            _bitmap.EndInit();
            ImageBrush _brush = new ImageBrush(_bitmap);
            boton.Background = _brush;
        }

        private void Window(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // llamar a la ventana MessageBox si/no advertencia

            // Displays the MessageBox.
            MessageBoxResult result = MessageBox.Show("¿Quieres cerrar la aplicacion?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                // Closes the parent form.
                e.Cancel = false;
            }
            else e.Cancel = true;


        }
    }
}
