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
      // Arrange 
      string input = "a";

      // Act 
      bool result = Helpers.CheckGameSelectionIsValid(input);

      // Assert 
      Assert.That(!result);
    }

    [Test]
    public void InvalidInputNumber_ReturnsFalse()
    {
      // Arrange 
      string input = "6";

      // Act 
      bool result = Helpers.CheckGameSelectionIsValid(input);

      // Assert 
      Assert.That(!result);
    }
  }


}