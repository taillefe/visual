using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahjong
{
    class Jugador
    {
        public int posicion { get; set; }   // esto hay que ponerlo para que se vea por pantalla solo lectura
        public String nombre { get; set; }  // lectura y escritura
        public int tiempo { get; set; }

        public void setPosicion(int posicion)
        {
          //  this.posicion = posicion;
        }

        public int getPosicion()
        {
            return posicion;
        }

        public int getNombre()
        {
            return posicion;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setTiempo(int tiempo)
        {
            this.tiempo = tiempo;
        }

        public int getTiempo()
        {
            return tiempo;
        }
    }
}
