namespace MoodRecorder;


class Program
{
    static void Main(string[] args)
    {
        ConsoleUI ProgramUI = new ConsoleUI();
        ProgramUI.show();

        string[] Some_happy_words = { "fantastic", "hopeful", "joyful", "relaxed", "cheerful", "delighted", "peaceful" };
        string[] Some_sad_words = { "lonely", "heartbroken", "miserable", "depressed", "hopeless", "somber", "dejected" };
        string[] Some_happiness_triggers = { "had a good night sleep", "went to a park yesterday", "welcome a grandson", "watching a fun movie", "painting", "hanging out with friends", "went to the gym" };
        string[] Some_sadness_triggers = { "spent much time alone", "lost a loved one", "Look down on myself", "had arguments with some friends", "did not sleep well overnight", "stuck on a project", "having some painful memories", "financially unstable"};
        List<string> HappyWords_to_addList = new List<string>();
        List<string> SadWords_to_addList = new List<string>();
        List<string> SadnessTriggers_to_addList = new List<string>();
        List<string> HappinessTriggers_to_addList = new List<string>();
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
