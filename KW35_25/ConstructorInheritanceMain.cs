using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW35_25
{
    internal class ConstructorInheritanceMain
    {
        static void Main(string[]args)
        {
            Employee joe = new Employee("Joe", 36, "IT", 1234);

            joe.BecomeOlder(5);

            joe.DisplayEmployeeInfo();

            Console.ReadKey();
        }
    }
}
