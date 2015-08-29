using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trials by Justin Harrison. " +
                              "\nTesting Palindrome logic of words and sentences " +
                              "\nwhile taking note of numbers and special characters.\n");

            //testing truth
            Console.WriteLine("Testing true palindromes:");
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("NoelleoN"));
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("NoeL sEEs leOn."));
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("Noel saw I was Leon."));
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("2 N o e l l e o n 2 . . . ."));
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("Noelllllllleon"));

            //testing false
            Console.WriteLine("\nTesting non-palindromes:");
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("Noels"));
            Console.WriteLine("Is a Palindrome? : " + IsPalindrome("No.el2"));
            //User input to test a palindrome

            while (true)
            {
                Console.WriteLine("\nType a word or sentence to test if its a palindrome:");
                var userInput = Console.ReadLine();
                Console.WriteLine(IsPalindrome(userInput));
            }
        }

        public static bool IsPalindrome(string str)
        {
            int minVal = 0;  //Beginning of the string is set to index 0
            int maxVal = str.Length - 1;  //str.length - 1 (0 indexed)
            while (true)
            {
                //Checking to break when beginning characters index is greater (passed) the max values index spot (after they meet in the middle)
                if (minVal > maxVal)
                {
                    return true;
                }

                char x = str[minVal];  //sets the forward character to x
                char y = str[maxVal];  //sets the backward character to y

                // checking against non legal characters for x.  Will loop here until x is a valid value
                while (!char.IsLetterOrDigit(x))
                {
                    minVal++;
                    if (minVal > maxVal)
                    {
                        return true;
                    }
                    x = str[minVal];
                }

                // checking against non legal characters for y.  Will loop here until y is a valid value
                while (!char.IsLetterOrDigit(y))
                {
                    maxVal--;
                    if (minVal > maxVal)
                    {
                        return true;
                    }
                    y = str[maxVal];
                }

                //Checking equality to break loop and return false, or continue on with loop
                if (char.ToLower(x) != char.ToLower(y))
                {
                    return false;
                }

                //Increment and decrement
                minVal++;
                maxVal--;
            }//end while (true)
        }
    }
}
