using System;

namespace CupsOfCoffee
{
  public class MyCodeBlock
  {
    public static void CodeBlock(string[] args)
    {
      //Declare variable "cupsOfCoffee"
      var cupsOfCoffee = 2;

      //Declare variable "fullName" and set it to my full name
      var fullName = "Evan Gilbert";

      //Declare variable "today" and set it to today
      //ADVENTURE: Use the type DateTime to represent today
      var today = DateTime.Today;

      //Output all 3 variables to one line using Console.WriteLine
      Console.WriteLine(fullName + " drank " + cupsOfCoffee + " cups of coffee on " + today);

      //Ask user for their name and store it in a variable called "user"
      Console.WriteLine("Please enter your name:");

      var user = Console.ReadLine();

      //Print out a greeting to the user using their name
      //ADVENTURE: Some logic that prints out a special statement if the username is "Alice"
      if (user == "Alice")
      {
        Console.WriteLine("Hello, Alice! A special welcome to you!");
      }
      else
      {
        Console.WriteLine("Hello, " + user + "!");
      }

      //Ask the user to input 2 numbers
      Console.WriteLine("Please provide 2 numbers for me to do some math with:");

      //Get the 2 numbers as strings using Console.ReadLine
      var number1 = Console.ReadLine();
      var number2 = Console.ReadLine();

      //Convert both to double using double.parse and store in operand1 and operand2
      var operand1 = double.Parse(number1);
      var operand2 = double.Parse(number2);

      //Add the 2 operands and save in "sum" variable
      var sum = operand1 + operand2;

      //Subtract the operands and save in "difference" variable
      var difference = operand1 - operand2;

      //Divide the operands and save in "quotient" variable
      var quotient = operand1 / operand2;

      //Multiply the operands and save in "product" variable
      var product = operand1 * operand2;

      //Find remainder when one operand is divided by the other and save in "remainder" variable
      var remainder = operand1 % operand2;

      //Print all results to screen in meaningful way
      Console.WriteLine("The sum of the 2 numbers entered is: " + sum);
      Console.WriteLine("The difference between the 2 numbers entered is: " + difference);
      Console.WriteLine("The quotient of the 2 numbers entered is: " + quotient);
      Console.WriteLine("The product of the 2 numbers entered is: " + product);
      Console.WriteLine("The remainder from dividing number 1 by number 2 is: " + remainder);
    }
  }
}