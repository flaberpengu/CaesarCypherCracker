using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypherCracker
{
    class WordCounter
    {
        int numCorrect;
        List<string> validWords;
        public WordCounter(List<string> vW)
        {
            validWords = vW;
        }
        public int GetWordsInLine(string line)
        {
            int numCounted = 0;
            char[] splitter = new char[] { ' ', '.', ',' };
            string[] wordsInLine = line.Split(splitter);
            for (int i = 0; i < wordsInLine.Length; i++)
            {
                for (int j = 0; j < validWords.Count; j++)
                {
                    if (validWords[j].Equals(wordsInLine[i]))
                    {
                        numCounted++;
                        j = validWords.Count;
                    }
                }
            }
            return numCounted;
        }
        public int GetWordsInText(List<string> text)
        {
            int wordCount = 0;
            for (int i = 0; i < text.Count; i++)
            {
                char[] splitter = new char[] { ' ', '.', ',' };
                string[] wordsInLine = text[i].Split(splitter);
                wordCount += wordsInLine.Length;
            }
            return wordCount;
        }
    }
}
