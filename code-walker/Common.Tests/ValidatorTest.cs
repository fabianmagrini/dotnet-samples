using Common;
using System.IO;

namespace Common.Tests;

public class ValidatorTest
{
    [Fact]
    public void ValidConfig()
    {
      //Arrange
      var configValidator = new ConfigValidator();
      FileInfo fi = new FileInfo("web.config");

      //Act
      bool isValid = configValidator.IsValid(fi);

      //Assert
      Assert.True(isValid, $"The file {fi.Name} is not valid");
    }

    [Fact]
    public void NotValidConfig()
    {
      //Arrange
      var configValidator = new ConfigValidator();
      FileInfo fi = new FileInfo("appsettings.json");

      //Act
      bool isValid = configValidator.IsValid(fi);

      //Assert
      Assert.False(isValid, $"The file {fi.Name} should not be valid!");
    }

}