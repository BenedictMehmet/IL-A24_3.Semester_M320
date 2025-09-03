using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW36_25
{
    partial class PartialClasses
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        partial void OnJobAssigend();

    }



    partial class PartialClasses
    {
        public string JobTitle { get; set; }
        public double Salary { get; set; }

        partial void OnJobAssigend()
        {
            Console.WriteLine("New job");
        }
    }


    partial class PartialClasses
    {
        public void AssignedJob(string jobTitle)
        {
            this.JobTitle = jobTitle;
            OnJobAssigend();
        }

       // Die Methode OnJobAssigend kann ich nicht noch einmal erfassen.
    }



    class PartialClassMain
    {
        static void Main(string[]args)
        {
            PartialClasses pc = new PartialClasses();
            pc.FirstName = "Max";
            pc.LastName = "Bob";

            pc.JobTitle = "IT";
            pc.Salary = 5000;
        }
    }

}
