using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW36_25
{
    internal class SealedMethod
    {
    }




    class BaseClass
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("Message from Baseclass");
        }
    }


    class Abgeleitet : BaseClass
    {
        public sealed override void ShowMessage()
        {
            Console.WriteLine("Message from Abgeleitete Klasse");
        }
    }


    class Abgeleitet2 : Abgeleitet
    {
        public override void ShowMessage()
        {
            Console.WriteLine("Message from Abgeleitet 2");
        }
    }



}
