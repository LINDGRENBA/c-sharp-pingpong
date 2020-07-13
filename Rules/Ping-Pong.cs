using System;
using PingPongNameSpace;

public class Logic
{

  public string CheckUserNumber(int input)
  {
    for (int i = 1; i <= input; i++)
    {
      if (i % 5 == 0 && i % 3 ==0)
      {
        return "Ping-Pong!";
      }
      else if (i % 3 == 0) 
      {
        return "ping!";
      } 
      else if (i % 5 == 0)
      {
        return "pong!";
      }
      else 
      {
        return i;
      }
    }
  }
}