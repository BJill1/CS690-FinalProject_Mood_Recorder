namespace MoodRecorder;
using Spectre.Console;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var user_type = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("Existing User or New User?")
        .PageSize(10)
        .AddChoices(new[] {
            "existing user", "new user"
        }));
    
        string user_password;
        List<string> ListOfUser_credentials = new List<string>();
        if(user_type == "new user")
        {
            Console.WriteLine("Please enter a user name.");
            string user_name = Console.ReadLine();
            Console.WriteLine("Please enter a password (at least 6 characters long excluding empty spaces):");
            user_password = Console.ReadLine();
            if(user_password.Replace(" ", "").Length >= 6)
            {
                File.AppendAllText("User_IDs.txt", user_name + ":" + user_password.Replace(" ", "") + Environment.NewLine);
            }
            else
            {
                do{
                    Console.Write("Please enter a valid password");
                    user_password = Console.ReadLine();
                } while(user_password.Replace(" ", "").Length < 6);
                File.AppendAllText("User_IDs.txt", user_name + ":" + user_password.Replace(" ", "") + Environment.NewLine);
            }
        }
        else if(user_type == "existing user"){
            Console.WriteLine("Please enter your username: ");
            string userN = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string userP = Console.ReadLine();
            string User_credentials = userN + ":" + userP;
            foreach(string line in File.ReadLines("User_IDs.txt")){
                ListOfUser_credentials.Add(line);
            }
            if(ListOfUser_credentials.Contains(User_credentials)){
                Console.WriteLine("You entered the correct credentials");
            }
            else{
                Console.WriteLine("Either the password or the username is incorrect");
            }
        }
    }
}
