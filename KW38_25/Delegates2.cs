using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A24_3.Semester_M320.KW38_25
{
    internal class Delegates2
    {
        static void Main(string[]args)
        {
            Logger l = new Logger();

            LogHandler lh = l.LogToConsole;
            lh("Console logger");

            lh = l.LogToFile;
            lh("File logger");

        }
    }

    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"File log: {message}");
        }
    }



}
