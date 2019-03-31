using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_02
{
    // Extend methods. (Extension methods)

    // The extension argument should always be only one and be first in the argument list.
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1+" "+value2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";

            text.ExtensionMethod("world!");

            Console.ReadLine();
        }
    }
}
