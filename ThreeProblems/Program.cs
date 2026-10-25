/*
* Name: Seth Medley
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/
///////////////////////////////////////////
/// Menu 
/////////////////////////////////////
int choice = 0;
Random rng = new Random(4000);

System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

System.Console.WriteLine("Choose 1 through 5: 7");
System.Console.WriteLine("Choose a number from 1 to 5.");
System.Console.WriteLine("Choose 1 through 5: 3");

choice = Convert.ToInt32(System.Console.ReadLine());
/////////////////////////////////////////////
/// Choices
//////////////////////////////
if (choice == 1 || choice == 4) {
    System.Console.WriteLine("=== Exersice 1: The Grade Checker ===");

    System.Console.WriteLine("What is your score?");
    int score = Convert.ToInt32(System.Console.ReadLine());
    while(score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100.");
        System.Console.Write("Score: ");
        score = Convert.ToInt32(System.Console.ReadLine());
    }
    if (score >= 90) {
    System.Console.WriteLine($"{score} earns an A.");
    } 
    else if (score >= 80) {
    System.Console.WriteLine($"{score} earns a B.");
    } 
    else if (score >= 70) {
    System.Console.WriteLine($"{score} earns a C.");
    }
    else if (score >= 60) {
    System.Console.WriteLine($"{score} earns a D.");
    }
    else {
    System.Console.WriteLine($"{score} earns an F.");
    }
}
if (choice == 2 || choice == 4) {
    System.Console.WriteLine("=== Exersice 2: The Dice Table ===");
    int winCounter = 0;
    int rollCounter = 0;
    string keepRolling = "";

    rollCounter++;
     do
    {
    int die1 = rng.Next(1,7);
    int die2 = rng.Next(1,7);
    int total = die1 + die2;
        if (die1 == 1 && die2 == 1)
    {
        Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}. Snake eyes.");
    } else if (die1 == die2)
    {
        Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}. Doubles!");
    } else if (total == 7 || total == 11)
    {
        winCounter++;
        rollCounter++;
        Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}. A winner.");
    }

    Console.Write("Roll again? (y/n): ");
    keepRolling = Console.ReadLine();
    }while(keepRolling == "y");
    Console.WriteLine($"You rolled {rollCounter} times and won {winCounter}.");
}
if (choice == 3 || choice == 4) {
    // Exersize 3
}