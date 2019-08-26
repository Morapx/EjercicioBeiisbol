using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> grupos = new List<Equipo>();

            Equipo Multis = new Equipo("Multis");
            Equipo Mecatronicos = new Equipo("Mecatronicos");

            grupos.Add(Multis);
            grupos.Add(Mecatronicos);

            Jugadores Pepe = new Jugadores("Pepe");
            Jugadores Gonzalo = new Jugadores("Gonzalo");
           Jugadores Ricardo = new Jugadores("Ricardo");
            Jugadores Milos = new Jugadores("Milos");
            Jugadores Eduardo = new Jugadores("Eduardo");
            Jugadores Miguel = new Jugadores("Miguel");
            Jugadores Mario = new Jugadores("Mario");
            Jugadores Luigi = new Jugadores("Luigi");
            Jugadores Jaime = new Jugadores("Jaime");

            Jugadores Jorge = new Jugadores("Jorge");
            Jugadores Gorge = new Jugadores("Gorge");
            Jugadores Waluigi = new Jugadores("Waluigi");
            Jugadores Mike  = new Jugadores("Mike");
            Jugadores Rolo = new Jugadores("Rolo");
            Jugadores Jose = new Jugadores("Jose");
            Jugadores Bryan = new Jugadores("Bryan");
            Jugadores Sam = new Jugadores("Sam");
            Jugadores Sumo = new Jugadores("Sumo");



            Multis.Jugadorees.Add(Pepe);
            Multis.Jugadorees.Add(Gonzalo);
            Multis.Jugadorees.Add(Ricardo);
            Multis.Jugadorees.Add(Milos);
            Multis.Jugadorees.Add(Eduardo);
            Multis.Jugadorees.Add(Miguel);
            Multis.Jugadorees.Add(Mario);
            Multis.Jugadorees.Add(Luigi);
            Multis.Jugadorees.Add(Jaime);

            Mecatronicos.Jugadorees.Add(Jorge);
            Mecatronicos.Jugadorees.Add(Gorge);
            Mecatronicos.Jugadorees.Add(Waluigi);
            Mecatronicos.Jugadorees.Add(Mike);
            Mecatronicos.Jugadorees.Add(Rolo);
            Mecatronicos.Jugadorees.Add(Jose);
            Mecatronicos.Jugadorees.Add(Bryan);
            Mecatronicos.Jugadorees.Add(Sam);
            Mecatronicos.Jugadorees.Add(Sumo);

            foreach (Equipo equipo in equipo)
            {
                Console.WriteLine("Grupos" + grupo.Codigo);
                Console.WriteLine("Materia" + grupo.Materia);
                Console.WriteLine("Lista de alumnos");
                foreach (Alumno alumno in grupo.Alumno)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }
            }

            Console.Read();
        }
    }
}
