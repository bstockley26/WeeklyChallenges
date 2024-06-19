using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool isLetter = char.IsLetter(c);

            return isLetter;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            var num = number % 2;

            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            double min = numbers.Min();
            double max = numbers.Max();

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return 0; // Return 0 if either string is null or empty
            }

            int shortestLength = Math.Min(str1.Length, str2.Length);
            return shortestLength;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }

            // Calculate the highest odd number below 'number'
            long highestOdd = number - 1;
            if (highestOdd % 2 == 0)
            {
                highestOdd -= 1;
            }

            // The count of odd numbers below 'number' is half of the highestOdd plus one
            return (highestOdd + 1) / 2;
        }
    }
}
