using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW36_25.Lösungen
{
    internal class Lösung1
    {
        static void Main(string[]args)
        {
            Tier tier = new Tier();
            tier.MachGeräusch();


            Hund meinHund = new Hund();
            meinHund.MachGeräusch();
            
        }
    }

    class Tier
    {
        public virtual void MachGeräusch()
        {
            Console.WriteLine("Tiergeräusch");
        }
    }

    class Hund : Tier
    {
        public override void MachGeräusch()
        {
            base.MachGeräusch();

            Console.WriteLine("Hund bellt");
        }

      
    }




}
