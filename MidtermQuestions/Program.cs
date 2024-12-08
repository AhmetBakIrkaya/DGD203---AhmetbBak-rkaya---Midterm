using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Hello, {playerName}! You open your eyes. The last thing you remember is being knocked unconscious by a blow to your head from a large man. You are in a dark room and hear sounds...\"");

        Console.WriteLine("The questions are starting.");
        
        Console.WriteLine("Question 1: Do you head towards the door? (Yes / No)");
        string choice1 = Console.ReadLine().ToLower();

        Console.WriteLine("Question 2: Do you search the room? (Yes / No)");
        string choice2 = Console.ReadLine().ToLower();

        Console.WriteLine("Question 3: Do you take the knife you saw while looking around the room? (Yes / No)");
        string choice3 = Console.ReadLine().ToLower();

        Console.WriteLine("Question 4: Are you determined to escape this unknown place no matter what? (Yes / No)");
        string choice4 = Console.ReadLine().ToLower();
        
        if (choice1 == "yes" && choice2 == "yes" && choice3 == "yes" && choice4 == "yes")
        {
            Console.WriteLine($"You encounter the killer, {playerName}. Using the knife, you neutralize the killer and manage to escape him but his partner caught you.!");
        }
        else if (choice1 == "yes" && choice2 == "yes" && choice3 == "yes")
        {
            Console.WriteLine($"You encounter the killer, {playerName}. You use the knife, but you can’t muster the courage to kill, so you fail to escape.");
        }
        else if (choice1 == "yes" && choice4 == "yes")
        {
            Console.WriteLine($"The killer chases you, {playerName}. You try to run, but without anything to defend yourself, you get caught.");
        }
        else if (choice2 == "yes" && choice3 == "yes")
        {
            Console.WriteLine($"You search the room, {playerName}. You find a knife, and as the killer opens the door and tells their partner to lock it behind them, you neutralize the killer! Afterward, you quietly slip out of the room using the spare key you found inside.");
        }
        else if (choice3 == "yes")
        {
            Console.WriteLine($"You search the room, {playerName}. You find a knife, and as the killer opens the door and tells their partner to lock it behind them, you neutralize the killer! However, you’re still trapped in the room.");
        }
        else if (choice4 == "yes")
        {
            Console.WriteLine($"You try to escape, {playerName}, but your desire to run alone isn’t enough to save you. The killer catches you...");
        }
        else
        {
            Console.WriteLine($"You do nothing, {playerName}. The killer enters the room, and your end has come...");
        }

        Console.WriteLine($"Game over. Thanks you {playerName}!");
    }
}


// I got help from ChatGPT while doing the project sir.