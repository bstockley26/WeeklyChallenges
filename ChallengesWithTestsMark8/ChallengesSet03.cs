using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false; // Return false if the array is null or empty
            }

            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true; // Return true if any element is false
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false; // Return false if the input is null
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 != 0) // Check if the number is odd
                {
                    sum += number;
                }
            }

            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false; // Return false if the password is null or empty
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                // If all conditions are met, return true early
                if (hasUpper && hasLower && hasDigit)
                {
                    return true;
                }
            }

            // If the loop finishes and any condition is not met, return false
            return hasUpper && hasLower && hasDigit;
        }
    
        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements.");
            }

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                throw new ArgumentNullException(nameof(words), "Input array cannot be null.");
            }

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
