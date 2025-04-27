namespace MoodRecorder;
using Spectre.Console;
using System;
using System.IO;

public class UserType
{
    
    public UserType()
    {
        
    }
    public void new_user(){
        Console.WriteLine("Please enter a user name.");
        string user_name = Console.ReadLine();
        Console.WriteLine("Please enter a password (at least 6 characters long excluding empty spaces):");
        string user_password = Console.ReadLine();
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
    public void existing_user(List<string> CredentialsList)
    {
        Console.WriteLine("Please enter your username: ");
        string userN = Console.ReadLine();
        Console.WriteLine("Please enter your password");
        string userP = Console.ReadLine();
        string User_credentials = userN + ":" + userP;
        foreach(string line in File.ReadLines("User_IDs.txt")){
            CredentialsList.Add(line);
        }
        if(CredentialsList.Contains(User_credentials)){
            Console.WriteLine("You entered the correct credentials");
        }
        else{
            Console.WriteLine("Either the password or the username is incorrect");
        }
    }
}
