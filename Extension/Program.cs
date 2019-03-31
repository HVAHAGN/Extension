using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    // Extend methods. (Extension methods)

    // Extending methods can only be static and be created only in static classes.

    static class ExtensionClass
    {
        // this - tells the compiler that this method is an extension!

        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Text hello";

            // Call the method as static.
            ExtensionClass.ExtensionMethod(text);

            // Call the method as extending.
               text.ExtensionMethod();




            Console.ReadLine();
        }
    }
}
