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

            Equipo Multis = new Equipo("Multis", "Obregon", "Adan");
            Equipo Mecatronicos = new Equipo("Mecatronicos", "Hermosillo", "Memo");

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



            Multis.Jugador.Add(Pepe);
            Multis.Jugador.Add(Gonzalo);
            Multis.Jugador.Add(Ricardo);
            Multis.Jugador.Add(Milos);
            Multis.Jugador.Add(Eduardo);
            Multis.Jugador.Add(Miguel);
            Multis.Jugador.Add(Mario);
            Multis.Jugador.Add(Luigi);
            Multis.Jugador.Add(Jaime);

            Mecatronicos.Jugador.Add(Jorge);
            Mecatronicos.Jugador.Add(Gorge);
            Mecatronicos.Jugador.Add(Waluigi);
            Mecatronicos.Jugador.Add(Mike);
            Mecatronicos.Jugador.Add(Rolo);
            Mecatronicos.Jugador.Add(Jose);
            Mecatronicos.Jugador.Add(Bryan);
            Mecatronicos.Jugador.Add(Sam);
            Mecatronicos.Jugador.Add(Sumo);

            foreach (Equipo Equipos in grupos)
            {
                Console.WriteLine("Ciudad: " + Equipos.Ciudad);
                Console.WriteLine("Entrenador: " + Equipos.Entrenador);
                Console.WriteLine("Nombre: " + Equipos.Nombre);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("*Lista de Jugadores*");
    
                foreach (Jugadores Ricky in Equipos.Jugador) 
                {
                    Console.WriteLine("*" + Ricky.Nombre);
                    Console.WriteLine("*" + Ricky.Numero);
                }
            }

            Console.Read();
        }
    }
}
