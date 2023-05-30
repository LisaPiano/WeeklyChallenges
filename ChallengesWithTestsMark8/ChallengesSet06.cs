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
            int location = -1;
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count = 0; //Chat GPT told me my code was not working because I didn't reset the count! Is this allowed? I asked it to 
                //explain why my code wouldn't work (I thought it should work...) and it explained. 
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                        if (count > 1)
                        {
                            break;//exit the inner loop if count is repeated
                        }
                    }
                }//end j loop
                if (count == 1)
                {
                    location = i;// the location will update the index if the character is unique
                }
            } //end i loop
            return location;
        }





        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;// This is the int that we will use to compare each time a char is repeated, is it more or less than the 
            //previous time? If it is more, then it will be updated with that number

            for (int i = 0; i < numbers.Length; i++)
            {
                int finalCompare = 1; //1 is the number of times the char initially appears
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break; // exit if the char is not repeated at all, and try the next char in the array
                    }
                    else
                    {
                        finalCompare++; //increment every time the char is repeated
                    }
                }//end if statement in j


                if (finalCompare > count)
                {
                    count = finalCompare;
                }
            }//end for i
            return count;
        }// end method
    

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }




}//end class
    }//end namespace
