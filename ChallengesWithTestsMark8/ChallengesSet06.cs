using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (string.Equals(words, null) || words.Contains(null)) 
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> low = words.Select(x => x.ToLower()).ToList();
                containsWord = low.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            {
                return containsWord;
            }
        }





        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
        }
            return true;
        }







        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }





        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }




}
    }
