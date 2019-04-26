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
    public void Word_ReturnLetterScore_Int()
    {
      //Arrange: Gathering, declaring and or creating all necessary components for the test
      Word newWord = new Word();

      //Act: Invoking the functionality that is being tested; often by calling a method
      int result = newWord.LetterValue('Z');

      //Assert: Confirm functionality works as planned
      Assert.AreEqual(10, result);
    }


    [TestMethod]
    public void CreateCharArray_SplitWordIntoIndividualCharIntoArray_Char()
    {
      //Arrange
      // string userInput = "CAT";
      Word newWord = new Word();

      //Act: Invoking the functionality that is being tested; often by calling a method
      char[] testArray = {'C', 'A', 'T'};
      char[] result = newWord.WordToChar("CAT");

      //Assert
      CollectionAssert.AreEqual(testArray, result);
    }

    [TestMethod]
    public void Word_FindLetterValueInDictionaryAndAddScoreTotal_Int()
    {
      //Arrange
      // string userInput = "CAT";
      Word newWord = new Word();

      //Act
      int result = newWord.TotalWordScore("cat");

      //Assert
      Assert.AreEqual(5, result);
    }
  }
}
