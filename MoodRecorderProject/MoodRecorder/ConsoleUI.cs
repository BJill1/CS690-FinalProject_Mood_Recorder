namespace MoodRecorder;
using Spectre.Console;
using System;
using System.IO;

public class ConsoleUI
{
        UserType ExistingOrNewUser = new UserType();
        List<string> ListOfUser_credentials = new List<string>();
    public ConsoleUI()
    {

    }
    public void show()
    {
        var user_type = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Existing User or New User?")
        .PageSize(10)
        .AddChoices(new[] {
            "existing user", "new user"
        }));
        if(user_type == "new user")
        {
            ExistingOrNewUser.new_user();
            Console.Write("Now sign in with your login credentials");
            ExistingOrNewUser.existing_user(ListOfUser_credentials);

        }
        else if(user_type == "existing user"){
            ExistingOrNewUser.existing_user(ListOfUser_credentials);
        }
    }
}
