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
        public string Jugadorees { get; set; }

        public List<Jugadores>

        public Jugadores()
        {
            Nombre = "nombre";
            Ciudad = "Sin ciudad";
                Entrenador = "Sin entrenado";
            Jugadores = "9"
        }

        public Jugadores(string nombre)
        {
            Nombre = nombre;
            Ciudad = "sin ciudad";
            Entrenador = "Sin entrenador";
            Jugadores = "9";
        }
}
