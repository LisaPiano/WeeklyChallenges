﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;

            //return ((startNumber / n) + 1) * n; 
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++) 
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }

        }


        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])

                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
             }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
            foreach (string word in words) 
            {
                if (word.Trim().Length > 0)
                { 
                    sentence += word.Trim() + " " ;
                }
                if (sentence.Length == 0)
                {
                    return "";
                }
               
            }
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
