using Marbles;
using System.Text; 






Marble marble1 = new Marble(1, "blue", "Bob", 0.5);
Marble marble2 = new Marble(2, "red", "John Smith", 0.25);
Marble marble3 = new Marble(3, "violet", "Bob O' Bob", 0.5);
Marble marble4 = new Marble(4, "indigo", "Bob Dad-Bob", 0.75);
Marble marble5 = new Marble(5, "yellow", "Jhon", 0.5);
Marble marble6 = new Marble(6, "orange", "Bob", 0.25);
Marble marble7 = new Marble(9, "green", "Bob Ob", 0.75);
Marble marble8 = new Marble(8, "blue", "Bob", 0.25);
Marble marble9 = new Marble(10, "blue", "Bob", 0.5);
Marble marble10 = new Marble(7, "blue", "Smith", 0.5);


List<Marble> inputMarbles = new List<Marble>();

inputMarbles.Add(marble1);
inputMarbles.Add(marble2);
inputMarbles.Add(marble3);
inputMarbles.Add(marble4);
inputMarbles.Add(marble5);
inputMarbles.Add(marble6);
inputMarbles.Add(marble7);
inputMarbles.Add(marble8);
inputMarbles.Add(marble9);
inputMarbles.Add(marble10);

Console.WriteLine("Input Marbles:");
Console.WriteLine("___________________");



foreach (Marble marble in inputMarbles)
{
    Console.WriteLine("Marble - " + marble + ", Palindrome? " + StringHelper.IsPalindrome(marble.Name));
}

Console.WriteLine("");
Console.WriteLine("Sorted and Filterd Marbles:");
Console.WriteLine("___________________");

List<Marble> outputMarbles = MarbleProcessor.SortAndFilter(inputMarbles);

foreach (Marble marble in outputMarbles)
{
    Console.WriteLine("Marble - " + marble + ", Palindrome? " + StringHelper.IsPalindrome(marble.Name));
}


/*
marble.Id = 1;
marble.Color = "blue";
marble.Name = "Bob";
marble.Weight = 0.5;
















//*Console.WriteLine("Hello, World!");
	/*String userInput;
Console.WriteLine("Enter String");
	userInput = Console.ReadLine();
Console.WriteLine(" You Typed: " + userInput);


Console.WriteLine("Guess a random number between 1 and 10:");
int userGuess = int.Parse(Console.ReadLine());
Console.WriteLine("You guessed: " + userGuess);

Random rnd = new Random();
int computerGuess = rnd.Next() % 10 + 1;

Console.WriteLine("The computer guessed: " + computerGuess);

if (userGuess == computerGuess)
{
    Console.WriteLine("You got it right!");
}
else
{
    Console.WriteLine("That is wrong, good try");
}

//String userInput;
Console.WriteLine("Enter a string:");

userInput = Console.ReadLine();
Console.WriteLine("You typed: " + userInput);

while (userInput != "Hello")
{
    Console.WriteLine("I don't understand, can you try again?");
    userInput = Console.ReadLine();
    Console.WriteLine("You typed: " + userInput);
}

Console.WriteLine("Nice to meet you");
	*/

