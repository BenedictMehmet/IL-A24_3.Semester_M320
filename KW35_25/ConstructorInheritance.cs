using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW35_25
{
    public class ConstructorInheritance
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public ConstructorInheritance ()
        {
            Console.WriteLine("ConstructorInheritance will be called");
        }


        // Base Class Constructor
        public ConstructorInheritance(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} / Alter: {Age}");
        }

        


        /// <summary>
        /// Makes our object older!
        /// </summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age</param>
        /// <returns>Returns the new age after aging</returns>
        public int BecomeOlder(int years)
        {
            return Age += years;
        }
    }




    public class Employee : ConstructorInheritance
    {
        public string JobTitle { get; private set; }

        public int EmployeeID { get; private set; }


        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age)
        {
            this.JobTitle = jobTitle;
            this.EmployeeID = employeeID;
            Console.WriteLine("Employee constructor will be called");
        }


        public void DisplayEmployeeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Job Title: {JobTitle} / EmployeeID: {EmployeeID}");
        }
    }
}
