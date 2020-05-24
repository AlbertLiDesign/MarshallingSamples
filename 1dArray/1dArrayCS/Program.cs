using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1dArrayCS
{
    class Program
    {
        [DllImport("1dArrayCPP.dll", EntryPoint = "Sum")]
        public static extern void Sum(int[] a, int b, int length);
        static void Main(string[] args)
        {
            int length = 5;
            var array = new int[5] { 0, 1, 2, 3, 4 };

            // remember to check "Allow unsafe code".
            Sum(array, 4, length);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
