using System;

namespace Palindrome_Integers
{
    class Program
    {static void CheckIfIsPalindrome()
        {
            string number = Console.ReadLine();
            while (number != "END")
            {


                string check = "";
                bool isPalindrome = true;
                for (int i = 0; i < number.Length; i++)
                {
                    check += number[i];

                }
                string reverseCheck = "";
                for (int j = number.Length - 1; j >= 0; j--)
                {


                    reverseCheck += number[j];

                }
                if (reverseCheck != check)
                {
                    isPalindrome = false;
                }
                Console.WriteLine(isPalindrome.ToString().ToLower());
                number = Console.ReadLine();
                
            }
        }
        static void Main(string[] args)
        {
            
            
            
                CheckIfIsPalindrome();
                
            
            
        }
    }
}
