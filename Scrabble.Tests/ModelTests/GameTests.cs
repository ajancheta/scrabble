using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      //Arrange/Act: Gathering, declaring and or creating all necessary components for the test
      string userInput = "CAT";
      Word newWord = new Word(userInput);

      //Assert: Confirm functionality works as planned
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }


    [TestMethod]
    public void CreateCharArray_SplitWordIntoIndividualCharIntoArray_Char()
    {
      //Arrange
      string userInput = "CAT";
      Word newWord = new Word(userInput);

      //Act: Invoking the functionality that is being tested; often by calling a method
      char[] charArray = {'C', 'A', 'T'};
      char[] result = newWord.CharSplit("CAT");

      //Assert
      CollectionAssert.AreEqual(charArray, result);
    }
    // Test methods will go here.

    // [TestMethod]
    // public void AssignCharToValue_GiveEachLetterAValue_Int()
    // {
    //   //Arrange
    //   string userInput = "CAT";
    //   Word newWord = new Word(userInput);
    //
    //   //Act: Invoking the functionality that is being tested; often by calling a method
    //   int result = newWord.AssignCharToValue(5);
    //
    //   //Assert
    //   CollectionAssert.AreEqual(5, result);
    // }

  }
}
