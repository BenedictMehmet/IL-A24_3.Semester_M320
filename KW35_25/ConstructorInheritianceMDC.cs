using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW35_25
{
    public class ConstructorInheritianceMDC
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ConstructorInheritianceMDC (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} / Alter: {Age}");
        }

    }



    public class Employee1 : ConstructorInheritianceMDC
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }

        public Employee1(string name, int age, string jobTitle, int employeeID) : base(name, age)
        {
            this.JobTitle = jobTitle;
            this.EmployeeID = employeeID;
        }

        public void DisplayEmployee()
        {
            DisplayInfo();
            Console.WriteLine($"Jobtitel: {JobTitle} / EmployeeID: {EmployeeID}");
        }
    }



    public class Manager : Employee1
    {
        public int TeamSize { get; set; }

        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) 
            : base(name, age, jobTitle, employeeID)
        {
            this.TeamSize = teamSize;
        }

        public void DisplayManager()
        {
            DisplayEmployee();
            Console.WriteLine($"Teamgrösse: {TeamSize}");
        }
    }
}
