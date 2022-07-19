using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    public class BubbleSort
    {
        public static int[] BubbleSorting(int[] array)
        {
            int num;
            for (int x = 0; x <= array.Length - 2; x++)
            {
                for (int y = 0; y <= array.Length - 2; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        num = array[y + 1];
                        array[y + 1] = array[y];
                        array[y] = num;
                    }
                }
            }
            return array;
        }
    }
}
