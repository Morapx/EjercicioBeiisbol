using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBeisbol
{
    class Jugadores
    {
        public string  Nombre {get; set;}
            public string Numero { get; set; }

        public Jugadores()
        {
            Nombre = "Sin nombre";
            Numero = "Sin numreo";
        }

        public Jugadores(string nombre)
        {
            Nombre = nombre;
            Numero = "sin numero";
        }
    }
}
