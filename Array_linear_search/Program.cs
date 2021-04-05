using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_linear_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int location, i;
            int[] a = {2,3,4,5,6,7};
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    location = i;
                    {
                        Console.WriteLine(location);
                    }
                }
            }
        }
    }
}