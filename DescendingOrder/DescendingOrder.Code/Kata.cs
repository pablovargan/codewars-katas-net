using System;
using System.Linq;

namespace DescendingOrder.Code
{
    public class Kata
    {
        /*
         * Your task is to make a function that can take any non-negative integer as an 
         * argument and return it with its digits in descending order. Essentially, rearrange 
         * the digits to create the highest possible number.
         */
        public int DescendingOrder(int num)
        {
            return int.Parse(String.Concat(num.ToString().OrderByDescending(n => n)));
        }
    }
}
