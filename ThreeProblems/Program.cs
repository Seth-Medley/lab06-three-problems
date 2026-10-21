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

    if (score <= 60) {
        System.Console.WriteLine($"{score} earns an F");
    } else if (score >= 60 && score < 70) {
        System.Console.WriteLine($"{score} earns a D");
    } else if (score >= 70 && score < 80) {
        System.Console.WriteLine($"{score} earns a C");
    }
      else if ( score >= 80 && score < 90) {
        System.Console.WriteLine($"{score} earns a B");
    }
      else if (score >= 90) {
        System.Console.WriteLine($"{score} earns an A");
    }
}
if (choice == 2 || choice == 4) {
    // Exersize 2
}
if (choice == 3 || choice == 4) {
    // Exersize 3
}