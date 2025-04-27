namespace MoodRecorder;


class Program
{
    static void Main(string[] args)
    {
        ConsoleUI ProgramUI = new ConsoleUI();
        ProgramUI.show();

        string[] Some_happy_words = { "fantastic", "hopeful", "joyful", "relaxed", "cheerful", "delighted", "peaceful" };
        string[] Some_sad_words = { "lonely", "heartbroken", "miserable", "depressed", "hopeless", "somber", "dejected" };
        List<string> HappyWords_to_addList = new List<string>();
        List<string> SadWords_to_addList = new List<string>();
        foreach(var wrd in Some_happy_words){
            HappyWords_to_addList.Add(wrd);
        }
        foreach(var wrd in Some_sad_words){
            SadWords_to_addList.Add(wrd);
        }
        WordBank Words_to_add = new WordBank();
        Words_to_add.happy_words(HappyWords_to_addList);
        Words_to_add.Not_happy_words(SadWords_to_addList);   
    }
}
