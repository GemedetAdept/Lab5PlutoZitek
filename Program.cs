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

Snippet.Break();
Snippet.Note("Addition");
Snippet.Note(valuesAdd(30.00002, 2));

// "Function which takes two numbers, subtracts them, returns the difference."
double valuesSubtract(double value1, double value2) {

	double valueDifference = value1 - value2;
	return valueDifference;
}

Snippet.Break();
Snippet.Note("Subtraction");
Snippet.Note(valuesSubtract(28, 53));

// "Function which takes two numbers, multiplies them, returns the product."
double valuesMultiply(double value1, double value2) {

	double valueProduct = value1 * value2;
	return valueProduct;
}

Snippet.Break();
Snippet.Note("Multiply");
Snippet.Note(valuesMultiply(5, 11));

// "Function which takes two numbers, divides them, returns the quotent."
double valuesDivide(double value1, double value2) {

	double valueQuotient = value1 / value2;
	return valueQuotient;
}

Snippet.Break();
Snippet.Note("Divide");
Snippet.Note(valuesDivide(3, 24));