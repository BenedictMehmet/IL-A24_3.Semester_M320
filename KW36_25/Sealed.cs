using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW36_25
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }


    sealed class Sealed : Person
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }

        public Sealed(string name, int age, string jobTitle, int salary) : base(name, age)
        {
            this.JobTitle = jobTitle;
            this.Salary = salary;
        }
    }


    //public class Manager : Sealed
    //{
    //    public int TeamSize { get; set; }

    //    public Manager (string name, int age, string jobTitle, int salary, int teamSize) : base(name, age, jobTitle, salary)
    //    {
    //        this.TeamSize = teamSize;
    //    }
    //}
}
