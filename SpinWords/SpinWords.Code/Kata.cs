using System;
using System.Linq;

namespace SpinWords.Code
{
    public class Kata
    {
        /*
         * Write a function that takes in a string of one or more words, 
         * and returns the same string, but with all five or more letter
         * words reversed (like the name of this kata).
         * - Strings passed in will consist of only letters and spaces.
         * - Spaces will be included only when more than one word is present.
         */
        public string SpinWords(string sentence)
        {
            var words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
            }
            
            return string.Join(" ", words);
        }
    }
}
