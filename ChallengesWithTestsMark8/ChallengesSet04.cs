using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(num => num % 2 == 0).Sum() - numbers.Where(num => num % 2 == 1).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {


            var wordList = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };


            return wordList.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int> { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength2
                );
        }

        public bool IsStringANumber(string input)
        {
            bool answer = double.TryParse(input, out double number);
            return answer;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countOfNotNull = 0;
            int countOfNull = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    countOfNull++;
                }
                if (obj != null)
                {
                    countOfNotNull++;
                }
            }
            if (countOfNull > countOfNotNull)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers != null)
            {
                if (numbers.Length == 0)
                {
                    return 0;
                }
                var count = 0;
                foreach (var number in numbers)
                {
                    if (number % 2 == 1)
                    {
                        count++;
                    }
                    if (count == numbers.Length)
                    {
                        return 0;
                    }
                }
                var answer = numbers.Where(x => x % 2 == 0).Average();
                return answer;
            }
            return 0;

        }

        public int Factorial(int number)
        {
            var total = 1;
            {
                for (int i = number; number >= 1; i--)
                {
                    total *= i;
                }
                return total;
            }
       
        }
    }
}

    

