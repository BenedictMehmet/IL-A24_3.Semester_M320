using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW35_25
{
    internal class ConstructorInheritianceMDCMain
    {
        static void Main(string[]args)
        {
            Employee1 e1 = new Employee1("Max", 22, "IT", 12);

         

            e1.DisplayEmployee();

            Manager m1 = new Manager("Thomas", 25, "Sales Manager", 14, 50);

            m1.DisplayManager();

            Console.ReadKey();
        }
    }
}
