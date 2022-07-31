using System.Text.RegularExpressions;
using Common;

Walker w = new Walker();
w.Traverse(".", (fi) => 
{ 
    // Match the end of a string.
    if (Regex.IsMatch(fi.Name.ToLower(), @"(applicationhost\.config|app\.config|web\.config|appsettings\.json)$"))
    {
        //Console.WriteLine("{0}: {1}, {2}", fi.FullName, fi.Name, fi.Extension); 
        Console.WriteLine("{0}", fi.FullName); 
    }
    
    return true;
});
