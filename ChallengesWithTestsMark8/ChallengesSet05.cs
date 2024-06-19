using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int nextNumber = startNumber + (n - startNumber % n);
            return nextNumber;
        }

            public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers) //not finished yet 
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return false; // Null array or single-element array is not in ascending order
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false; // If any element is smaller than the previous one, it's not in ascending order
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return 0; // Return 0 if array is null or has only one element
            }

            int sum = 0;
            bool isEvenFound = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    isEvenFound = true;
                    sum += numbers[i + 1];
                }
            }

            return isEvenFound ? sum : 0;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return ""; // Return an empty string if the array is null or empty
            }

            // Remove leading and trailing whitespace from each word
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i]?.Trim();
            }

            // Filter out empty strings after trimming
            words = words.Where(w => !string.IsNullOrEmpty(w)).ToArray();

            string sentence = string.Join(" ", words); // Concatenate words with spaces

            // Check if the resulting sentence is empty or consists only of spaces
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return ""; // Return an empty string if the sentence is empty or contains only spaces
            }

            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1); // Capitalize the first letter
            sentence += "."; // Add a period at the end

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[] { }; // Return an empty array if the input list is null or empty
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]); // Add every fourth element to the result list
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            // Create a HashSet to store the numbers encountered so far
            HashSet<int> seenNumbers = new HashSet<int>();

            // Iterate through the array
            foreach (int num in nums)
            {
                // Calculate the difference needed to reach the targetNumber
                int diff = targetNumber - num;

                // If the difference (required number to reach targetNumber) is already in the set, return true
                if (seenNumbers.Contains(diff))
                {
                    return true;
                }

                // Add the current number to the set
                seenNumbers.Add(num);
            }

            // If no two different elements can sum to the targetNumber, return false
            return false;
        }
    }
}
