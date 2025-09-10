using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW37_25
{
    internal class DependencyInjectionProperty2
    {
        static void Main(string[]args)
        {
            Hammer hammer = new Hammer();
            Säge säge = new Säge();
            Bauen bauen = new Bauen();

            bauen._hammer = hammer;
            bauen._säge = säge;
            bauen.HausBauen();
        }
    }



    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Nägel einschlagen");
        }
    }

    public class Säge
    {
        public void Use()
        {
            Console.WriteLine("Holz sägen");
        }
    }



    public class Bauen
    {
        public Hammer _hammer { get; set; }
        public Säge _säge { get; set; }

       
        public void HausBauen()
        {
            _hammer.Use();
            _säge.Use();
            Console.WriteLine("Haus gebaut");
        }

    }
}
