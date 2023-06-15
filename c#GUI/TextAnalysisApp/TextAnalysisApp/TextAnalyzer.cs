using System;
using System.Linq;
using System.Collections.Generic;

class TextAnalyzer : IDisposable {
    // Constants
    private readonly char[] SENTENCE_TERMINATORS = { '.', ';', '?', '!' };
    private readonly char[] NORMAL_PUNCTUATION = { '.', ';', '?', '!', ',', ':', '$', '%',
                                                     '^', '&', '*', '(', ')', '[', ']',
                                                     '_', '+', '=', ':', '\'', '\"', '@', '#',
                                                     '<', '>', '/', '\\', '~', '`', '\r' };

    private readonly string[] SPECIAL_PUNCTUATION = { "\n", "\t", "\r", "\r\n", "- ", " -", " - " };

    // class member variables
    private string m_text = "";
    private string m_textWithoutPunctuation = "";
    private Dictionary<string, int> m_wordDictionary = new Dictionary<string, int>();

    //class properties
    public string Text { 
        get {
            return m_text;
        } // end get

        private set {
            m_text = value.ToLower().Trim();
        } //end set
    } // end property
    public string TextWithoutPunctuation { 
        get {
            return m_textWithoutPunctuation;
        } // end get

        private set {
            m_textWithoutPunctuation = value;
        } // end set
    } // end property
    public int NumberOfSentences { get; private set; }
    public int TotalNumberOfWords { get; private set; }
    public int NumberOfUniqueWords { get; private set; }
    public Dictionary<string, int> WordDictionary { 
        get {
            return m_wordDictionary;
        } // end get
        
        private set {
            m_wordDictionary = value;
        } // end set
    } // end property

    // class constructor
    public TextAnalyzer(string text = "") {
        // if the text has any characters...
        if (text != string.Empty) {
            Text = text;
        } else {    // otherwise, throw an exception
            throw new EmptyStringException();
        } // end if        

        this.AnalyzeText();
    } // end constructor

    private void AnalyzeText() {
        // count sentences
        this.NumberOfSentences = this.CountSentences();

        // remove punctuation
        this.TextWithoutPunctuation = this.RemovePunctuation();

        // split text without punctuation into a list, sort that list, and find all unique words
        List<string> duplicateWordsList = new List<string>(TextWithoutPunctuation.Split());
        duplicateWordsList.Sort();  // sort the duplicate words list

        // count total number of words and unique words
        this.TotalNumberOfWords = duplicateWordsList.Count();     // get the total number of words
        this.NumberOfUniqueWords = duplicateWordsList.Distinct().Count();    // get the number of unique words

        // create and populate word dictionary and count number of occurrances of each word
        Dictionary<string, int> wordDictionary = new Dictionary<string, int>();
        this.BuildDictionary(wordDictionary, duplicateWordsList);
        this.WordDictionary = wordDictionary;   // assign word dictionary to public property
    } // end method

    private string RemovePunctuation() {
        string textWithoutPunctuation = Text;

        // replace punctuation with empty string
        foreach (char punctuation in NORMAL_PUNCTUATION) {
            textWithoutPunctuation = textWithoutPunctuation.Replace(punctuation.ToString(), string.Empty);
        } // end foreach

        // replace punctuation with single space
        foreach (string punctuation in SPECIAL_PUNCTUATION) {
            textWithoutPunctuation = textWithoutPunctuation.Replace(punctuation, " ");
        } // end foreach

        return textWithoutPunctuation;
    } // end method

    public int CountSentences() {
        int count = 0;

        // for each sentence terminator...
        foreach (char terminator in SENTENCE_TERMINATORS) {
            // for each character in the text...
            foreach (char character in Text) {
                // if the current character is a sentence terminator...
                if (character == terminator) {
                    // Increment counter by 1
                    count++;
                } // end if
            } // end foreach
        } // end foreach

        return count;
    } // end method
    
    private void BuildDictionary(Dictionary<string, int> wordDictionary, List<string> duplicateWordsList) {
        string thisWord = "";

        // loop through each word in the duplicate words list
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
                } else {    // Otherwise, add the first to the dictionary with 1 occurrence (thus far)
                    wordDictionary.Add(thisWord, 1);    // Add word to dictionary as a key
                } // end if
            } // end if
        } // end foreach
    } // end method

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    } // end method

    protected virtual void Dispose(bool disposing) {
        if (disposing) {
            m_text = null;
            m_textWithoutPunctuation = null;
            this.WordDictionary = null;
        } // end if
    } // end method
} // end class
public class EmptyStringException : Exception {
    public EmptyStringException() : base("Text to be analyzed cannot be empty.") { }
    public EmptyStringException(string message) : base(message) { }
    public EmptyStringException(string message, Exception inner) : base(message, inner) { }
} // end class
