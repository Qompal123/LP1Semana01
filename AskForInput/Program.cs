using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //User selects number

            Console.WriteLine("Write a number: ");
            
            string usrnumb = Console.ReadLine();

            Console.WriteLine("Write another number: ");

            string usrnumb2 = Console.ReadLine();

            //Conversion

            int i = int.Parse(usrnumb);

            float f = float.Parse(usrnumb2);


            //User number display

            Console.WriteLine($"{i + f}");



        }
    }
}
