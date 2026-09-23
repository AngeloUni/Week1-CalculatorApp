// ---!!!---///---!!!!///---!!!---///---!!!!///---!!!---///---!!!!///
// Week 1 Tutorials that are done in this file:
// Tutorial 9 (Creating a simple calculator app)
// Tutorial 10 (Using the IF statement (methods and if-else, GitHub sync) 
// ---!!!---///---!!!!///---!!!---///---!!!!///---!!!---///---!!!!///





// // Hello World
// Console.WriteLine("Hello, World!");


// // Variable
// int score = 4;
// Console.WriteLine("HI " + score);
// ConsoleKeyInfo keyy = Console.ReadKey();
// Console.WriteLine(keyy);





// // ---!!!---!!!--- CALCULATOR APP ---!!!---!!!---

// Calculator App - Variables
// int firstNumber = 5;
// int secondNumber = 20;
//
// int result = firstNumber + secondNumber;
// Console.WriteLine("The addition of both numbers is {0}", result);
// Console.ReadKey();

// Calculator App - Accepting User Input


CalculatorApp();
void CalculatorApp()
{
    // Declaring variables
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;
    
    
    // User Input - First and Second numbers
    Console.WriteLine("Type the first number followed by the Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type the first number followed by the Enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    
    // List of operators for the user to choose
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    choice = Convert.ToInt32(Console.ReadLine());


    // Depending on the User Choice, the if-statements will use the wanted operator
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} gives {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} and {secondNumber} gives {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} and {secondNumber} gives {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} gives {result}");
    }
    else
    {
        // Incase user doesn't pick a valid number for the operators given
        Console.WriteLine("You did not select a valid number between 1-4");
    }
}

// // ---!!!---!!!--- CALCULATOR APP ---!!!---!!!---