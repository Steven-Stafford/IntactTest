using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntactTest.Tests
{
    public class WordFrequencyAnalyzerTests
    {
        private WordFrequencyAnalyzer _analyzer;

        [SetUp]
        public void SetUp() 
        { 
            _analyzer = new WordFrequencyAnalyzer();
        }

        [Test]
        public void CalculateHighestFrequency_ReturnsCorrectValue()
        {
            var text = "The sun shines over the lake";
            var result = _analyzer.CalculateHighestFrequency(text);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void CalculateFrequencyForWord_ReturnsCorrectValue()
        {
            var text = "The sun shines over the lake";
            var word = "the";
            var result = _analyzer.CalculateFrequencyForWord(text, word);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void CalculateMostFrequentWords_ReturnsCorrectValues()
        {
            var text = "The sun shines over the lake";
            var number = 3;
            var result = _analyzer.CalculateMostFrequentWords(text, number);

            Assert.That(result.Count, Is.EqualTo(number));

            Assert.That(result[0].Word, Is.EqualTo("the"));
            Assert.That(result[0].Frequency, Is.EqualTo(2));
            Assert.That(result[1].Word, Is.EqualTo("lake"));
            Assert.That(result[1].Frequency, Is.EqualTo(1));
            Assert.That(result[2].Word, Is.EqualTo("over"));
            Assert.That(result[2].Frequency, Is.EqualTo(1));
        }


        [Test]
        public void GetWordCounts_IsCaseInsensitive()
        {
            var text = "the tHe thE THE";
            var result = _analyzer.GetWordCounts(text);

            Assert.That(result["the"], Is.EqualTo(4));
        }

        [Test]
        public void GetWordCounts_ThrowsOnNonAlphabeticCharacters()
        {
            var text = "th3 sun sh1nes 0v3r th3 lak3";

            var exception = Assert.Throws<ArgumentException>(() => _analyzer.GetWordCounts(text));
            Assert.That(exception.Message, Is.EqualTo("Text contains non-alphabetic characters."));
        }


        [Test]
        public void GetWordCounts_ThrowsOnEmptyString()
        {
            var text = "";

            var exception = Assert.Throws<ArgumentException>(() => _analyzer.GetWordCounts(text));
            Assert.That(exception.Message, Is.EqualTo("Text must not be null or empty."));
        }
    }
}
