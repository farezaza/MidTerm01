using System;
enum Menu
{
    RegisterToEvent = 1,
    ShowAllParticipants = 2,
    Login = 3,
}
enum ClassMenu
{
    CollegeStudent = 1,
    Student = 2,
    Teacher = 3,
}
public class Program
{
    //static ParticipantList participantList;
    static void Main(string[] args)
    {
        Welcome();
        InputKeyboard();
    }
    static void PrepareListWhenProgramstartLoad()
    {
        //Program.participantList = new ParticipantList();
    }
    
    public static void Welcome()
    {
        Console.WriteLine("*************************************");
        Console.WriteLine("Welcome! Please select menu :");
        Console.WriteLine("1. Register new accout");
        Console.WriteLine("2. I already have an account");
        Console.WriteLine("*************************************");
    }
    public static void InputKeyboard()
    {
        string MenuSelect = "";
        Console.Write("Please select input : ");
        Console.ReadLine();
        switch (MenuSelect)
        {
        case "1":
        MenuForUn_RegisteredAccount();
            break;
        case "2":
        MenuForRegisteredAccount();
            break;
        }

    }
    public static void MenuForRegisteredAccount()
    {
        Console.WriteLine("**********************************");
        Console.WriteLine("1. Register to Event");
        Console.WriteLine("2. Show All Registered College Students");
        Console.WriteLine("3. Show All Registered Students");
        Console.WriteLine("4. Show All Registered Teachers");
        Console.WriteLine("**********************************");
        
    }
    public static void MenuForUn_RegisteredAccount()
    {
        Console.WriteLine("**********************************");
        Console.WriteLine("1. Register to Event");
        Console.WriteLine("2. Show All Registered Participants");
        Console.WriteLine("3. Sign up new account");
        Console.WriteLine("**********************************");
        
    }

}
