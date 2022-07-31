using System.Text.RegularExpressions;
using System.IO;

namespace Common;

public class ConfigValidator
{
    public bool IsValid(FileInfo fileInfo)
    {
        // "((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#!$%]).{8,20})"
        Regex configExpression = new Regex(@"(applicationhost\.config|app\.config|web\.config)$");
        return configExpression.IsMatch(fileInfo.Name.ToLower());
    }
}
