using System.Xml;

namespace Common;

public class ConfigReader
{
    public void Parse(FileInfo fileInfo)
    {
        XmlDocument doc = new XmlDocument();
        doc.PreserveWhitespace = true;
        try { 
            doc.Load(fileInfo.FullName); 
            var connectionStringsNode = doc.SelectSingleNode("//connectionStrings");
            if(connectionStringsNode != null)
                Console.WriteLine(connectionStringsNode.OuterXml);
        }
        catch (System.IO.FileNotFoundException) {
            Console.WriteLine($"Error with {fileInfo.FullName}");
        }
    }
}