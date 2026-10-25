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
/////////////////////////////////////
using System.Dynamic;

/// Menu 
int choice = 0;
const int SEED = 4000;
const int NUM_SCORES = 5;
const int PASSING_GRADE = 60;
Random rng = new Random(SEED);

do // The menu must display at least once before the user can choose to quit.
{
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

Console.Write("Choose 1 through 5: ");
choice = Convert.ToInt32(System.Console.ReadLine());
while (choice < 1 || choice > 5) // Repeats until they give a valid choice number.
{
    Console.WriteLine("Choose a number from 1 to 5.");
    Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}
/////////////////////////////////////////////
/// Choices
//////////////////////////////
if (choice == 1 || choice == 4) {
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");

    System.Console.Write("Score: ");
    int score = Convert.ToInt32(System.Console.ReadLine());
    while(score < 0 || score > 100)  //The program cannot proceed until the user enters a valid score between 0 and 100.
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
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
    int winCounter = 0;
    int rollCounter = 0;
    string keepRolling = "";
     do // Has to run at least once before asking if they want to roll again.
    {
    int die1 = rng.Next(1,7);
    int die2 = rng.Next(1,7);
    int total = die1 + die2;
    rollCounter++;
    if (die1 == 1 && die2 == 1)
    {
        Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}. Snake eyes.");
    } else if (die1 == die2)
    {
        Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}. Doubles!");
    } else if (total == 7 || total == 11)
    {
        winCounter++;
        Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}. A winner.");
    } else {
             Console.WriteLine($"Roll {rollCounter}: {die1} and {die2}, total {total}.");
    }

    Console.Write("Roll again? (y/n): ");
    keepRolling = Console.ReadLine();
    }while(keepRolling == "y");
    Console.WriteLine($"You rolled {rollCounter} times and won {winCounter}.");
}
if (choice == 3 || choice == 4) {
 System.Console.WriteLine("=== Exercise 3: The Score Report ===");

 int[] scores = new int[NUM_SCORES];
 for (int i = 0; i < scores.Length; i++) // I need the index variable 'i' so I can print the different cores in the prompt.
    {
        Console.Write($"Score {i+1}: ");
        scores[i] = Convert.ToInt32(Console.ReadLine());
    }

    int total = 0;
    int highest = 0;
    int passing = 0;

    foreach (int score in scores) // I need to process every score in the array.
    {
        total +=score;
        if (score > highest)
        {
            highest = score;
        }
        if (score >= PASSING_GRADE)
        {
            passing++;
        }
    }

    double average = (double)total / scores.Length;

    Console.WriteLine($"Scores entered: {scores.Length}");
    Console.WriteLine($"Total: {total}");
    Console.WriteLine($"Average: {average:F1}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Passing: {passing} of {scores.Length}");
} 
} while(choice != 5);
System.Console.WriteLine("Goodbye.");