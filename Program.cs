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

// echoEcho();

// "Create a function that takes two numbers as paramaters adds them together and returns the sum of the two numbers."
double valuesAdd(double value1, double value2) {

	double valueSum = value1 + value2;
	return valueSum;
}

Console.WriteLine(valuesAdd(30.00002, 2));