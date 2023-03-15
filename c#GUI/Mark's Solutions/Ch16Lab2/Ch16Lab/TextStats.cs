using System;
using System.Linq;
using System.Collections.Generic;

public class TextStats : IDisposable {
    // Constants
    private readonly char[] SENTENCE_TERMINATORS = { '.', ';', '?', '!' };
    private readonly char[] NORMAL_PUNCTUATION = { '.', ';', '?', '!', ',', ':', '$', '%',
                                                     '^', '&', '*', '(', ')', '[', ']', 
                                                     '_', '+', '=', ':', '\'', '\"', '@', '#',
                                                     '<', '>', '/', '\\', '~', '`', '\r' };
    private readonly string[] SPECIAL_PUNCTUATION = { "\n", "\t", "- ", " -", " - " };

    // Private member variable
    private string m_originalText;
    private string m_textWithoutPunctuation;

    // Public properties
    public int NumberOfSentences { get; private set; }
    public int TotalNumberOfWords { get; private set; }
    public int NumberOfUniqueWords { get; private set; }
    public Dictionary<string, int> WordDictionary { get; private set; }

    // Constructor method
    public TextStats(string text) {
        // If the text has any characters...
        if (text != string.Empty) {
            m_originalText = text;
        } else {    // Otherwise, throw an exception
            throw new EmptyStringException();
        } // end if        

        this.AnalyzeText();
    } // end constructor

    // Method handles analyzing text
    private void AnalyzeText() {
        // Count number of sentences
        this.NumberOfSentences = this.CountNumberOfSentences();

        // Remove all punctuation from original text
        m_textWithoutPunctuation = this.RemovePunctuation();

        // Split text without punctuation into a list, sort that list, and find all unique words
        List<string> duplicateWordsList = new List<string>(m_textWithoutPunctuation.Split(' '));
        duplicateWordsList.Sort();  // Sort the duplicate words list
     
        // Count total number of words and number of unique words
        this.TotalNumberOfWords = duplicateWordsList.Count;     // Get the total number of words
        this.NumberOfUniqueWords = duplicateWordsList.Distinct().Count();    // Get the number of unique words

        // Create and populate word dictionary and count number of occurrances of each word
        Dictionary<string, int> wordDictionary = new Dictionary<string, int>();
        this.PopulateWordDictionary(wordDictionary, duplicateWordsList);
        this.WordDictionary = wordDictionary;   // Assign word dictionary to public property
    } // end method

    // Method add each unique word to dictionary, then adds-up total occurrances of each word
    private void PopulateWordDictionary(Dictionary<string, int> wordDictionary, List<string> duplicateWordsList) {
        string thisWord = "";
        // Loop through each word in the duplicate words list
        foreach (string word in duplicateWordsList) {
            // If this word has one or more characters in it...
            if (word.Length > 0) {
                // Set the first letter of each word to uppercase
                if (word.Length == 1) { // If the word only contains 1 character, make it uppercase
                    thisWord = word.ToUpper();
                } else {    // Otherwise, just uppercase the first letter
                    thisWord = word.Substring(0, 1).ToUpper() + word.Substring(1);
                } // end if            

                // If the word already exists in the word dictionary...
                if (wordDictionary.ContainsKey(thisWord)) {
                    wordDictionary[thisWord]++;         // Increment this word's value by 1
                } else {    // Otherwise, add the first to the dictionary with 1 occurrance (thus far)
                    wordDictionary.Add(thisWord, 1);    // Add word to dictionary as a key
                } // end if
            } // end if
        } // end foreach
    } // end method

    // Method removes all punctuation from original text
    private string RemovePunctuation() {
        string textWithoutPunctuation = m_originalText.ToLower();

        // Replace all "normal" punctuation (i.e., punctuation that is just removed)
        foreach (char punctuation in NORMAL_PUNCTUATION) {
            textWithoutPunctuation = textWithoutPunctuation.Replace(punctuation.ToString(), string.Empty);
        } // end foreach

        // Replace all "special" punctuation (i.e., punctuation is replaced with a space)
        foreach (string punctuation in SPECIAL_PUNCTUATION) {
            textWithoutPunctuation = textWithoutPunctuation.Replace(punctuation, " ");
        } // end foreach

        return textWithoutPunctuation;
    } // end method

    // Method counts the number of sentences in original text
    private int CountNumberOfSentences() {
        int sentenceCounter = 0;
        
        // For each sentence terminator...
        foreach (char terminator in SENTENCE_TERMINATORS) {
            // For each character in the text...
            foreach (char character in m_originalText) {
                // If the current character is a sentence terminator...
                if (character == terminator) {
                    // Increment counter by 1
                    sentenceCounter++;
                } // end if
            } // end foreach
        } // end foreach

        return sentenceCounter;
    } // end method

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    } // end method

    protected virtual void Dispose(bool disposing) {
        if (disposing) {
            m_originalText = null;
            m_textWithoutPunctuation = null;
            this.WordDictionary = null;
        } // end if
    } // end method
} // end class

public class EmptyStringException : Exception {
    public EmptyStringException() : base("Unable to process. The specified text doesn't contain any characters.") { }
    public EmptyStringException(string message) : base(message) { }
    public EmptyStringException(string message, Exception inner) : base(message, inner) { }
} // end class