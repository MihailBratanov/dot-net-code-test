using System;
using System.Collections.Generic;
namespace Vuture.CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSolver ts = new TestSolver();

            //Task 1
            char task1Char = 'e';
            string task1String = "I have some cheese";

            Console.WriteLine("Task 1 input: [" + task1Char + "], [" + task1String + "]");
            Console.WriteLine("Task 1 output: " + ts.CountNumOccurences(task1Char, task1String));

            //Task 2
            string task2NotPalindrome = "I have some cheese";
            string task2Palindrome = "God saved Eva’s dog";

            Console.WriteLine("Task 2 input 1: [" + task2NotPalindrome + "] ");
            Console.WriteLine("Task 2 output 1: " + ts.IsPalindrome(task2NotPalindrome));
            Console.WriteLine("Task 2 input 2: [" + task2Palindrome + "] ");
            Console.WriteLine("Task 2 output 2: " + ts.IsPalindrome(task2Palindrome));

            //Task 3A
            List<string> censoredWordList3A = new List<string> { "dog", "cat", "large" };
            string text3A = "I have a cat named Meow and a dog name Wolf. I love the dog a lot. He is larger than a small horse.";
            Dictionary<string, int> result3A = ts.CountNumWordOccurences(censoredWordList3A, text3A);

            Console.WriteLine("Task 3A input: [" + string.Join(", ", censoredWordList3A) + "], [" + text3A + "]");
            Console.WriteLine("Task 3A output: ");
            foreach (var kvp in result3A)
            {
                Console.WriteLine("[{0}: {1}] ", kvp.Key, kvp.Value);
            }

            //Task 3B
            List<string> censoredWordList3B = new List<string> { "meow", "woof" };
            string text3B = "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.";
            string censoredText = ts.CensoreText(censoredWordList3B, text3B);

            Console.WriteLine("Task 3B input: [" + string.Join(", ", censoredWordList3B) + "], [" + text3B + "]");
            Console.WriteLine("Task 3B output: " + censoredText);


            //Task 3C
            string text3C = "Anna went to vote in the election to fulfil her civic duty";
            string censoredPalindrometext = ts.CensorePalindromes(text3C);

            Console.WriteLine("Task 3C input: [" + text3C + "] ");
            Console.WriteLine("Task 3C output: " + censoredPalindrometext);

            //Task 3D
            //1. One way to supply the app with a list is to load it from local or remote database;
            //2. Another way is to get the list from a post/get request via user interaction.
            //3. One could also store the list in a file. 
        }


    }
}