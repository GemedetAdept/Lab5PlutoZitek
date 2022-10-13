// Lab 5 - Functions and Methods

// "Create a `void` function which displays a cat on the console"
void displayKitty() {
	string asciiKitty = @$"
      ^    ^
     / \  / \
   _/---LJ---\_
  /            \
 /  /*@\  /*@\  \
|   \__/  \__/   |
|       __       |
 \__    \/    __/
    *--------*
      /    \            .---.
    _*      *_         / /--/
  ./          \.       | |
  |            |     _-/ /
 .|            |.   * ._/
./              \._/ /
|                |__/
\_              _/
  *------------*";

Console.WriteLine(asciiKitty);
}


// "Create a function that asks for user input and returns the user input"
void echoEcho() {

	Console.Write("Enter something to be echoed back > ");

	string userInput = "";
	userInput = Console.ReadLine();

	Snippet.Break();
	Console.WriteLine($"You said: \"{userInput}\"");
	Console.ReadKey();
}

// "Create a function that takes two numbers as paramaters adds them together and returns the sum of the two numbers."
double valuesAdd(double value1, double value2) {

	double valueSum = value1 + value2;
	return valueSum;
}


// "Function which takes two numbers, subtracts them, returns the difference."
double valuesSubtract(double value1, double value2) {

	double valueDifference = value1 - value2;
	return valueDifference;
}


// "Function which takes two numbers, multiplies them, returns the product."
double valuesMultiply(double value1, double value2) {

	double valueProduct = value1 * value2;
	return valueProduct;
}


// "Function which takes two numbers, divides them, returns the quotent."
double valuesDivide(double value1, double value2) {

	double valueQuotient = value1 / value2;
	return valueQuotient;
}


// "Driver program 'menu,' allow user to choose arithmetic option"
void selectionMenu() {
	Console.WriteLine("--- Arithmetic Operation Selection ---");
	Snippet.Break();
	Console.WriteLine("[1] - Addition");
	Console.WriteLine("[2] - Subtration");
	Console.WriteLine("[3] - Multiplication");
	Console.WriteLine("[4] - Division");
	Console.WriteLine("[5] - (Extra menu options...)");
	Snippet.Break();
	Console.Write("Enter option number > ");

	string userSelection = "";
	userSelection = Console.ReadLine();

	string operatorSelection = "";
	string operatorSymbol = "";
	switch (userSelection) {

		case "1":
			operatorSelection = "add";
			operatorSymbol = "+";
			valueInput();
			break;
		case "2":
			operatorSelection = "subtract";
			operatorSymbol = "-";
			valueInput();
			break;
		case "3":
			operatorSelection = "multiply";
			operatorSymbol = "*";
			valueInput();
			break;
		case "4":
			operatorSelection = "divide";
			operatorSymbol = "/";
			valueInput();
			break;
		case "5":
			extraMenu();
		default:
			catchError();
			break;
	}
}

// Extra TODO: Add extra menu to display options for ASCII cat and "echo" function.
void extraMenu() {

}

void valueInput() {
	
	Console.WriteLine($"Enter two numbers to {operatorSelection}:");
	Snippet.Break();

	int firstNumber = 0;
	Console.Write("First number > ");
	firstNumber = int.Parse(Console.ReadLine());

	int secondNumber = 0;
	Console.Write("Second number > ");
	secondNumber = int.Parse(Console.ReadLine());

	Snippet.Break();
	Console.WriteLine($"Evaluating: [ {firstNumber} {operatorSymbol} {secondNumber} ]");

	double operationResult = 0.0;

	switch (userSelection) {

		case "1":
			operationResult = valuesAdd(firstNumber, secondNumber);
			break;
		case "2":
			operationResult = valuesSubtract(firstNumber, secondNumber);
			break;
		case "3":
			operationResult = valuesMultiply(firstNumber, secondNumber);
			break;
		case "4":
			operationResult = valuesDivide(firstNumber, secondNumber);
			break;
		default:
			catchError();
			break;
	}

	Snippet.Break();

	Console.WriteLine($"Result = {operationResult}");
}

void catchError() {
	Console.WriteLine("Invalid input.");
}
