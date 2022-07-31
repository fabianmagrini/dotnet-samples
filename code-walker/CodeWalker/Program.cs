using Common;

ConfigValidator configValidator = new ConfigValidator();
Walker w = new Walker();
w.Traverse(".", (fi) => 
{ 
    
    if (configValidator.IsValid(fi)) 
    {
        Console.WriteLine("{0}", fi.FullName); 
    }
    
    return true;
});
