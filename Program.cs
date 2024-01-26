
using System.IO; // For reading files.

/***********************
 * File reading section.
 ***********************/

static string[] readFile(string path)
{
    // Try-Catch verification.
    try
    {
        using (StreamReader reader = new StreamReader(path))
        {
            return File.ReadAllLines(path);
        }
    }
    catch (Exception e)
    {
        throw new IOException($"Error reading file: {path}", e);
    }
}

/******************
* Gameplay section.
*******************/

void advancePath()
{

}

int getPrompt()
{
    return 0;
}

static void displayPrompt(int nextPrompt)
{
    Console.WriteLine("Inside displayPrompt.");
}

void displayAnswerOptions()
{

}

int getAnswer()
{
    return 0;
}

// TODO: Stretch Goal.
void saveGame()
{

}

/*********************
* "Game over" section.
**********************/

bool isOver()
{
    return false;
}

// TODO: Stretch Goal.
int loadSave()
{
    return 0;
}

void displayPathTaken()
{

}

// Driver of the program.
static void Main(string[] args)
{
    // Declare starting variables.
    int nextPrompt = 0;

    // Load in necessary files.
    string[] promptFile = readFile("C:\\Users\\conho\\source\\repos\\Text-Based RPG Game\\promptFile.txt");
    string[] answerFile = readFile("C:\\Users\\conho\\source\\repos\\Text-Based RPG Game\\answerFile.txt");

    // TODO: Data verification. Remove this.
    foreach (var  prompt in promptFile)
    {
        Console.WriteLine(prompt);
    }

    foreach (var answer in answerFile)
    {
        Console.WriteLine(answer);
    }

    // Start the game.
    Console.WriteLine("||===================================||");
    Console.WriteLine("|| Welcome to Text-Based RPG Game... ||");
    Console.WriteLine("||===================================||");
    Console.WriteLine("");
    Console.WriteLine("This is the starting prompt for the game.");
    Console.WriteLine("This is the starting prompt for the game again.");
    Console.WriteLine("This is the starting prompt for the game a third time.");
    Console.WriteLine("This is the starting prompt for the game for the final time.");

    // (will-be) Game loop.
    displayPrompt(nextPrompt);
}

/************************
* Start the program.
************************/
Main(args);