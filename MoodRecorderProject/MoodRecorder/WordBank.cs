namespace MoodRecorder;
using System;
using System.IO;

public class WordBank
{
    List<string> Existing_happy_words = new List<string>();
    List<string> Existing_not_happy_words = new List<string>();
    List<string> ExistingHappinessTriggers = new List<string>();
    List<string> ExistingSadnessTriggers = new List<string>();
    List<string> MoodAdjectives = new List<string>();
    List<string> MoodTriggers = new List<string>();

    public WordBank(){
        if(!File.Exists("HappyWords.txt")){
            File.Create("HappyWords.txt");
        }
        if(!File.Exists("NotHappyWords.txt")){
            File.Create("NotHappyWords.txt");
        }
        if(!File.Exists("HappinessTriggers.txt")){
            File.Create("HappinessTriggers.txt");
        }
        if(!File.Exists("SadnessTriggers.txt")){
            File.Create("SadnessTriggers.txt");
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
    public void happiness_triggers(List<string> happiness_trigger_list)
    {
        foreach(string line in File.ReadLines("HappinessTriggers.txt")){
            ExistingHappinessTriggers.Add(line);
        }
        foreach(string word in happiness_trigger_list){
            if(!ExistingHappinessTriggers.Contains(word)){
                File.AppendAllText("HappinessTriggers.txt", word + Environment.NewLine);
            }
        }
    }
    public void sadness_triggers(List<string> sadness_trigger_list)
    {
        foreach(string line in File.ReadLines("SadnessTriggers.txt")){
            ExistingSadnessTriggers.Add(line);
        }
        foreach(string word in sadness_trigger_list){
            if(!ExistingSadnessTriggers.Contains(word)){
                File.AppendAllText("SadnessTriggers.txt", word + Environment.NewLine);
            }
        }
    }
    public List<string> SomeMoodAdjectives(){
        foreach(string line in File.ReadAllLines("HappyWords.txt")){
            MoodAdjectives.Add(line);
        }
        foreach(string line in File.ReadAllLines("NotHappyWords.txt")){
            MoodAdjectives.Add(line);
        }
        return MoodAdjectives;
    }
    public List<string> MoodTriggerPhrases(){
        foreach(string line in File.ReadAllLines("HappinessTriggers.txt")){
            MoodTriggers.Add(line);
        }
        foreach(string line in File.ReadAllLines("SadnessTriggers.txt")){
            MoodTriggers.Add(line);
        }
        return MoodTriggers;
    }
}