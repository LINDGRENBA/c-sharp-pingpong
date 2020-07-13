using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a positive whole number:");
    string stringUserInput = Console.ReadLine();
    int input = int.Parse(stringUserInput);

    for (int i = 1; i <= input; i++)
    {
        Console.WriteLine(i);
    }
  }
}
