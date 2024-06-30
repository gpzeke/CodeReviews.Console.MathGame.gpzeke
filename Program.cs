/*
Requirements:
- You need to create a Math game containing the 4 basic operations
- The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
- Users should be presented with a menu to choose an operation
- You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
- You don't need to record results on a database. Once the program is closed the results will be deleted.

Challenge Objectives:
- Try to implement levels of difficulty.
- Add a timer to track how long the user takes to finish the game.
- Add a function that let's the user pick the number of questions.
- Create a 'Random Game' option where the players will be presented with questions from random operations
*/

static void DisplayMainMenu()
{
    Console.Clear();
    Console.WriteLine("Please select an option:");
    Console.WriteLine("1 - Addition Challenge");
    Console.WriteLine("2 - Subtraction Challenge");
    Console.WriteLine("3 - Multiplication Challenge");
    Console.WriteLine("4 - Division Challenge");
    Console.WriteLine("5 - Random Challenge");
    Console.WriteLine("6 - Game History");
    Console.WriteLine("7 - Difficulty");
    Console.WriteLine("0 - Quit");
}

static int GetUserInput(int rangeMinimum, int rangeMaximum)
{
    int validatedInput = -1;

    do
    {
        DisplayMainMenu();
        Console.WriteLine("\nPlease select a valid option:");
    } while (!int.TryParse(Console.ReadLine(), out validatedInput) && !(validatedInput < rangeMinimum) || validatedInput > rangeMaximum);

    return validatedInput;
}