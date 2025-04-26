namespace MoodRecorder;
using System;
using System.IO;

public class WordBank
{
    List<string> Existing_happy_words = new List<string>();
    List<string> Existing_not_happy_words = new List<string>();

    public WordBank(){
        if(!File.Exists("HappyWords.txt")){
            File.Create("HappyWords.txt");
        }
        if(!File.Exists("NotHappyWords.txt")){
            File.Create("NotHappyWords.txt");
        }
    }
    public void happy_words(List<string> happy_word_list)
    {
        foreach(string line in File.ReadLines("HappyWords.txt")){
            Existing_happy_words.Add(line);
        }
        foreach(string word in happy_word_list){
            if(!Existing_happy_words.Contains(word)){
                File.AppendAllText("HappyWords.txt", word + Environment.NewLine);
            }
        }
    }
    public void Not_happy_words(List<string> Not_happy_word_list)
    {
        foreach(string line in File.ReadLines("NotHappyWords.txt")){
            Existing_not_happy_words.Add(line);
        }
        foreach(string word in Not_happy_word_list){
            if(!Existing_not_happy_words.Contains(word)){
                File.AppendAllText("NotHappyWords.txt", word + Environment.NewLine);
            }
        }
    }

}