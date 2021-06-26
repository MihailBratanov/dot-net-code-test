using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
namespace Vuture.CodingTest.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private TestSolver ts = new TestSolver();
        public UnitTests()
        {
        }
        [Test]
        public void ChecksIfStringIsPalindrome()
        {
            string task2NotPalindrome = "I am definitely not a palindrome";
            string task2Palindrome = "Mr.Owl ate my metal worm";
            Assert.AreEqual(ts.IsPalindrome(task2NotPalindrome), false);
            Assert.AreEqual(ts.IsPalindrome(task2Palindrome), true);

        }
        [Test]
        public void CountsNumberOfLetterOccurances()
        {
            char letter = 'a';
            string text = "Abba 123445 Andromeda";
            Assert.AreEqual(ts.CountNumOccurences(letter, text), 4);

        }
        [Test]
        public void CountWordOccurances()
        {
            List<string> censoredWordList3A = new List<string> { "dog", "cat", "large" };
            string text3A = "I have a dog named Dogger and a dog name Dogdog. I love the large dog a lot. He is larger than a small cat.";
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected.Add("dog", 6);
            expected.Add("cat", 1);
            expected.Add("large", 2);
            expected.Add("total", 9);
            Dictionary<string, int> result3A = ts.CountNumWordOccurences(censoredWordList3A, text3A);
            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result3A));

        }
        public string ToAssertableString(Dictionary<string, int> dict)
        {
            var strings = dict.OrderBy(p => p.Key).Select(p => p.Key + ": " + string.Join(", ", p.Value));
            return string.Join("; ", strings);
        }
        [Test]
        public void ChecksCorrectBreakIntoWords()
        {
            string text = "123,a,;1,2,3,4,abba,depeche,mode";
            string[] expected = { "123", "a", "1", "2", "3", "4", "abba", "depeche", "mode" };
            Assert.AreEqual(ts.BreakIntoWords(text), expected);

        }
        [Test]
        public void ChecksCorrectWordCensoring()
        {
            string wordNormal = "dog";
            string expectedNormal = "d$g";
            string wordBad = "if";
            string expectedBad = "if";
            Assert.AreEqual(ts.CensorWord(wordNormal), expectedNormal);
            Assert.AreEqual(ts.CensorWord(wordBad), expectedBad);

        }

        [Test]
        public void CheckPalindromeCensoring()
        {
            string textWithPalindromes = "The dood went over the deed and the daad duuded.";
            string expectedWithPalindromes = "The d$$d went over the d$$d and the d$$d duuded.";
            Assert.AreEqual(ts.CensorePalindromes(textWithPalindromes), expectedWithPalindromes);

            string textWithoutPalindromes = "The dog went over the wall and the deer jumped.";
            string expectedWithoutPalindromes = "The dog went over the wall and the deer jumped.";
            Assert.AreEqual(ts.CensorePalindromes(textWithoutPalindromes), expectedWithoutPalindromes);

        }
        [Test]
        public void CheckTextCensoring()
        {
            List<string> censoredWordList3B = new List<string> { "duck", "rainbow" };
            string text3B = "I have a duck named Rainbow and a rainbow named Duck. I love the duck a lot. He is larger than a small rainbaw.";
            string censoredText = ts.CensoreText(censoredWordList3B, text3B);
            string expected = "I have a d$$k named R$$$$$w and a r$$$$$w named D$$k. I love the d$$k a lot. He is larger than a small rainbaw.";
            Assert.AreEqual(censoredText, expected);
        }
    }
}
