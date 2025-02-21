using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //Add variables

            double xx = 1.23456;
            int ii = 19;

            //Add a int value

            int x = 10;

            // Add strings

            string s = "Lourenco \n18 anos \u0CA0";

            string sy = $"Valor de x é {x} e x * 2 é {x + x}";

            string sc = "Valor de x é" + x;

            string sx = $"{xx:f2}\n{xx:p1}";

            string si = $"{ii:x}\n{ii:c}";
 
            Console.WriteLine(s);
            Console.WriteLine(sc);
            Console.WriteLine(sy);
            Console.WriteLine(sx);
            Console.WriteLine(si);

        }
    }
}
