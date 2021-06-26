using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Vuture.CodingTest
{
    public class TestSolver
    {
        public TestSolver()
        {
        }

        /*
         * This method finds and censors all words,which are palindromes;
         * Params: String text;
         * Return: String censoredText;
         */
        public string CensorePalindromes(string text)
        {
            List<string> wordsArray = BreakIntoWords(text);
            string censoredText = text;
            foreach (string word in wordsArray)
            {
                if (IsPalindrome(word))
                {
                    string censoredWord = CensorWord(word);
                    censoredText = censoredText.Replace(word, censoredWord);
                }
            }
            return censoredText;
        }

        /*
         * This method finds and censors all words, which are in the list of words;
         * Params: List<string> censors, String text;
         * Return: String censoredText;
         */
        public string CensoreText(List<string> censors, string text)
        {
            List<string> listFromText = BreakIntoWords(text);
            string censoredText = text;
            foreach (string censor in censors)
            {
                censor.ToLower();
                if (censor.Length < 3)
                {
                    censors = censors.Where(str => str != censor).ToList();
                }
            }

            foreach (string word in listFromText)
            {
                if (censors.Contains(word.ToLower()))
                {
                    string newWord = CensorWord(word);
                    censoredText = censoredText.Replace(word.ToString(), newWord.ToString());
                }
            }

            return censoredText;
        }

        /*
         * This method censors a single word
         * Params: String word;
         * Return: String censored;
         */
        public string CensorWord(string word)
        {
            string censored = word;
            if (censored.Length >= 3)
            {
                for (int i = 1; i < word.Length - 1; i++)
                {
                    censored = new StringBuilder(censored).Replace(censored[i], '$', i, 1).ToString();
                }
            }
            else
            {
                censored = word;
            }
            return censored;
        }

        /*
         * This method counts the number of occurances of each word from a list of strings in another string.
         * It returns a dictionary of each occurance count mapped to the string it represents and a total count. 
         * Params: List<String> wordList, String text;
         * Return: Dictionary<String,int> counts;
         */
        public Dictionary<string, int> CountNumWordOccurences(List<string> wordList, string text)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string c in wordList)
            {
                counts.Add(c.ToLower(), 0);
            }
            counts.Add("total", 0);
            List<string> listFromText = BreakIntoWords(text);

            foreach (string c in wordList)
            {
                counts[c] = Regex.Matches(string.Join(" ", listFromText).ToLower(), c.ToLower()).Count;
                counts["total"] += counts[c];
            }

            return counts;

        }


        /*
         * This method splits a string text input into its compounding words.
         * Params: String text;
         * Return: List<String> wordsOnly;
         */
        public List<string> BreakIntoWords(string text)
        {
            //This function splits a text input into words using a list of delimiters.
            char[] delimiters = { ' ', '.', ',', ':', ';', '?', '!' };
            string[] wordsAndWhiteSpaces = text.Split(delimiters);
            string[] wordsOnly = wordsAndWhiteSpaces.Where(s => (s.Equals(" ") == false) && (s.Equals("") == false)).ToArray();
            return wordsOnly.ToList();

        }

        /*
         * This method checks if a string is a palindrome
         * Params: String s;
         * Return: Bool;
         */
        public bool IsPalindrome(string s)
        {
            //for this one I will ignore all punctuation, upper/lower case,
            //otherwise the string will not be a palindrome  - that is what I can gather from
            //the example input and output, all non-alphanumeric characters will be removed
            if (s.Length != 0)
            {
                string lowered = s.ToLower();
                string cleanedString = new string(lowered.Where(c => char.IsLetterOrDigit(c)).ToArray());
                char[] toBeReversed = cleanedString.ToCharArray();
                Array.Reverse(toBeReversed);
                return cleanedString.Equals(new string(toBeReversed));
            }
            else
            {
                return true;
            }

        }

        /*
         * This method counts how often a letter is found within a string
         * Params: Char c, String s;
         * Return: Int occurance;
         */
        public int CountNumOccurences(char c, string s)
        {
            int occurance = 0;
            foreach (char ch in s.ToLower())
            {
                if (ch.Equals(c))
                {
                    occurance += 1;
                }
            }

            return occurance;
        }

    }
}
