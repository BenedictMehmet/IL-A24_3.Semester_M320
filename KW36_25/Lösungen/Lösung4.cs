using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW36_25.Lösungen
{
    internal class Lösung4
    {
        static void Main(string[]args)
        {
            IFahrzeug meinAuto = new Auto();
            IFahrzeug meinBus = new Bus();

            meinAuto.Fahren();
            meinBus.Fahren();
        }
    }



    interface IFahrzeug
    {
        void Fahren();
    }


    class Auto : IFahrzeug
    {
        public void Fahren()
        {
            Console.WriteLine("Auto fährt");
        }
    }

    class Bus : IFahrzeug
    {
        public void Fahren()
        {
            Console.WriteLine("Bus fährt");
        }
    }
}
