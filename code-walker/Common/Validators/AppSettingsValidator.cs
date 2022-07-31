using System.Text.RegularExpressions;
using System.IO;

namespace Common;

public class AppSettingsValidator
{
    public bool IsValid(FileInfo fileInfo)
    {
        Regex configExpression = new Regex(@"(appsettings\.json)$");
        return configExpression.IsMatch(fileInfo.Name.ToLower());
    }
}
