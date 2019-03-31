using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_04
{
    static class ExtensionClass
    {// Recursion (simple).
        public static void ExtensionMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine(value+counter);

            if(counter!=0)
            {
                value.ExtensionMethod(counter); 
            }
            Console.WriteLine(value+counter);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            string text = "Hello";
            text.ExtensionMethod(3);

            Console.ReadLine();
        }
    }
}
