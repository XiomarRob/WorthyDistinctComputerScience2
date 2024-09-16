using System;

class Program {
  public static void Main (string[] args) {

    const double baseRate = 200.00;
    const double hourlyRate = 150.00;
    const double perMileRate = 2.00;

    Console.WriteLine("Enter the number of hours");
    var hourInput = Console.ReadLine();
    double hours;

    Console.Write("Enter the number of miles");
    
    var milesInput = Console.ReadLine();
    double miles;
    
    
    if (double.TryParse(hourInput, out hours) && double.TryParse(milesInput, out miles))
    {
      double total = baseRate + (hourlyRate * hours) + (perMileRate * miles);
      Console.WriteLine($"The moving fee is ${total:F2}");
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a valid number of both hours and miles.");
    }
  }
}