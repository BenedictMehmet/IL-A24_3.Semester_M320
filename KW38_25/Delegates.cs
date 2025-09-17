using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW38_25
{
    internal class Delegates
    {
        static void Main(string[]args)
        {

            // Delegate zeigt jetzt auf ShowMessage
            Notify notifyDeleagate = ShowMessage;

            notifyDeleagate += AlertMessage;

            notifyDeleagate("Zwei Methoden in einer Bezeichnung");

            Console.WriteLine();

            notifyDeleagate -= ShowMessage;
            notifyDeleagate("Nur Alert wird angezeigt");
        }

        // Platzhalter für Methoden
        public delegate void Notify(string message);


        static void ShowMessage(string message)
        {
            Console.WriteLine($"Diese Nachricht komm von ShowMethode: {message}");
        }

        static void AlertMessage(string message)
        {
            Console.WriteLine($"Diese Nachricht kommt von AlertMethode: {message}");
        }


    }


}
