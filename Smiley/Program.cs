using System;
using System.Dynamic;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Insere código: ");

            string x = Console.ReadLine();

            string y = $"{x:x}";

            string z = $"{y:d}";

            char c = char.Parse(z);

            Console.OutputEncoding  = Encoding.UTF8;
 
            Console.WriteLine(y);
            Console.WriteLine(z);


        }
    }
}
