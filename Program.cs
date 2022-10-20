/*
Caroline Hana
10-19-2022
Madlib Mini Challenge 5
input answers to questions to make a story
*/

Console.Clear();
string? playAgain = "yes";
while (playAgain == "yes")
{

    string? name, color, location, car, restaurant, animal, month, emotion,
     noun, food;

    Console.WriteLine("What is your name?");
    name = Console.ReadLine();

    Console.WriteLine("What's your favorite color?");
    color = Console.ReadLine();

    Console.WriteLine("Name a location: ");
    location = Console.ReadLine();

    Console.WriteLine("Name a car: ");
    car = Console.ReadLine();

    Console.WriteLine("Name a restaurant");
    restaurant = Console.ReadLine();

    Console.WriteLine("What is your favorite animal?");
    animal = Console.ReadLine();

    Console.WriteLine("Name a month: ");
    month = Console.ReadLine();

    Console.WriteLine("How are you feeling today?");
    emotion = Console.ReadLine();

    Console.WriteLine("Name a noun: ");
    noun = Console.ReadLine();

    Console.WriteLine("What's your favorite food?");
    food = Console.ReadLine();

    Console.WriteLine($"{name} is a monster. Who lives in the deep {location}. I love to eat at {restaurant} and I always get {food}. I have a pet {animal}, their name is {month}.");
    Console.WriteLine($"I also have a {color} {car}. I am a {emotion} {noun}.");

    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer == "yes")
        {
            playAgain = answer;
        }
        else if (answer == "no")
        {
            playAgain = answer;
        }
        else
        {
            Console.WriteLine("Invalid Answer");
        }

    }




}