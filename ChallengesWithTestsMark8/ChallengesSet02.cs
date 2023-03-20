using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public ChallengesSet02()
        {
        }

        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int total = vals.Count();
            if (total % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            bool answer = (number % 2 == 0) ? true : false;
            return answer;
        }

        public bool IsNumberOdd(int num)
        {
            bool answer = (num % 2 == 0) ? false : true;
            return answer;

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }



        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int answer = 0;
            if (numbers == null)
            { 
            return 0; 
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            for (var i = 0; i < numbers.Length; i++)
            {
                answer = answer + numbers[i];
            }
            
            return answer;
        }

        public int SumEvens(int[] numbers)
        {   if (numbers == null)
            {
                return 0;
            }
            int answer =0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    answer = answer + numbers[i];
                }
            }
            return answer;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            for (var i = 0; i < numbers.Count; i++)
            { 
                sum = sum + numbers[i];
            }
            if ((sum % 2 == 1) || (sum %2 == -1))
            {
                return true;
            }
            else {
                return false;
                }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
