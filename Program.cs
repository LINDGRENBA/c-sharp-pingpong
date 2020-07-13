using System;

namespace PingPongNameSpace
{
  class PingPong
  {
    static void Main()
    {
      Console.WriteLine("Enter a positive whole number:");
      string stringUserInput = Console.ReadLine();
      int input = int.Parse(stringUserInput);
      Console.WriteLine(CheckUserNumber(input));
    }
  }
}