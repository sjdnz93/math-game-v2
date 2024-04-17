using MathGame;
using NUnit;
using NUnit.Framework;

namespace UnitTests;

public class Tests
{

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test] public void TestCheckGameSelectionIsValid_ValidInput_ReturnsTrue() 
    { 
      // Arrange 
      string userInput = "1"; 
      // Act 
      bool result = Helpers.CheckGameSelectionIsValid(userInput); 
      // Assert 
      Assert.That(result); 
    }

}