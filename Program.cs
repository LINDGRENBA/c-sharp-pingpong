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
      if (i % 5 == 0 && i % 3 ==0)
      {
        Console.WriteLine("Ping-Pong!");
      }
      else if (i % 3 == 0) 
      {
        Console.WriteLine("ping!");
      } 
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong!");
      }
      else 
      {
        Console.WriteLine(i);
      }
    }
  }
}