using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            Karateka karate = new Karateka();
            Taekwondo taekwondo = new Taekwondo();

            karate.Nombre = "Paco";
            karate.Edad = 19;
            taekwondo.Nombre = "Juanito";
            taekwondo.Edad = 4;

            PrintPerson.print(karate);
            PrintPerson.print(taekwondo);

            Console.ReadLine();
        }
    }
}
