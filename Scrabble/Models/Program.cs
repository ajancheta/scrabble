using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  class UserInterface
  {
    static void Main()
    {

      Word newWord = new Word();
      Console.WriteLine("Enter a word to recieve a score");
      string userInput = Console.ReadLine();
      Console.WriteLine("------------");
      Console.WriteLine("Your Scrabble score for " + userInput + " is " + newWord.TotalWordScore(userInput));
      Console.WriteLine("Play again? [Y]es [N]o");
      string playAgain = Console.ReadLine().ToUpper();
      Console.WriteLine("------------");

      while(playAgain == "Y")

        {

          Console.WriteLine("Enter another word to recieve a score");
          string newUserInput = Console.ReadLine();
          Console.WriteLine("------------");
          Console.WriteLine("Your new scrabble score for " + newUserInput + " is " + newWord.TotalWordScore(newUserInput));
          Console.WriteLine("Keep playing? [Y]es [N]o");


        }
          if (playAgain == "N")
        {
          Console.WriteLine("See ya!!!");
        }
    }
  }
}
