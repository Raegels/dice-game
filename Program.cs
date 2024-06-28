// current build time: 1 hour <-- will be updated as I will continue to expand this game.

// I want to make a dice game to keep exercising logical thinking 

// first i want to make 6 dice  and in each of the dice i want there to appear a number between 1 and 6.

// |_| |_| |_| |_| |_| |_|     

// then i want to check whether the dice has three of a kind, four of a kind, small street, large street, full house or yahtzee.
// In between throws i want the player to be able to select the dice numbers that the player wants to keep and which ones to throw again.
// Player has three throws in total. 
// at the end i would want to implement a little time between the throws so they appear on the screen like a slot machine.

// scores:
// three of a kind: 10
// four of a kind: 20
// full house: 30
// small street: 30
// large street: 40
// Yahtzee: 50



// array for the dice numbers
int[] diceArray = { 0, 0, 0, 0, 0, 0 };

// variable for counting throws
int throwCount = 0;


// gameplay 

Console.WriteLine("Welcome to the dice game!");
Console.WriteLine("You have three throws to get the highest score!");
Console.WriteLine();
DrawDice();
Console.WriteLine();
Console.ReadKey();
Console.WriteLine("Press enter to start with your first throw");



do
{
    PlayerThrow();

    // I have an array with random numbers. Program will execute three times now, generating three different arrays. 
    // Next step: letting the player choose which dice the keep (if possible!)
    // Next step: implementing logic to see if there is a three of a kind, full house and so on in the array and assigning a score to each of them.


} while (throwCount < 3);



//method for randomly picking a "number" from diceOptions 6 times.

void PlayerThrow()
{
    int[] diceOptions = { 1, 2, 3, 4, 5, 6 };

    for (int i = 0; i < 6; i++)
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(0, diceOptions.Length);
        int diceThrow = diceOptions[randomIndex];
        diceArray[i] = diceThrow;

    }
    DrawDice();
    Console.WriteLine();
    throwCount++;

}



// method for drawing the dice

void DrawDice()
{
    for (int i = 0; i < 6; i++)
    {
        Console.Write("|" + diceArray[i] + "|");
    }

}