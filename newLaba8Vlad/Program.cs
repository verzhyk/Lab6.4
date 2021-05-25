using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace newLaba8Vlad
{
    public class Checker<T>
    {
        public T[] Array { get; set; }

        public Checker(T[] array)
        {
            Array = array;
        }

        public T GetMaxElemnt()
        {
            T max = Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if ((double.Parse(max.ToString()) < double.Parse(Array[i].ToString())))
                {
                    max = Array[i];
                }
            }

            return max;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Checker<int> checker = new Checker<int>(array);
            int result = checker.GetMaxElemnt();
            Console.WriteLine($"Result: {result}.");
        }
    }
}
