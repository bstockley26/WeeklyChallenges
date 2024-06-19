using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int result = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num; 
                }
                else
                {
                    result -= num; 
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2) ||
        string.IsNullOrEmpty(str3) || string.IsNullOrEmpty(str4))
            {
                return 0;
            }

            int shortestLength = int.MaxValue; 

            
            if (str1.Length < shortestLength)
            {
                shortestLength = str1.Length;
            }
            if (str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }
            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }
            if (str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }

            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = number1; 

           
            if (number2 < smallestNumber)
            {
                smallestNumber = number2;
            }

            
            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }

            
            if (number4 < smallestNumber)
            {
                smallestNumber = number4;
            }

            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz == null)
            {
                throw new ArgumentNullException(nameof(biz), "Business object cannot be null.");
            }

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            
            bool condition1 = (sideLength1 + sideLength2) > sideLength3;
            bool condition2 = (sideLength1 + sideLength3) > sideLength2;
            bool condition3 = (sideLength2 + sideLength3) > sideLength1;

            return condition1 && condition2 && condition3;
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false; 
            }

            
            if (double.TryParse(input, out double result))
            {
                return true; 
            }

            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false; 
            }

            int countNull = 0;
            int countNonNull = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    countNull++;
                }
                else
                {
                    countNonNull++;
                }
            }

            return countNull > countNonNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            int countEvens = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0) // Check if the number is even
                {
                    sum += num;
                    countEvens++;
                }
            }

            if (countEvens == 0)
            {
                return 0;
            }

            return (double)sum / countEvens;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
