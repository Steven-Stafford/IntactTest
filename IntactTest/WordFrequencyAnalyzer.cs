using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntactTest
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer
    {
        public int CalculateHighestFrequency(string text)
        {
            var allWordFrequencies = GetWordCounts(text);
            return allWordFrequencies.Values.Max();
        }

        public int CalculateFrequencyForWord(string text, string word)
        {
            var allWordFrequencies = GetWordCounts(text);
            word = word.ToLower();

            if (allWordFrequencies.ContainsKey(word))
            {
                var wordFrequency = allWordFrequencies[word];
                return wordFrequency;
            }
            else
            {
                return 0;
            }
        }

        public IList<IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {
            var allwordFrequencies = GetWordCounts(text);

            var mostFrequentWords = allwordFrequencies.OrderByDescending(words => words.Value)
                .ThenBy(words => words.Key)
                .Take(number)
                .Select(words => new WordFrequency { Word = words.Key, Frequency = words.Value })
                .ToList<IWordFrequency>();
            return mostFrequentWords;
        }

        public Dictionary<string, int> GetWordCounts(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Text must not be null or empty.");
            }

            if (!Regex.IsMatch(text, @"^[a-zA-Z\s]+$"))
            {
                throw new ArgumentException("Text contains non-alphabetic characters.");
            }


            var wordCounts = new Dictionary<string, int>();
            var words = text.ToLower().Split(' ');

            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            return wordCounts;

        }
    }
}
