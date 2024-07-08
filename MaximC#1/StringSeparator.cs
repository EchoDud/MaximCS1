﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximC_1
{
    internal class StringSeparator
    {
        public static string Do(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cant be empty");
            }

            try
            {
                if ((input.Length & 1) == 0)
                {
                    int mid = input.Length / 2;
                    string firstHalf = input.Substring(0, mid);
                    string secondHalf = input.Substring(mid);

                    return ReverseString(firstHalf) + ReverseString(secondHalf);
                }
                else
                {
                    string reversedInput = ReverseString(input);
                    return reversedInput + input;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Somthing went wrong", ex);
            }
        }

        private static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }


    }
}
