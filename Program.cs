using System;

namespace Sorting_Test_DrSaina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 7;
            int C = 12;
            int D = 9;

            int[] ints= new int[4];
            ints[0] = A;
            ints[1] = B;
            ints[2] = C;
            ints[3] = D;

            Array.Sort(ints);   
            foreach(int i in ints) {
                Console.WriteLine(i);
            }
        }
    }
}
