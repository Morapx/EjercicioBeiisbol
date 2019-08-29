using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBeisbol
{
    class Equipo
    {
        
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

        public string Entrenador { get; set; }

        public List<Jugadores> Jugador { get; set; }

        public Equipo()
        {
            Nombre = "nombre: ";
            Ciudad = "Sin ciudad";
                Entrenador = "Sin entrenado";
          
        }

        public Equipo(string nombre, string ciudad, string entrenador)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            Entrenador = entrenador;
            Jugador = new List<Jugadores>();

        }
    }
}
