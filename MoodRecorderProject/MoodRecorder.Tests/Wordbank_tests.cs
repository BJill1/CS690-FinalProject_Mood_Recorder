namespace MoodRecorder.Tests;
using MoodRecorder;

public class WordBank_tests
{
    WordBank WordBankTests;
    List<string> TestHappyWords = new List<string> { "motivated", "cool" };

    public WordBank_tests()
    {
        WordBankTests = new WordBank();
        File.Delete("HappyWords.txt");
        File.AppendAllText("HappyWords.txt", "motivated" + Environment.NewLine);
    }
    [Fact]
    public void happy_words_test(){
        List<string> result = new List<string>();
        WordBankTests.happy_words(TestHappyWords);
        foreach(string line in File.ReadAllLines("HappyWords.txt")){
            result.Add(line);
        }
        var expected = new List<string> { "motivated", "cool" };
        Assert.Equal(expected, result);

    }
}