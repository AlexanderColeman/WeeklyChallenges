using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if(val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
          
            var isUpper = password.Any(char.IsUpper);
            var isLower = password.Any(char.IsLower);
            var isDigit = password.Any(char.IsDigit);
            
            if(isUpper && isLower && isDigit)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }

           return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] nums = new int[50];
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    nums[count] = i;
                    count++;
                }
            }
            return nums;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
