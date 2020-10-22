using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> list = new List<int>();
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                    list.Add(num);
            }
            return list.ToArray();
        }
    }
}
