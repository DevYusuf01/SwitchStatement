using Microsoft.VisualBasic;
/*
Console.WriteLine("Welcome to MGQS: Input your gender");
string gender = Console.ReadLine()!;
switch (gender)
{
    case "male":
    Console.WriteLine("Asalam Alaikum you are a male student");
    break;

    case "female":
    Console.WriteLine("Asalam Alaikum You are a female student");
    break;

    case "amaphrodite":
    Console.WriteLine("You should be proud to be one");
    break;

    case "bisexual":
    Console.WriteLine("You are a MF-ing nonetity");
    break;

    default: 
    Console.WriteLine("you are neither a male nor a female student");
    break;

}*/

/*Console.WriteLine("Calculator \n What operation would you like ");
string operation = Console.ReadLine()!.ToLower();
Console.WriteLine("Enter the two numbers");
Console.WriteLine("-------------------------");
Console.WriteLine("Enter the first number");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter second number");
int number2 = int.Parse(Console.ReadLine()!);
int operationResult;
switch (operation) 
{
    case "+":
    operationResult = number1 + number2;
    Console.WriteLine($"The answer of the operation is: {operationResult}");
    break;

    case "-":
    operationResult = number1 - number2;
    Console.WriteLine($"The answer for the operation is: {operationResult}");
    break;

    case "/":
    operationResult = number1 / number2;
    Console.WriteLine($"the answer for the operation is: {operationResult}");
    break;

    case "*":
    operationResult = number1 * number2;
    Console.WriteLine($"The answer for the operation is: {operationResult}");
    break;

    default:
    Console.WriteLine("Syntax error");
    break;

}*/

// Indenting and Spacing


Console.WriteLine("====== Simple Dice ======\nType 'Start' or 'S' to start or play");
string startGame = Console.ReadLine()!;

while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("You have provided an invalid key: ");
    Console.WriteLine("Enter 'Start' or 'S' to start the game properly!: ");
    Console.ResetColor();
    startGame = Console.ReadLine()!;
    
}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;
const int DOUBLE_POINT = 2;
const int TRIPLE_POINT = 3;
int totalScore = originalScore;


if (diceOne == diceTwo && diceTwo == diceThree && diceThree == diceOne)
{
    totalScore += TRIPLE_POINT;
    Console.WriteLine($"Dice one: {diceOne}\n Dice two: {diceTwo}\n Dice three: {diceThree}\nYou scored a Ballon and your total Score is: {totalScore}");
}
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    totalScore += DOUBLE_POINT;
    Console.WriteLine($"Dice One is: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nYou scored double points and your total Score is: {totalScore}");

}
else 
{
    Console.WriteLine($"Dice One is: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nYour total Score is: {totalScore}");
}

if (totalScore == 17)
{
    Console.WriteLine($"You have won a 15,000 MAH capacity power bank");
}
if (totalScore == 21)
{
    Console.WriteLine($"CONGRATS!!! You have won SAMSUNG GALAXY A23 for having a Lucky Number of: {totalScore}");
}
