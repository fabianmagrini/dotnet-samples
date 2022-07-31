using Common;
using System.IO;

namespace Common.Tests;

public class ValidatorTest
{
    [Fact]
    public void ValidConfig()
    {
      //Arrange
      var validator = new ConfigValidator();
      FileInfo fi = new FileInfo("web.config");

      //Act
      bool isValid = validator.IsValid(fi);

      //Assert
      Assert.True(isValid, $"The file {fi.Name} is not valid");
    }

    [Fact]
    public void NotValidConfig()
    {
      //Arrange
      var validator = new ConfigValidator();
      FileInfo fi = new FileInfo("appsettings.json");

      //Act
      bool isValid = validator.IsValid(fi);

      //Assert
      Assert.False(isValid, $"The file {fi.Name} should not be valid!");
    }

    [Fact]
    public void ValidAppSettings()
    {
      //Arrange
      var validator = new AppSettingsValidator();
      FileInfo fi = new FileInfo("appsettings.json");

      //Act
      bool isValid = validator.IsValid(fi);

      //Assert
      Assert.True(isValid, $"The file {fi.Name} is not valid");
    }

    [Fact]
    public void NotValidAppSettings()
    {
      //Arrange
      var validator = new AppSettingsValidator();
      FileInfo fi = new FileInfo("web.config");

      //Act
      bool isValid = validator.IsValid(fi);

      //Assert
      Assert.False(isValid, $"The file {fi.Name} should not be valid!");
    }
}