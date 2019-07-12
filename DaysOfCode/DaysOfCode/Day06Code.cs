﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day06Code
    {
        public bool Only14(int[] nums)
        {
            bool only14 = true;

            foreach (int num in nums)
                if (num != 1 && num != 4)
                {
                    only14 = false;
                    break;
                }

            return only14;
        }
    }
    /*
      Day 6:  Only14
      Create a boolean method called Only14 that takes in an integer array “nums”. 
      Given an array of ints, return true if every element is a 1 or a 4.

      only14([1, 4, 1, 4]) → true

      only14([1, 4, 2, 4]) → false

      only14([1, 1]) → true
     */
}
