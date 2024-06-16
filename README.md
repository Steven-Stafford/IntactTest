# IntactTest

## Overview

This project contains an implementation for analyzing word frequencies in a given text. It includes methods to calculate the highest frequency of any word, the frequency of a specific word, and the most frequent words in the text.

## Project Structure

- **IntactTest**: Main project containing the word frequency analyzer logic.
  - `IWordFrequency.cs`: Defines the `IWordFrequency` interface.
  - `IWordFrequencyAnalyzer.cs`: Defines the `IWordFrequencyAnalyzer` interface.
  - `WordFrequency.cs`: Implements the `IWordFrequency` interface, representing a word and its frequency.
  - `WordFrequencyAnalyzer.cs`: Implements the `IWordFrequencyAnalyzer` interface and contains methods for analyzing word frequencies.

- **IntactTest.Tests**: Test project containing unit tests for the `WordFrequencyAnalyzer`.
  - `WordFrequencyAnalyzerTests.cs`: Contains unit tests for the methods in `WordFrequencyAnalyzer`.
