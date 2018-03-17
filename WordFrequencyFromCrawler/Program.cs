/*
Author          : Sr Programmer Analyst Oleg Gorlov
Description:	: Assigment 
Copyright       : GMedia-IT-Consulting 
email           : oleg_gorlov@yahoo.com
Date            : 03/11/2018
Release         : 1.0.0
Comment         : 
1) -A word-frequency list obtained through crawling web pages. You can assume you have an API that you give a word to and it returns you a number which represents how many times it shows up in web pages: 
int getWordFrequencyFromCrawler(String word); 

-A word-frequency list obtained through your search history. You can assume you have an API that you give a word to and it returns you a number which represents how many times it was included in the user’s search history: 

Int getWordFrequencyFromCrawler(String word); 

 */
using System;
using System.Collections.Generic;
using System.Linq;
using SmartSystems;

class program
{

    public static Dictionary<string, int> word_and_score = new Dictionary<string, int>();

    static void Main(string[] args)
    {

        //---A word-frequency list obtained through crawling web pages. You can assume you have an API that you give a word to and it returns you a number which represents how many times it shows up in web pages: 
        string str_input = "One tree two twoo tree two tree";
        Console.WriteLine("history words : "+ str_input);

        //--- read in the words as an array
        string s = Console.ReadLine();

        string[] words = str_input.Split(new[] {
        " "
        }, StringSplitOptions.None);


        //--- sort the words
        string[] sorted = words.OrderBy(o => o).ToArray();
        foreach (string s2 in sorted)
        {
            Console.WriteLine(s2);
        }

        Console.WriteLine();
        //--- load to Dictionary<string, int> where word from Crawler and int score (word-frequency) in crawling web pages
        //--- Dictionary<string, int> List to load to Redis to Autocomplete Creating a search index using a Redis hash and multiple sorted sets Query prediction prefixes ordered by frequency load from crawling with the score.
        word_and_score = getWordFrequencyFromCrawler(words);

        foreach (KeyValuePair<string, int> kvp in word_and_score)
        {
            Console.WriteLine("Word : "+kvp.Key + " Score: " + kvp.Value);  // Print the Repeated word and its count  
        }

        Console.ReadKey();
        System.Environment.Exit(1);

    }


    /// <summary>
    /// a function represents how many times word was included in crawling web pages
    /// </summary>
    /// <param name="words">string[] from Crawler</param>
    /// <returns> result Dictionary word and score - which represents how many times it was included in crawling web pages </returns>
    public static Dictionary<string, int> getWordFrequencyFromCrawler(string[] words)
    {
    
        for (int i = 0; i < words.Length; i++) //loop the splited string  
        {
            if (word_and_score.ContainsKey(words[i])) // Check if word already exist in dictionary update the count  
            {
                int value = word_and_score[words[i]];
                word_and_score[words[i]] = value + 1;
            }
            else
            {
                word_and_score.Add(words[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
            }
        }

        return word_and_score;
    }
}


