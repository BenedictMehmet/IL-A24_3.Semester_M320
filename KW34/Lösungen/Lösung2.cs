using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW34.Lösungen
{
    internal class Lösung2
    {
        static void Main(string[] args)
        {
            bool beenden = false;

            while (!beenden)
            {
                // Erste Zahl
                Console.WriteLine("Gib die erste Zahl ein");
                int zahl1;
                string input1;
                bool isZahl1;
                input1 = Console.ReadLine();
                isZahl1 = int.TryParse(input1, out zahl1);

                //Zeite Zahl
                Console.WriteLine("Gib die erste Zahl ein");
                int zahl2;
                string input2;
                bool isZahl2;
                input2 = Console.ReadLine();
                isZahl2 = int.TryParse(input2, out zahl2);

                while(!isZahl1 || !isZahl2)
                {
                    if(!isZahl1)
                    {
                        Console.WriteLine("Bitte Zahl1 erneut eingeben");
                        input1 = Console.ReadLine();
                        isZahl1 = int.TryParse(input1, out zahl1);
                    }

                    if(!isZahl2)
                    {
                        Console.WriteLine("Bitte Zahl2 erneut eingeben");
                        input2 = Console.ReadLine();
                        isZahl2 = int.TryParse(input2, out zahl2);
                    }
                }

                // Operator eingeben
                Console.WriteLine("Welchen Operator möchten sie verwenden (+/-/*/:) oder ! zum beeden");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        int ergebnis = zahl1 + zahl2;
                        Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                        break;

                    case "-":
                        ergebnis = zahl1 - zahl2;
                        Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                        break;

                    case "*":
                        ergebnis = zahl1 * zahl2;
                        Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                        break;

                    case ":":
                        ergebnis = zahl1 / zahl2;
                        Console.WriteLine("Das Ergebnis ist: " + ergebnis);
                        break;

                    case "!":
                        Console.WriteLine("Programm beendet");
                        beenden = true;
                        break;

                    default:
                        Console.WriteLine("Ungültige Operator");
                        break;
                }


            }
        }
    }
}
