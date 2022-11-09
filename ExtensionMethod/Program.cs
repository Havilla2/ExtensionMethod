using System;

namespace ExtensionMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
           DecimalToSring myDecimal = new DecimalToSring();
            var result = myDecimal.DecimalToString(22.80m);
           
            Console.WriteLine($"{result}");

           
        }
    }
}
