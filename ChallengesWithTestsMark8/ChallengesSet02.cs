using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length %2 ==0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 == 0 ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max = int.MinValue;
            double min = int.MaxValue;

            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            foreach(var number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
                if(number > max)
                {
                    max = number;
                }

            }
            return max + min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {

            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for(int i =1; i < number; i++)
            {
                if(i % 2 == 1)
                {
                    count++;
                } 
            }
            return count;
        }
    }
}
