using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class LinearSearch : SearchStrategy
    {
        public override int Search(double number, double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                    return i;
            }
            return -1;
        }
    }
}
