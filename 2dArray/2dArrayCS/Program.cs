using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrayCS
{
    class Program
    {
        [DllImport("2dArrayCPP.dll", EntryPoint = "Sum")]
        public static extern void Sum(int[,] a, int b, int m,int n);
        static void Main(string[] args)
        {
            int m = 3;
            int n = 5;
            var array = new int[3, 5] { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 }, { 10, 11, 12, 13, 14 } };

            // remember to check "Allow unsafe code".
            Sum(array, 4, m,n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(array[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
