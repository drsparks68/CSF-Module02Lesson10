using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a list of names that are comma separated (no spaces)");
            string nameData = Console.ReadLine();
            string[] firstNames = nameData.Split(',');

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"Hello, { firstNames[i] }");
            }

            
            
            //string[] firstNames = new string[] { "Tim", "Sue", "Bob" }

            //for (int i = 0; i < firstNames.Length; i++)
            //{

            //}

            //List<string> lastNames = new List<string>();
            //lastNames.Add("Corey");
            //lastNames.Add("Jones");
            //lastNames.Add("Smith");

            //for (int i = 0; i < lastNames.Count; i++)
            //{
            //    Console.WriteLine(lastNames[i]);

            //}

            Console.ReadLine();
        }
    }
}
