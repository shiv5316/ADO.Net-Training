using System;
using System.Collections.Generic;
using System.Text;

namespace Even_Check.feature
{
    public class EvenOrOdd
    {
        public bool check(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }

    public class SumOfnumber
    {
        public int sumofnumber(int a)
        {
            if(a < 0)
        {
                return -1; 
            }
            int result = (a * (a + 1)) / 2;

            return result;

        }
    }
    public class Reverse
    {
        public string ReverseString(string a)
        {
            char[] c = a.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }
}
