using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahjong
{
    class HallOfFameViewModel
    {
        // puede tener datos y metodos
        // aqui hay que poblar la lista
        public static ObservableCollection<Jugador> listaJugadores { get; set; }  // al ser static se puede compartir por las distintas pantallas que se abran
     
        //constructor
        public HallOfFameViewModel()
        {
            // llenar la lista
            if (listaJugadores == null)  // la primera vez es nula, se crea y se rellena
            {
                listaJugadores = new ObservableCollection<Jugador>();  // definir una lista antes de llenarla
                obtenerListaJugadores().ForEach(a=>listaJugadores.Add(a));
            }
            // el resto de las veces no se hace nada y aparecen los datos guardados en la lista static

        }

        public static List<Jugador> obtenerListaJugadores()
        {
            List<Jugador> jugadoresIniciales = new List<Jugador>();
            Jugador j = new Jugador();
            j.posicion = 1;          // no hace falta definir getters y setters, se accede directamente               
            j.setNombre("Jose");
            j.setTiempo(200);
            jugadoresIniciales.Add(j);
            j = new Jugador();        // definir un nuevo jugador cada vez que lo añadimos a la lista
            j.posicion = 2;
            j.setNombre("Pedro");
            j.setTiempo(300);
            jugadoresIniciales.Add(j);
            j = new Jugador();
            j.posicion = 3;
            j.setNombre("Carlos Arturo Antonio Adolfo Aniceto");
            j.setTiempo(400);
            jugadoresIniciales.Add(j);
            j = new Jugador();
            j.posicion = 4;
            j.setNombre("Carlos Arturo ");
            j.setTiempo(400);
            jugadoresIniciales.Add(j);
            j = new Jugador();
            j.posicion = 5;
            j.setNombre("Carlos Arturo Antonio");
            j.setTiempo(400);
            jugadoresIniciales.Add(j);
            j = new Jugador();
            j.posicion = 6;
            j.setNombre("Carlos");
            j.setTiempo(400);
            jugadoresIniciales.Add(j);

            return jugadoresIniciales;
        }


        public static void resetear()
        {
            listaJugadores.Clear();
            obtenerListaJugadores().ForEach(a => listaJugadores.Add(a));
        }

    }
}
