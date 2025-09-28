bool performCalculation = true;

do
{
  Console.WriteLine("Type the first number: ");
  string? firstNumber = Console.ReadLine();

  Console.WriteLine("Type the second number: ");
  string? secondNumber = Console.ReadLine();

  if (string.IsNullOrEmpty(firstNumber) || string.IsNullOrEmpty(secondNumber))
  {
    throw new Exception("Type valid numbers.");
  }

  Console.WriteLine("Which operation? (addition, subtraction, multiplication, division or modulo)");
  string? operation = Console.ReadLine();

  float parsedFirstNumber = float.Parse(firstNumber);
  float parsedSecondNumber = float.Parse(secondNumber);

  float result;

  switch (operation)
  {
    case "addition":
      result = parsedFirstNumber + parsedSecondNumber;
      break;

    case "subtraction":
      result = parsedFirstNumber - parsedSecondNumber;
      break;

    case "multiplication":
      result = parsedFirstNumber * parsedSecondNumber;
      break;

    case "division":
      result = parsedFirstNumber / parsedSecondNumber;
      break;
    case "modulo":
      result = parsedFirstNumber % parsedSecondNumber;
      break;
    default:
      throw new Exception("Choose a valid operation.");
  }

  Console.WriteLine("========================================");
  Console.WriteLine($"Result is: {result}");
  Console.WriteLine("========================================");

  Console.WriteLine($"Would you like another calculation? (yes/no)");

  string? anotherCalculation = Console.ReadLine();

  if (anotherCalculation == "no")
  {
    Console.WriteLine("Bye! :)");
    performCalculation = false;
  }
  
} while (performCalculation);
