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
            for (int i = 0; i < input.Length; i++)
            {
                if(char.IsNumber(input[i])){

                }else
                {
                    return false;
                }

            }
            return true;

            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
