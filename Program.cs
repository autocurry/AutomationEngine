using System;

namespace AutomationEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Application Name");
            var ApplicationName = Console.ReadLine();
            Console.WriteLine("Enter Environment Name");
            var EnvironmentName = Console.ReadLine();

            Console.WriteLine(string.Format("ApplicationName= {0}, EnvironmentName= {1}",ApplicationName,EnvironmentName));

        }
    }
}
