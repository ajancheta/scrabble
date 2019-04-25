using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  class UserInterface
  {
    static void Main()
    {
      Console.WriteLine("Give me a word");
      string userInput = Console.ReadLine();
      Word newWord = new Word(userInput);
      int printOutWordScore = newWord.GetWordScore();
      Console.WriteLine(printOutWordScore);
    }
  }
}
