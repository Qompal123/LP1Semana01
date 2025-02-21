using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //Add a int value

            int x = 10;

            // Add strings

            string s = "Lourenco \n18 anos \u0CA0";

            string sy = $"Valor de x é {x} e x * 2 é {x + x}";

            string sc = "Valor de x é" + x;
 
            Console.WriteLine(s);
            Console.WriteLine(sc);
            Console.WriteLine(sy);

        }
    }
}
