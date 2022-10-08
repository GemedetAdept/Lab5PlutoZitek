// Lab 5 - Functions and Methods

// "Create a function that asks for user input and returns the user input"
void echoEcho() {

	Console.Write("Enter something to be echoed back > ");

	string userInput = "";
	userInput = Console.ReadLine();

	Snippet.Break();
	Console.WriteLine($"You said: \"{userInput}\"");
	Console.ReadKey();
}

echoEcho();