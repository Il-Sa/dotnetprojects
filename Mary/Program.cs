Console.WriteLine("Mary's day");

Console.WriteLine("What is the day today?");

string answer = Console.ReadLine();


if (answer == "working day")
{
    Console.WriteLine("Need to go to the work");
}

else if (answer == "holiday")
{
    Console.WriteLine("What is the weather?");

    string weather = Console.ReadLine();

    if (weather == "sun")
    {
        Console.WriteLine("Go to the beach!");
    }

    else if (weather == "rain")
    {
        Console.WriteLine("Go to the shopping center!");
    }

    else
    {
        Console.WriteLine("Stay at home!");
    }
}
else

{
    Console.WriteLine("No match");
}



