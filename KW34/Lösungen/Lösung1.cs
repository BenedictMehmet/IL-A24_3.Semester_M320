using System;

namespace IL_A24_3.Semester_M320.KW34.Lösungen
{
    internal class Lösung1
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int zahl;
                bool isZahl;
                string input;

                Console.WriteLine("Bitte gib eine Zahl ein (0 = Programm beenden)");
                input = Console.ReadLine();

                isZahl = int.TryParse(input, out zahl);


                while(!isZahl)
                {
                    Console.WriteLine("Das ist keine gültige Eingabe. Bitte eine Zahl eingeben");
                    input = Console.ReadLine();
                    isZahl = int.TryParse(input, out zahl);
                }

                bool istGerade;

                istGerade = (zahl % 2 == 0);

                if(istGerade)
                {
                    Console.WriteLine("Die Zahl ist gerade");
                }
                else
                {
                    Console.WriteLine("Die Zahl ist ungerade");
                }

                if (zahl == 0)
                {
                    Console.WriteLine("Das Programm ist beendet");
                    break; // Schleife verlassen
                }
            }
        }           
    }
}
