using MathGame;
namespace UnitTests;

public class HelpersTests
{
  [TestFixture]
  public class CheckGameSelectionIsValid
  {
    [Test]
    public void ValidInput_ReturnsTrue()
    {
      // Arrange 
      string input = "1";

      // Act 
      bool result = Helpers.CheckGameSelectionIsValid(input);

      // Assert 
      Assert.That(result);
    }
    [Test]
    public void InvalidInputLetter_ReturnsFalse()
    {
      string input = "a";
      bool result = Helpers.CheckGameSelectionIsValid(input);
      Assert.That(!result);
    }

    [Test]
    public void InvalidInputNumber_ReturnsFalse()
    {
      string input = "7";
      bool result = Helpers.CheckGameSelectionIsValid(input);
      Assert.That(!result);
    }
  }
}