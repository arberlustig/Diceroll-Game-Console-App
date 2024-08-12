using System.ComponentModel.Design;

diceRollgame game = new diceRollgame();
game.displayMenu();
Console.ReadKey();
class diceRollgame
{

    //fields
    public int randomNumber;
    public int triesLeft;
    public int Tries = 3;
    public string? userGuess;
    public int finalNumber;
    public Random diceNumber = new Random();
    public bool isInteger;

    public void displayMenu()
    {
        //initialize the random number 
        randomNumber = diceRolling();
        Console.WriteLine(" Dice rolled. Guess what number it shows in 3 tries ");
        do
        {

            Console.WriteLine("Enter your Number:");
            userGuess = Console.ReadLine();
            isInteger = int.TryParse(userGuess, out finalNumber);
            if (!isInteger)
            {
                Console.WriteLine("That is not a number ;)");
            }
            else if (finalNumber > 6 || finalNumber < 1)
            {
                Console.WriteLine("Dices don't have this number on it mate.");


            }
            else if (finalNumber != randomNumber)
            {
                Console.WriteLine("Wrong number");
                Tries--;
            }
            checkIfItsOver(Tries);

        } while (finalNumber != randomNumber);

        Console.WriteLine("You won!");


    }
    //random Number 
    public int diceRolling()
    {
        return diceNumber.Next(1, 6);
    }

    //if there are no tries, exit the program
    void checkIfItsOver(int Tries)
    {
        if (Tries == 0)
        {
            exitProgramm();

        }
    }

    void exitProgramm()
    {
        Console.WriteLine("Unfortunately you didn't guess the right number :( Bye! ");
        Console.ReadKey();
        Environment.Exit(0);
    }


}