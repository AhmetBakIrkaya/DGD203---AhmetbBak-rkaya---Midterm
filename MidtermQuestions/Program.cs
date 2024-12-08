using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Hello, {playerName}! You open your eyes. The last thing you remember is being knocked unconscious by a blow to your head from a large man. You are in a dark room and hear sounds...");
        Console.WriteLine("What will you do?\n");

        Console.WriteLine("1. Head towards the door.");
        Console.WriteLine("2. Search the room.");
        Console.WriteLine("3. Stay in bed and wait quietly.");
        Console.Write("Make your choice (1-3): ");
        string choice1 = Console.ReadLine();

        if (choice1 == "1")
        {
            Console.WriteLine($"You approach the door, {playerName}. The door is locked, but you can try to open it with the bobby pin in your hair. Do you take the pin and try to unlock the door?");
            Console.WriteLine("1. Yes, use the bobby pin.");
            Console.WriteLine("2. No, turn back..");
            Console.Write("Make your choice (1-2): ");
            string choice2 = Console.ReadLine();

            if (choice2 == "1")
            {
                Console.WriteLine($"You open the door and step into the hallway, {playerName}. However, at the end of the hallway, you encounter the man who knocked you unconscious! Will you try to run away, or will you hide somewhere else in the house?");
                Console.WriteLine("1. Try to run away..");
                Console.WriteLine("2. Hide somewhere else.");
                Console.Write("Make your choice (1-2): ");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.WriteLine($"You run, but the killer catches you. This is your end., {playerName}...");
                }
                else
                {
                    Console.WriteLine($"You hide in a closet, {playerName}. The killer can't find you and walks away. You manage to escape quietly. Congratulations!");
                }
            }
            else
            {
                Console.WriteLine($"You return to the room, and the sounds find you, {playerName}. This is your end...");
            }
        }
        else if (choice1 == "2")
        {
            Console.WriteLine($"You search the room and find a knife, {playerName}. Do you take the knife and head towards the door?");
            Console.WriteLine("1. Yes, head towards the door.");
            Console.WriteLine("2. No, leave the knife and continue searching the room..");
            Console.Write("Make your choice (1-2): ");
            string choice2 = Console.ReadLine();

            if (choice2 == "1")
            {
                Console.WriteLine($"You head towards the door, {playerName}. You come face to face with the killer. Do you use the knife?");
                Console.WriteLine("1. Yes, use the knife.");
                Console.WriteLine("2. No, try to run away.");
                Console.Write("Make your choice (1-2): ");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.WriteLine($"You neutralize the killer and manage to escape. Congratulations, {playerName}!");
                }
                else
                {
                    Console.WriteLine($"You try to escape, but the killer catches you. This is your end, {playerName}...");
                }
            }
            else
            {
                Console.WriteLine($"You drop the knife, and there isn't much time left to search, {playerName}. The killer finds you. This is your end...");
            }
        }
        else
        {
            Console.WriteLine($"You stay in bed and wait quietly, {playerName}. However, the killer finds you. This is your end...");
        }

        Console.WriteLine($"Game over. Thank you, {playerName}!");xx
    }
}
