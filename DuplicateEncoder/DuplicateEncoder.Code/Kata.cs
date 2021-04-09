using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateEncoder.Code
{
    public class Kata
    {
        private Dictionary<char, int> CharCounts(string word)
        {
            var letters = word.ToLower().ToCharArray();
            var charCounts = new Dictionary<char, int>();
            foreach(var l in letters)
            {
                if (charCounts.ContainsKey(l))
                {
                    charCounts[l] += 1;
                }
                else
                {
                    charCounts.Add(l, 1);
                }
            }

            return charCounts;
        }

        private string EncodeWord(Dictionary<char,int> charCounts, string word)
        {
            string encodedWord = string.Empty;
            foreach(var letter in word.ToLower())
            {
                encodedWord += (charCounts[letter] == 1) ? "(" : ")";
            }

            return encodedWord;
        }

        /*
         * The goal of this exercise is to convert a string to a new string where each character 
         * in the new string is "(" if that character appears only once in the original string, or ")" 
         * if that character appears more than once in the original string. Ignore capitalization when 
         * determining if a character is a duplicate.
         */
        public string DuplicateEncode(string word)
        {
            var charCounts = CharCounts(word);
            return EncodeWord(charCounts, word);
        }
    }
}
