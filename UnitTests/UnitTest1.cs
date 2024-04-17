using NUnit;
using NUnit.Framework;
using MathGame;
namespace UnitTests;

public class Tests
{
    [Test] 
    public void CheckGameSelectionIsValid_ValidInput_ReturnsTrue() { // Arrange 
    string input = "1"; // Act 
    bool result = Helpers.CheckGameSelectionIsValid(input); // Assert 
    Assert.That(result); 
  }
}