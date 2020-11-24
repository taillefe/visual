using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahjong
{
    class HallOfFameViewModel
    {
        // puede tener datos y metodos
        // aqui hay que poblar la lista
        public List<Jugador> listaJugadores { get; }
     
        //constructor
        public HallOfFameViewModel()
        {

            // llenar la lista
            listaJugadores = new List<Jugador>();  // definir una lista antes de llenarla
            listaJugadores = obtenerListaJugadores();


        }

        public List<Jugador> obtenerListaJugadores()
        {
            Jugador j = new Jugador();
            j.posicion = 1;          // no hace falta definir getters y setters, se accede directamente               
            j.setNombre("Jose");
            j.setTiempo(200);
            listaJugadores.Add(j);
            j = new Jugador();        // definir un nuevo jugador cada vez que lo añadimos a la lista
            j.posicion = 2;
            j.setNombre("Pedro");
            j.setTiempo(300);
            listaJugadores.Add(j);
            j = new Jugador();
            j.posicion = 3;
            j.setNombre("Carlos Arturo Antonio Adolfo Aniceto");
            j.setTiempo(400);
            listaJugadores.Add(j);

            return listaJugadores;
        }


    }
}
