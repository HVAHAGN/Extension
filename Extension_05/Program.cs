using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_05
{
    // Extend methods. (Extension methods)
    // Use ref and out arguments. (The extension argument can be neither ref nor out)
    static class ExtensionClass
    {
        public static void Add(this int summad1, ref int summad2, out int sum)
        {
            sum = summad1 + summad2;
            Console.WriteLine("{0} + {1} = {2}", summad1, summad2, sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int summad1 = 1, summad2 = 2, sum = 0;

            summad1.Add(ref summad2, out sum);

            Console.ReadLine();
        }
    }
}
