using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class UppercaseResolver : AbstractResolver
    {
        public UppercaseResolver()
        {
        }

        public string FindLongestWord(string[] words)
        {
            string longestWord = null;
            int longestLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length > longestLength)
                {
                    longestLength = currentWord.Length;
                    longestWord = currentWord;
                }
            }

            return longestWord;
        }

        public override string Execute(string sentence, MessageLogger logger)
        {
            string[] words = sentence.Split(' ');

            string longestWord = FindLongestWord(words);

            logger.Write($"The sentence has {words.Length} words.");

            
            return longestWord;
        }
    }
}
