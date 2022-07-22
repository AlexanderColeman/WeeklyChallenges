using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            
            string[] stringArray = { str1, str2, str3, str4 };

            var minLength = stringArray.Min(i => i.Length);

           
            return minLength;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] ints = { number1, number2, number3, number4 };

            var minLength = ints.Min(i => i);

            return minLength;   
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var isTriangle = (sideLength1 + sideLength2 > sideLength3
                 && sideLength1 + sideLength3 > sideLength2
                 && sideLength2 + sideLength3 > sideLength1) ? true : false;

            return isTriangle;
        }
           

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input,out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var countOfNull = objs.Count(x => x == null);
            var countOfNonNull = objs.Count(x => x != null);

            if(countOfNull > countOfNonNull)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Where(x => x % 2 == 0).Count() == 0)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }

            int sum = 1;
            for (int i = 1; i < number; i++)
            {
                sum *= i + 1;
            }
            return sum;
        }
    }
}
